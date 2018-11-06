using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/UserAccounts", "PUT", Summary = @"Update the label of existing user bank accounnt", Notes = @"")]
    public class UpdateUserAccount : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Currency { get; set; }

        [ApiMember(Name = "Label", Description = "Existing Label", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Label { get; set; }

        [ApiMember(Name = "NewLabel", Description = "New Bank Label", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string NewLabel { get; set; }
    }
}