using GatecoinServiceInterface.Request;
using GatecoinServiceInterface.Response;
using ServiceStack.ServiceClient.Web;
using ServiceStack.ServiceHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GatecoinServiceInterface.Client
{
    public class ServiceClient
    {
        static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private JsonServiceClient client;
        private LoginResponse loginSession;
        private string publicKey;
        private string privateKey;

        protected bool HasAuthenticationKeys {
            get {
                return !String.IsNullOrWhiteSpace(publicKey) && !String.IsNullOrWhiteSpace(privateKey);
            }
        }

        protected JsonServiceClient Client {
            get {
                return client;
            }
        }

        public ServiceClient() : this("https://api.gatecoin.com/")
        {
        }

        public ServiceClient(string url)
        {
            client = new JsonServiceClient(url);
            ServiceStack.Text.JsConfig<DateTime>.RawDeserializeFn = (arg) => { return UnixTimeStampToDateTime(arg); };
            ServiceStack.Text.JsConfig<DateTime?>.RawDeserializeFn = (arg) => { return arg == null ? null : (DateTime?)UnixTimeStampToDateTime(arg); };
            requestFilter = new Action<HttpWebRequest>((request) =>
            {
                if (HasAuthenticationKeys)
                {
                    request.ContentType = ServiceStack.Common.Web.ContentType.Json;
                    string unixTimestamp = ToUnixTimeStamp(DateTime.Now).ToString();

                    var secret = privateKey;
                    var token = ServiceSignature.CreateToken(request, secret, unixTimestamp);
                    request.Headers[ServiceSignature.API_PUBLIC_KEY] = publicKey;
                    request.Headers[ServiceSignature.API_REQUEST_SIGNATURE] = token;
                    request.Headers[ServiceSignature.API_REQUEST_DATE] = unixTimestamp;
                }
            });
        }

        private static DateTime UnixTimeStampToDateTime(string arg)
        {
            double unixTimeStamp = Convert.ToDouble(arg);
            // Unix timestamp is seconds past epoch in UTC
            return UnixEpoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }

        private static double ToUnixTimeStamp(DateTime date)
        {
            return (date.ToUniversalTime() - UnixEpoch).TotalSeconds;
        }

        private Action<HttpWebRequest> requestFilter;

        public bool Login(string userName, string password, string validationCode)
        {
            try
            {
                var response = client.Post(new Login() { UserName = userName, Password = password, ValidationCode = validationCode });
                if (response.IsSuccess)
                {
                    loginSession = response;
                    publicKey = response.PublicKey;
                    privateKey = response.ApiKey;
                    if (client.LocalHttpWebRequestFilter == null)
                    {
                        client.LocalHttpWebRequestFilter += requestFilter;
                    }
                    if (OnLoginSuccess != null)
                    {
                        OnLoginSuccess(this, EventArgs.Empty);
                    }
                }
                else
                {
                    if (OnLoginFailed != null)
                    {
                        OnLoginFailed(this, new ErrorEventArgs(new Exception(response.ResponseStatus.Message)));
                    }
                }
                return response.IsSuccess;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Logout()
        {
            if (HasAuthenticationKeys) {
                var res = client.Post(new GatecoinServiceInterface.Request.Logout());
                if (res.ResponseStatus.ErrorCode != null ||
                    res.ResponseStatus.Message != "OK") {
                    throw new WebServiceException("/Auth/Logout has failed!");
                }
            }

            loginSession = null;
            publicKey = null;
            privateKey = null;
            client.LocalHttpWebRequestFilter -= requestFilter;
            if (OnLogout != null)
            {
                OnLogout(this, EventArgs.Empty);
            }
        }

        public bool Login(string userName, string password)
        {
            return Login(userName, password, null);
        }

        public void SetApiKey(string publicKey, string privateKey)
        {
            this.publicKey = publicKey;
            this.privateKey = privateKey;
            if (client.LocalHttpWebRequestFilter == null)
            {
                client.LocalHttpWebRequestFilter += requestFilter;
            }
        }

        public void ClearApiKey()
        {
            publicKey = null;
            privateKey = null;
            client.LocalHttpWebRequestFilter -= requestFilter;
        }

        public EventHandler OnLoginSuccess;
        public ErrorEventHandler OnLoginFailed;
        public EventHandler OnLogout;

        #region Get
        public TResponse Get<TResponse>(IReturn<TResponse> request)
        {
            return client.Get<TResponse>(request);
        }

        public void Get(IReturnVoid request)
        {
            client.Get(request);
        }

        public TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
            return client.Get<TResponse>(relativeOrAbsoluteUrl);

        }

        public void GetAsync<TResponse>(IReturn<TResponse> request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.GetAsync<TResponse>(request, onSuccess, onError);
        }

        public void GetAsync<TResponse>(string relativeOrAbsoluteUrl, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.GetAsync<TResponse>(relativeOrAbsoluteUrl, onSuccess, onError);
        }
        #endregion

        #region Post
        public TResponse Post<TResponse>(IReturn<TResponse> request)
        {
            return client.Post<TResponse>(request);
        }

        public void Post(IReturnVoid request)
        {
            client.Post(request);
        }

        public TResponse Post<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            return client.Post<TResponse>(relativeOrAbsoluteUrl, request);
        }

        public void PostAsync<TResponse>(IReturn<TResponse> request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.PostAsync<TResponse>(request, onSuccess, onError);
        }

        public void PostAsync<TResponse>(string relativeOrAbsoluteUrl, object request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.PostAsync<TResponse>(relativeOrAbsoluteUrl, request, onSuccess, onError);
        }
        #endregion

        #region Delete
        public TResponse Delete<TResponse>(IReturn<TResponse> request)
        {
            return client.Delete<TResponse>(request);
        }

        public void Delete(IReturnVoid request)
        {
            client.Delete(request);
        }

        public TResponse Delete<TResponse>(string relativeOrAbsoluteUrl)
        {
            return client.Delete<TResponse>(relativeOrAbsoluteUrl);
        }

        public void DeleteAsync<TResponse>(IReturn<TResponse> request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.DeleteAsync<TResponse>(request, onSuccess, onError);
        }

        public void DeleteAsync<TResponse>(string relativeOrAbsoluteUrl, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.DeleteAsync<TResponse>(relativeOrAbsoluteUrl, onSuccess, onError);
        }
        #endregion

        #region Put
        public TResponse Put<TResponse>(IReturn<TResponse> request)
        {
            return client.Put<TResponse>(request);
        }

        public void Put(IReturnVoid request)
        {
            client.Post(request);
        }

        public TResponse Put<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            return client.Put<TResponse>(relativeOrAbsoluteUrl, request);
        }

        public void PutAsync<TResponse>(IReturn<TResponse> request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.PutAsync<TResponse>(request, onSuccess, onError);
        }

        public void PutAsync<TResponse>(string relativeOrAbsoluteUrl, object request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError)
        {
            client.PostAsync<TResponse>(relativeOrAbsoluteUrl, request, onSuccess, onError);
        }
        #endregion

        #region PostFile
        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, FileInfo fileToUpload, string mimeType)
        {
            return client.PostFile<TResponse>(relativeOrAbsoluteUrl, fileToUpload, mimeType);
        }

        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName, string mimeType)
        {
            return client.PostFile<TResponse>(relativeOrAbsoluteUrl, fileToUpload, fileName, mimeType);
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, FileInfo fileToUpload, object request)
        {
            return client.PostFileWithRequest<TResponse>(relativeOrAbsoluteUrl, fileToUpload, request);
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName, object request)
        {
            return client.PostFileWithRequest<TResponse>(relativeOrAbsoluteUrl, fileToUpload, fileName, request);
        }
        #endregion
    }
}
