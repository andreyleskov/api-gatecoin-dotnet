using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ProfileResponse : CommonResponse
    {
        public string UserID { get; set; }
        public string Alias { get; set; }
        public int Level { get; set; }
        public List<FeeRate> FeeRates { get; set; }
        public decimal TotalReferralVolume { get; set; }
        public string DefaultCurrency { get; set; }
        public string DefaultLanguage { get; set; }
    }
}