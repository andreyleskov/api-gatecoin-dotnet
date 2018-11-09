using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Questionnaire", "GET", Summary = @"Fill the questionnaire", Notes = @"")]
public class GetQuestion : IReturn<QuestionnaireResponse>
{
}
}

