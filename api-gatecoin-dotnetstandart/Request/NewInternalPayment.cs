using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/InternalPayment", "POST", Summary = @"InternalPayment", Notes = @"")]
    public class NewInternalPayment : IReturn<InternalPaymentResponse>
    {
        [ApiMember(Name = "ReferralCode", Description = "ReferralCode", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string ReferralCode { get; set; }

        [ApiMember(Name = "Currency", Description = "Currency", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Currency { get; set; }

        [ApiMember(Name = "Amount", Description = "Amount", ParameterType = "query", DataType = "decimal",
            IsRequired = false)]
        public decimal Amount { get; set; }

        [ApiMember(Name = "Comment", Description = "Comment", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Comment { get; set; }
    }
}