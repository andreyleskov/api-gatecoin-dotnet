using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class Document_IDResponse : CommonResponse
    {
        public DocumentStatus Status { get; set; }
    }
}