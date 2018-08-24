using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;

namespace GatecoinServiceInterface.Request
{
    [Route("/preview/Account/TermsAndConditionsStatus", "POST", Summary = @"Accept T&C", Notes = @"")]
    public class PostTermsAndConditionResponse : IReturn<GetTermsAndConditionsResponse>
    {
        [ApiMember(Name = "AcceptedTermsAndConditions", Description = "Whether or not the logged in user has accepted the T&C", ParameterType = "query", DataType = "bool", IsRequired = false)]
        public Boolean AcceptedTermsAndConditions { get; set; }
    }

    [Route("/preview/Account/TermsAndConditionsStatus", "POST", Summary = @"Accept T&C", Notes = @"")]
    public class PostTermsAndConditionResponseAsNull : IReturn<GetTermsAndConditionsResponse>
    {
        [ApiMember(Name = "AcceptedTermsAndConditions", Description = "Whether or not the logged in user has accepted the T&C", ParameterType = "query", DataType = "string", IsRequired = false)]
        public String AcceptedTermsAndConditions { get; set; }
    }
}


