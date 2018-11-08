using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/Transactions/{RequestID}", "DELETE",
        Summary = @"Delete pending account withdraw of the logged in user", Notes = @"")]
    public class DeletePendingBankAccountWithdraw : IReturn<CommonResponse>
    {
        [ApiMember(Name = "RequestID", Description = "Request ID", ParameterType = "path", DataType = "long",
            IsRequired = false)]
        public long RequestID { get; set; }
    }
}