using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/preview/Account/TermsAndConditionsStatus", "POST", Summary = @"Accept T&C", Notes = @"")]
    public class AcceptTermsAndCondition : IReturn<CommonResponse>
    {
        [ApiMember(Name = "AcceptedTermsAndConditions",
            Description = "Whether or not the logged in user has accepted the T&C", ParameterType = "query",
            DataType = "bool", IsRequired = false)]
        public bool AcceptedTermsAndConditions { get; set; }
    }
}