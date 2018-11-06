using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InitialAssetOfferingInformation
    {
        public string BaseCurrency { get; set; }
        public string Currency { get; set; }
        public double CurrentPledgedAmount { get; set; }
        public DateTime EndDate { get; set; }
        public long Id { get; set; }
        public double IndividualMaximumOfferingAmountInBaseCurrency { get; set; }
        public double IndividualMinimumOfferingAmountInBaseCurrency { get; set; }
        public bool PledgingEnabled { get; set; }
        public double PriceInBaseCurrency { get; set; }
        public DateTime PledgeDate { get; set; }
        public string RestrictedCountryCodes { get; set; }
        public DateTime StartDate { get; set; }
        public double TotalOfferingAmountInBaseCurrency { get; set; }
    }

    [Serializable]
    public class InitialAssetOfferingInformationPreview : InitialAssetOfferingInformation
    {
        public string Description { get; set; }
        public string WebsiteLink { get; set; }
        public string WhitepaperLink { get; set; }
        public string Blockchain { get; set; }
        public decimal PublicPriceInBaseCurrency { get; set; }
        public string Name { get; set; }
        public string TwitterLink { get; set; }
        public string VideoLink { get; set; }
        public string Hardcap { get; set; }
        public decimal PercentageTokenSale { get; set; }
    }
}