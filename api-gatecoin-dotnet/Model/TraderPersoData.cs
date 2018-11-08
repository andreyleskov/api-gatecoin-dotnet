using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderPersoData
    {
        public string Citiznship { get; set; }
        public int IDType { get; set; }
        public string IDTypeDesc { get; set; }
        public string IDNumber { get; set; }
        public DateTime? Birthday { get; set; }
        public string BirthPlace { get; set; }
        public string Gender { get; set; }
        public int CurrentStatus { get; set; }
        public string CurrentStatusDesc { get; set; }
        public int SourceOfIncome { get; set; }
        public string SourceOfIncomeDesc { get; set; }
        public int NatureOfBusiness { get; set; }
        public string NatureOfBusinessDesc { get; set; }
        public string Employer { get; set; }
        public int TotalAnnualIncome { get; set; }
        public string TotalAnnualIncomeDesc { get; set; }
        public int LiquidNetWorth { get; set; }
        public string LiquidNetWorthDesc { get; set; }
        public int TotalNetWorth { get; set; }
        public string TotalNetWorthDesc { get; set; }
    }
}