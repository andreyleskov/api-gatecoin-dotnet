using JetBrains.Annotations;

namespace GatecoinServiceInterface.WebSocket.Client
{
    public interface IStreamingClientBuilder
    {
        /// <summary>
        /// Builds and creates Gatecoin streaming client
        /// </summary>
        /// <typeparam name="TDto">Event data type</typeparam>
        /// <returns>return Gatecoin streaming client</returns>
        [PublicAPI]
        [Pure]
        IStreamingClient<TDto> BuildClient<TDto>();
    }
}