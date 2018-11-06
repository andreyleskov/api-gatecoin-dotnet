using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using ServiceStack.Web;

namespace GatecoinServiceInterface.Client
{
    internal static class ServiceSignature
    {
        public const string API_PUBLIC_KEY = "API_PUBLIC_KEY";
        public const string API_REQUEST_SIGNATURE = "API_REQUEST_SIGNATURE";
        public const string API_REQUEST_DATE = "API_REQUEST_DATE";

        /// <summary>
        ///     Used by SDK and clients to make requests, so we must use the HttpWebRequest class
        /// </summary>
        /// <param name="webRequest"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        public static string CreateToken(HttpWebRequest webRequest, string secret, string unixTimestamp)
        {
            return CreateToken(FlattenRequestDetails(webRequest.Method,
                webRequest.RequestUri.AbsoluteUri,
                webRequest.ContentType,
                unixTimestamp
            ), secret);
        }

        /// <summary>
        ///     Used by Server so we must use the Service Stack IHttpRequest
        /// </summary>
        /// <param name="request"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        public static string CreateToken(IHttpRequest request, string secret)
        {
            return CreateToken(FlattenRequestDetails(request.HttpMethod,
                request.AbsoluteUri,
                request.ContentType,
                GetDate(request)
            ), secret);
        }

        private static string CreateToken(string message, string secret)
        {
            // don't allow null secrets
            secret = secret ?? "";
            var encoding = new ASCIIEncoding();
            var keyByte = encoding.GetBytes(secret);
            var messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                var hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        private static string FlattenRequestDetails(string httpMethod, string url, string contentType, string date)
        {
            // If it is a GET then we don't care about the contentType since there will never be contentTypes with GET.
            if (httpMethod.ToUpper() == "GET")
                contentType = "";

            var message = string.Format("{0}{1}{2}{3}", httpMethod, url, contentType.Split(';')[0], date);
            return message.ToLower();
        }

        /// <summary>
        ///     If the user is providing the date via the custom header then the server
        ///     will use that for the hash. Otherwise we check for the default "Date" header.
        ///     This is nessary since some consumers can't control the date header in their web requests
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetDate(IHttpRequest request)
        {
            return request.Headers[API_REQUEST_DATE] ?? request.Headers["Date"] ?? "";
        }

        /// <summary>
        ///     Public user id to identify the user
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public static string GetSignature(IHttpRequest req)
        {
            return req.Headers[API_REQUEST_SIGNATURE] ?? "";
        }

        public static string GetPublicKey(IHttpRequest req)
        {
            return req.Headers[API_PUBLIC_KEY] ?? "";
        }
    }
}