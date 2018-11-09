using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Questionnaire", "POST", Summary = @"Fill Questionnaire", Notes = @"")]
    public class FillQuestionnaire : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Answer001", Description = "Q1: Experience digital currencies", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer001 { get; set; }

        [ApiMember(Name = "Answer002", Description = "Q1: Speculate/invest", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer002 { get; set; }

        [ApiMember(Name = "Answer003", Description = "Q1: Convert mined bitcions", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer003 { get; set; }

        [ApiMember(Name = "Answer004", Description = "Q1: Remit", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer004 { get; set; }

        [ApiMember(Name = "Answer005", Description = "Q1: Do some payments", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer005 { get; set; }

        [ApiMember(Name = "Answer006", Description = "Q1: Receive payments", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer006 { get; set; }

        [ApiMember(Name = "Answer007", Description = "Q1: Process payments for third parties", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer007 { get; set; }

        [ApiMember(Name = "Answer008", Description = "Q1: Process remittances for third parties", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer008 { get; set; }

        [ApiMember(Name = "Answer009", Description = "Q1: Trade for third parties", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer009 { get; set; }

        [ApiMember(Name = "Answer010", Description = "Q1: Other, please specify:", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer010 { get; set; }

        [ApiMember(Name = "Answer011", Description = "Q2: Salaray Range(USD)", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer011 { get; set; }

        [ApiMember(Name = "Answer012", Description = "Q3: Digital currency mining", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer012 { get; set; }

        [ApiMember(Name = "Answer013", Description = "Q3: Employment income", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer013 { get; set; }

        [ApiMember(Name = "Answer014", Description = "Q3: Gift or inheritance from a third party", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer014 { get; set; }

        [ApiMember(Name = "Answer015", Description = "Q3: The disposal of a business or other asset", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer015 { get; set; }

        [ApiMember(Name = "Answer016", Description = "Q3: Clients: Remittance or payment processing; trading for third parties", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer016 { get; set; }

        [ApiMember(Name = "Answer017", Description = "Q3: Other, please specify", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String Answer017 { get; set; }
    }
}
