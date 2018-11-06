using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class QuestionnaireResponse : CommonResponse
    {
        public DocumentStatus QuestionnaireStatus { get; set; }
    }
}