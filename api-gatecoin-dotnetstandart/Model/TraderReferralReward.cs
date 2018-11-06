using System;
using System.Collections.Generic;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderReferralReward
    {
        public List<Reward> RewardsHistory { get; set; }
        public decimal CurrentReward { get; set; }
    }
}