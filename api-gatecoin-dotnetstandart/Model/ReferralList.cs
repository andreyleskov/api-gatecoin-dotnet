using System;
using System.Collections.Generic;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class ReferralList
    {
        public List<TraderReferralDetail> TraderReferralList { get; set; }
    }
}