using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class Document_RegisteredResponse : CommonResponse
    {
        public DocumentStatus Status { get; set; }
    }
}