using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string BankAddressCity { get; set; }
        public string BankAddressCountryCode { get; set; }
        public string BankAddressStreet { get; set; }
        public string BankAddressPostalCode { get; set; }
        public string BankName { get; set; }
        public string CorrespondentBank { get; set; }
        public string Currency { get; set; }
        public string HolderFirstName { get; set; }
        public string HolderLastName { get; set; }
        public string Label { get; set; }
        public string SwiftCode { get; set; }
    }
}