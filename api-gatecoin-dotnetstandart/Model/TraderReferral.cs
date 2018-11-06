using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderReferral
    {
        public string ReferralCode { get; set; }
        public DateTime? verifDate { get; set; }
        public decimal totalReferralVolume { get; set; }
        public DateTime lastUpdate { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
    }
}