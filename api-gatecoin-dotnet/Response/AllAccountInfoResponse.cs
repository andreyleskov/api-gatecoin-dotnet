using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class AllAccountInfoResponse : CommonResponse
    {
        public AccountAll Info { get; set; }
    }
}