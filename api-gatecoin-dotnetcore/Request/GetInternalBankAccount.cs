using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Accounts/{Currency}/{Location}", "GET", Summary = @"Get internal bank account for deposit",
        Notes = @"")]
    public class GetInternalBankAccount : IReturn<InternalBankAccountResponse>
    {
        [ApiMember(Name = "Currency", Description = "Currency of bank account", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string Currency { get; set; }

        [ApiMember(Name = "Location", Description = "Location of bank account", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string Location { get; set; }
    }
}