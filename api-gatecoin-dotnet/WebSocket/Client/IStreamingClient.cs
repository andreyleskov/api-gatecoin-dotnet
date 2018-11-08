using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public interface IStreamingClient<out TDto> : IDisposable
    {
        /// <summary>
        /// Starts connection
        /// </summary>
        [PublicAPI]
        Task Start();

        /// <summary>
        /// Registers a handler that will be invoked with all events.
        /// </summary>
        /// <param name="handler">The handler that will be raised when the hub method is invoked.</param>
        /// <returns>A subscription that can be disposed to unsubscribe from the hub method.</returns>
        [PublicAPI]
        [Pure]
        IDisposable SubscribeAll(Action<TDto> handler);


        /// <summary>
        /// Registers a handler that will be invoked when the hub method with the specified method name is invoked.
        /// </summary>
        /// <param name="currencyPair">A name for event with specified currency pair</param>
        /// <param name="handler">The handler that will be raised when the hub method is invoked.</param>
        /// <returns>A subscription that can be disposed to unsubscribe from the hub method.</returns>
        [PublicAPI]
        [Pure]
        IDisposable Subscribe(string currencyPair, Action<TDto> handler);
    }
}