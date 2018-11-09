using System;
using System.Globalization;
using System.IO;
using System.Net;
using GatecoinServiceInterface.Request;
using ServiceStack;
using ServiceStack.Text;

namespace GatecoinServiceInterface.Client
{
    public class ServiceClient
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private readonly JsonServiceClient _client;
        public ErrorEventHandler OnLoginFailed;

        public EventHandler OnLoginSuccess;
        public EventHandler OnLogout;

        private readonly Action<HttpWebRequest> _requestFilter;

        public ServiceClient() : this("https://api.gatecoin.com/")
        {
        }

        public ServiceClient(string url)
        {
            ServicePointManager.ServerCertificateValidationCallback = (req, cert, chain, errors) => true;
            _client = new JsonServiceClient(url);
            JsConfig<DateTime>.RawDeserializeFn = arg => { return UnixTimeStampToDateTime(arg); };
            JsConfig<DateTime?>.RawDeserializeFn = arg =>
                                                   {
                                                       return arg == null
                                                           ? null
                                                           : (DateTime?) UnixTimeStampToDateTime(arg);
                                                   };
            _requestFilter = request =>
                            {
                                if (HasAuthenticationKeys)
                                {
                                    request.ContentType = "application/json";

                                    if (HasProxy) request.Proxy = new WebProxy(Proxy);

                                    // always use fixed-point with 3 digits after the decimal point independent of the current culture
                                    var unixTimestamp = ToUnixTimeStamp(DateTime.Now)
                                        .ToString("F3",
                                            CultureInfo
                                                .InvariantCulture);

                                    var secret = ApiPrivateKey;
                                    var token = ServiceSignature.CreateToken(request, secret,
                                        unixTimestamp);
                                    request.Headers[ServiceSignature.API_PUBLIC_KEY] =
                                        ApiPublicKey;
                                    request.Headers[ServiceSignature.API_REQUEST_SIGNATURE] =
                                        token;
                                    request.Headers[ServiceSignature.API_REQUEST_DATE] =
                                        unixTimestamp;
                                }
                            };
        }

        protected string ApiPublicKey { get; set; }
        protected string ApiPrivateKey { get; set; }
        public string Proxy { get; set; }

        protected bool HasAuthenticationKeys =>
            !string.IsNullOrWhiteSpace(ApiPublicKey) && !string.IsNullOrWhiteSpace(ApiPrivateKey);

        protected bool HasProxy => !string.IsNullOrWhiteSpace(Proxy);

        protected JsonServiceClient Client => _client;

        private static DateTime UnixTimeStampToDateTime(string arg)
        {
            var unixTimeStamp = Convert.ToDouble(arg);
            // Unix timestamp is seconds past epoch in UTC
            return UnixEpoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }

        private static double ToUnixTimeStamp(DateTime date)
        {
            return (date.ToUniversalTime() - UnixEpoch).TotalSeconds;
        }

        public bool Login(string userName, string password, string validationCode, string captcha = null)
        {
            var response = _client.Post(new Login
                                       {
                                           UserName = userName, Password = password,
                                           ValidationCode = validationCode, CaptchaResponse = captcha
                                       });
            if (response.IsSuccess)
            {
                ApiPublicKey = response.PublicKey;
                ApiPrivateKey = response.ApiKey;
                if (_client.RequestFilter == null) _client.RequestFilter += _requestFilter;

                if (OnLoginSuccess != null) OnLoginSuccess(this, EventArgs.Empty);
            }
            else
            {
                if (OnLoginFailed != null)
                    OnLoginFailed(this, new ErrorEventArgs(new Exception(response.ResponseStatus.Message)));
            }

            return response.IsSuccess;
        }

        public void Logout()
        {
            if (HasAuthenticationKeys)
            {
                var res = _client.Post(new Logout());
                if (res.ResponseStatus.ErrorCode != null ||
                    res.ResponseStatus.Message != "OK")
                    throw new WebServiceException("/Auth/Logout has failed!");
            }

            ApiPublicKey = null;
            ApiPrivateKey = null;
            _client.RequestFilter -= _requestFilter;
            if (OnLogout != null) OnLogout(this, EventArgs.Empty);
        }

        public bool Login(string userName, string password, string captcha = null)
        {
            return Login(userName, password, null, captcha);
        }

        public void SetApiKey(string publicKey, string privateKey)
        {
            ApiPublicKey = publicKey;
            ApiPrivateKey = privateKey;
            if (_client.RequestFilter == null) _client.RequestFilter += _requestFilter;
        }

        public void ClearApiKey()
        {
            ApiPublicKey = null;
            ApiPrivateKey = null;
            _client.RequestFilter -= _requestFilter;
        }

        #region Get

        public TResponse Get<TResponse>(IReturn<TResponse> request)
        {
            return _client.Get<TResponse>(request);
        }

        public void Get(IReturnVoid request)
        {
            _client.Get(request);
        }

        public TResponse Get<TResponse>(string relativeOrAbsoluteUrl)
        {
            return _client.Get<TResponse>(relativeOrAbsoluteUrl);
        }

        public void GetAsync<TResponse>(IReturn<TResponse> request)
        {
            _client.GetAsync<TResponse>(request);
        }

        [Obsolete("Will be removed. Use GetAsync(request) function")]
        public void GetAsync<TResponse>(
            IReturn<TResponse> request, 
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.GetAsync<TResponse>(request/*, onSuccess, onError*/);
        }

        public void GetAsync<TResponse>(
            string relativeOrAbsoluteUrl)
        {
            _client.GetAsync<TResponse>(relativeOrAbsoluteUrl);
        }

        [Obsolete("Will be removed. Use GetAsync(relativeOrAbsoluteUrl) function")]
        public void GetAsync<TResponse>(
            string relativeOrAbsoluteUrl, 
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.GetAsync<TResponse>(relativeOrAbsoluteUrl/*, onSuccess, onError*/);
        }

        #endregion

        #region Post

        public TResponse Post<TResponse>(IReturn<TResponse> request)
        {
            return _client.Post<TResponse>(request);
        }

        public void Post(IReturnVoid request)
        {
            _client.Post(request);
        }

        public TResponse Post<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            return _client.Post<TResponse>(relativeOrAbsoluteUrl, request);
        }

        [Obsolete("Will be removed. Use PostAsync(request) function")]
        public void PostAsync<TResponse>(
            IReturn<TResponse> request,
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.PostAsync<TResponse>(request/*, onSuccess, onError*/);
        }

        [Obsolete("Will be removed. Use PostAsync(relativeOrAbsoluteUrl) function")]
        public void PostAsync<TResponse>(
            string relativeOrAbsoluteUrl,
            object request,
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.PostAsync<TResponse>(relativeOrAbsoluteUrl, request/*, onSuccess, onError*/);
        }

        public void PostAsync<TResponse>(IReturn<TResponse> request)
        {
            _client.PostAsync<TResponse>(request);
        }

        public void PostAsync<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            _client.PostAsync<TResponse>(relativeOrAbsoluteUrl, request);
        }


        #endregion

        #region Delete

        public TResponse Delete<TResponse>(IReturn<TResponse> request)
        {
            return _client.Delete<TResponse>(request);
        }

        public void Delete(IReturnVoid request)
        {
            _client.Delete(request);
        }

        public TResponse Delete<TResponse>(string relativeOrAbsoluteUrl)
        {
            return _client.Delete<TResponse>(relativeOrAbsoluteUrl);
        }

        [Obsolete("Will be removed. Use DeleteAsync(request) function")]
        public void DeleteAsync<TResponse>(
            IReturn<TResponse> request, 
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.DeleteAsync<TResponse>(request/*, onSuccess, onError*/);
        }

        [Obsolete("Will be removed. Use DeleteAsync(relativeOrAbsoluteUrl) function")]
        public void DeleteAsync<TResponse>(
            string relativeOrAbsoluteUrl, 
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.DeleteAsync<TResponse>(relativeOrAbsoluteUrl/*, onSuccess, onError*/);
        }

        public void DeleteAsync<TResponse>(IReturn<TResponse> request)
        {
            _client.DeleteAsync<TResponse>(request);
        }

        public void DeleteAsync<TResponse>(string relativeOrAbsoluteUrl)
        {
            _client.DeleteAsync<TResponse>(relativeOrAbsoluteUrl);
        }
        
        #endregion

        #region Put

        public TResponse Put<TResponse>(IReturn<TResponse> request)
        {
            return _client.Put<TResponse>(request);
        }

        public void Put(IReturnVoid request)
        {
            _client.Post(request);
        }

        public TResponse Put<TResponse>(string relativeOrAbsoluteUrl, object request)
        {
            return _client.Put<TResponse>(relativeOrAbsoluteUrl, request);
        }

        [Obsolete("Will be removed. Use PutAsync(request) function")]
        public void PutAsync<TResponse>(
            IReturn<TResponse> request, 
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.PutAsync<TResponse>(request/*, onSuccess, onError*/);
        }

        [Obsolete("Will be removed. Use PutAsync(relativeOrAbsoluteUrl) function")]
        public void PutAsync<TResponse>(
            string relativeOrAbsoluteUrl, 
            object request, 
            Action<TResponse> onSuccess,
            Action<TResponse, Exception> onError)
        {
            _client.PostAsync<TResponse>(relativeOrAbsoluteUrl, request);
        }

        public void PutAsync<TResponse>(IReturn<TResponse> request)
        {
            _client.PutAsync<TResponse>(request);
        }

        public void PutAsync<TResponse>(
            string relativeOrAbsoluteUrl,
            object request)
        {
            _client.PostAsync<TResponse>(relativeOrAbsoluteUrl, request);
        }

        #endregion

        #region PostFile

        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, FileInfo fileToUpload, string mimeType)
        {
            return _client.PostFile<TResponse>(relativeOrAbsoluteUrl, fileToUpload, mimeType);
        }

        public TResponse PostFile<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload, string fileName,
            string mimeType)
        {
            return _client.PostFile<TResponse>(relativeOrAbsoluteUrl, fileToUpload, fileName, mimeType);
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, FileInfo fileToUpload,
            object request)
        {
            return _client.PostFileWithRequest<TResponse>(relativeOrAbsoluteUrl, fileToUpload, request);
        }

        public TResponse PostFileWithRequest<TResponse>(string relativeOrAbsoluteUrl, Stream fileToUpload,
            string fileName, object request)
        {
            return _client.PostFileWithRequest<TResponse>(relativeOrAbsoluteUrl, fileToUpload, fileName, request);
        }

        #endregion
    }
}