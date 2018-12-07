using System;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public class DisconnectEventArgs<TDto> : EventArgs
    {
        public DisconnectEventArgs(IStreamingClient<TDto> client, Exception exception)
        {
            Client = client;
            Exception = exception;
        }

        public Exception Exception { get; }
        public IStreamingClient<TDto> Client { get; }
    }
}