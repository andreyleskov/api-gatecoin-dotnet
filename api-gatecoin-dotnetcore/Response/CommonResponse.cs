using ServiceStack;

namespace GatecoinServiceInterface.Response
{
    public class CommonResponse : IHasResponseStatus
    {
        public ResponseStatus ResponseStatus { get; set; }
    }
}