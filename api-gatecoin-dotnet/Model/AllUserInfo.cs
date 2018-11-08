using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class AllUserInfo
    {
        public string UserId { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string Alias { get; set; }
        public string HomePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public string ZIP { get; set; }
        public string Citizenship { get; set; }
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
        public string Password { get; set; }
    }
}