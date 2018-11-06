using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderReferralDetail
    {
        public string Name { get; set; }
        public decimal VolumeTraded { get; set; }
    }
}