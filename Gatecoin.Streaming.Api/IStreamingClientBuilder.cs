using Gatecoin.Streaming.Dto;
using JetBrains.Annotations;

namespace Gatecoin.Streaming.Api
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
        IStreamingClient<TDto> BuildClient<TDto>() where TDto : BaseDto;
    }
}