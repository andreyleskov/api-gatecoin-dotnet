using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InitialAssetOfferingParticipation
    {
        public long Id { get; set; }
        public long InitialAssetOfferingId { get; set; }
        public long TraderId { get; set; }
        public string Currency { get; set; }
        public string BaseCurrency { get; set; }
        public double AmountInBaseCurrency { get; set; }
        public string Status { get; set; }
        public DateTime PledgeDate { get; set; }
    }
}