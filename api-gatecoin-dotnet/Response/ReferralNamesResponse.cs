using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ReferralNamesResponse : CommonResponse
    {
        public ReferralList ReferralNames { get; set; }
    }
}