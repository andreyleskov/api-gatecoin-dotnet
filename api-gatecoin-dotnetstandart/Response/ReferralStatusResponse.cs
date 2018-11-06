using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ReferralStatusResponse : CommonResponse
    {
        public TraderReferral ReferralStatus { get; set; }
    }
}