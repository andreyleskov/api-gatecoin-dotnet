using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Merchant/PayInternalPayment", "Post", Summary = @"Pay the payment", Notes = @"")]
    public class PayInternalPayment : IReturn<CommonResponse>
    {
        [ApiMember(Name = "TxID", Description = "TxID", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string TxID { get; set; }

        [ApiMember(Name = "UserName", Description = "UserName", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string UserName { get; set; }

        [ApiMember(Name = "Password", Description = "Password", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Password { get; set; }
    }
}