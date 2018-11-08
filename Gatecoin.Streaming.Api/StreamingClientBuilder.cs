using System;
using System.Net.Http;
using Gatecoin.Streaming.Dto;
using Microsoft.Extensions.Logging;

namespace Gatecoin.Streaming.Api
{
    public sealed class StreamingClientBuilder : IStreamingClientBuilder
    {
        private readonly string _url;
        private HttpMessageHandler _httpMessageHandler;
        private ILoggerFactory _loggerFactory;

        public StreamingClientBuilder()
        {
            _url = "https://streaming.gtcprojects.com";
        }

        public IStreamingClient<TDto> BuildClient<TDto>() where TDto : BaseDto
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

        public StreamingClientBuilder WithHttpMessageHandler(HttpMessageHandler httpMessageHandler)
        {
            _httpMessageHandler = httpMessageHandler;
            return this;
        }

        public StreamingClientBuilder WithLoggerFactory(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            return this;
        }
    }
}