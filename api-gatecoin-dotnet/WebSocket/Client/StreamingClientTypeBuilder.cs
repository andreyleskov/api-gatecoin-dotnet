using System;
using System.Net.Http;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace GatecoinServiceInterface.WebSocket.Client
{
    internal sealed class StreamingClientTypeBuilder : IStreamingClientTypeBuilder
    {
        private readonly string _url;
        private HttpMessageHandler _httpMessageHandler;
        private ILoggerFactory _loggerFactory;

        public StreamingClientTypeBuilder()
        {
            _url = "https://streaming.gtcprojects.com";
        }

        public IStreamingClient<TDto> BuildClient<TDto>()
        {
            if (string.IsNullOrWhiteSpace(_url))
            {
                throw new ArgumentException("Url cannot be null", nameof(_url));
            }

            return new StreamingClient<TDto>(
                _url,
                _httpMessageHandler,
                _loggerFactory);
        }

        [PublicAPI]
        public StreamingClientTypeBuilder WithHttpMessageHandler(HttpMessageHandler httpMessageHandler)
        {
            _httpMessageHandler = httpMessageHandler;
            return this;
        }

        [PublicAPI]
        public StreamingClientTypeBuilder WithLoggerFactory(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            return this;
        }
    }
}