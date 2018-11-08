using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ReferralRewardResponse : CommonResponse
    {
        public TraderReferralReward RewardStatus { get; set; }
    }
}