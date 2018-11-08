using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class DocumentInformationResponse : CommonResponse
    {
        public DocumentStatus IDStatus { get; set; }
        public DocumentStatus ProofStatus { get; set; }
    }
}