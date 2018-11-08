using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Questionnaire", "GET", Summary = @"Fill the questionnaire", Notes = @"")]
    public class GetQuestion : IReturn<QuestionnaireResponse>
    {
    }
}