using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Okpay/Wallet/{Label}", "DELETE", Summary = @"Deletes an existing wallet", Notes = @"")]
    public class DeleteOkPayWallet : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Label", Description = "Existing Wallet Label", ParameterType = "path", DataType = "string",
            IsRequired = true)]
        public string Label { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}