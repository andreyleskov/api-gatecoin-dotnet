using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Auth/SecurityQuestionAnswer", "POST", Summary = @"Set security question and answer for reset password", Notes = @"")]
public class SecurityQuestionAnswer : IReturn<CommonResponse>
{
[ApiMember(Name = "Question", Description = "Security question (Max 80 char)", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Question {get; set; } 
[ApiMember(Name = "Answer", Description = "Security answer (Max 80 char)", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Answer {get; set; } 
[ApiMember(Name = "Password", Description = "Password is required to set security question and answer", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
}
}

