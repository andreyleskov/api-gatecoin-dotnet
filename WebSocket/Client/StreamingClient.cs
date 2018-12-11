using System;
using System.Net.Http;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace GatecoinServiceInterface.WebSocket.Client
{
    internal sealed class StreamingClient<TDto> : IStreamingClient<TDto>
    {
        private const string ApiPublicKey = "API_PUBLIC_KEY";
        private const string ApiRequestSignature = "API_REQUEST_SIGNATURE";
        private const string ApiRequestDate = "API_REQUEST_DATE";

        private readonly HubConnection _connection;
        private readonly HttpMessageHandler _httpMessageHandler;
        private readonly ILogger _logger;

        internal StreamingClient(
            string url,
            AccessToken token = null,
            HttpMessageHandler httpMessageHandler = null,
            ILoggerFactory loggerFactory = null)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Url cannot be null", nameof(url));
            }

            _httpMessageHandler = httpMessageHandler;

            _logger = (loggerFactory ?? new NullLoggerFactory()).CreateLogger(GetType());

            url = url.TrimEnd('/');

            if (token != null && !IsTokenValid(token))
            {
                throw new ArgumentException("If AccessToken is passed as a parameter, all the fields should be valid");
            }

            var urlHub = token != null ? $"{url}{Channels.GetPrivateChannelHub<TDto>()}" : $"{url}{Channels.GetChannelHub<TDto>()}";

            _connection = new HubConnectionBuilder()
                .WithUrl(
                    urlHub,
                    options =>
                    {
                        if (httpMessageHandler != null)
                        {
                            options.HttpMessageHandlerFactory = _ => httpMessageHandler;
                        }

                        if (token != null)
                        {
                            options.Headers.Add(ApiPublicKey, token.PublicKey);
                            options.Headers.Add(ApiRequestSignature, token.SignedMessage);
                            options.Headers.Add(ApiRequestDate, token.DateTime.ToUnixTimeString());
                        }
                    })
                .AddJsonProtocol()
                .Build();

            _connection.Closed += OnConnectionOnClosed;

        }
        
        public event EventHandler<DisconnectEventArgs<TDto>> Disconnected;

        [Pure]
        [PublicAPI]
        public IDisposable Subscribe(string currencyPair, Action<TDto> handler)
        {
            if (handler == null)
            {
                throw new ArgumentException("Handler cannot be null", nameof(handler));
            }

            return _connection.On<TDto>(
                currencyPair,
                arg =>
                {
                    try
                    {
                        handler(arg);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex.ToString());
                        throw;
                    }
                });
        }

        [Pure]
        [PublicAPI]
        public IDisposable SubscribeAll(Action<TDto> handler)
        {
            if (handler == null)
            {
                throw new ArgumentException("Handler cannot be null", nameof(handler));
            }

            return _connection.On<TDto>(
                EventTypes.BroadcastMessage,
                arg =>
                {
                    try
                    {
                        handler(arg);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex.ToString());
                        throw;
                    }
                });
        }

        [PublicAPI]
        public async Task<IStreamingClient<TDto>> Start()
        {
            await _connection.StartAsync();
            _logger.Log(LogLevel.Information, "Connection started");
            return this;
        }

        [Pure]
        [PublicAPI]
        public async Task<IStreamingClient<TDto>> Stop()
        {
            await _connection.StopAsync();
            return this;
        }

        public void Dispose()
        {
            _connection?.StopAsync().Wait();
            _connection?.DisposeAsync().Wait();
            _httpMessageHandler?.Dispose();
        }

        private static bool IsTokenValid(AccessToken token)
        {
            return
                !string.IsNullOrWhiteSpace(token.PublicKey) &&
                !string.IsNullOrWhiteSpace(token.SignedMessage) &&
                token.DateTime != default(DateTime);
        }

        private Task OnConnectionOnClosed(Exception error)
        {
            _logger.LogWarning("Connection closed {error}", error?.Message ?? "by the user.");

            OnDisconnected(new DisconnectEventArgs<TDto>(this, error));

            return Task.CompletedTask;
        }

        private void OnDisconnected(DisconnectEventArgs<TDto> e)
        {
            var handler = Disconnected;

            handler?.Invoke(this, e);
        }
    }
}