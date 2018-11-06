using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class VerifDetailResponse : CommonResponse
    {
        public TraderSecurityOption Verif { get; set; }
    }
}