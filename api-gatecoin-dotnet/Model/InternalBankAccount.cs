using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InternalBankAccount
    {
        public string BankName { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string BankAddress3 { get; set; }
        public string RecipientAddress1 { get; set; }
        public string RecipientAddress2 { get; set; }
        public string RecipientAddress3 { get; set; }
        public string BankOfBeneficiary { get; set; }
        public string BankCode { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string IBANCode { get; set; }
        public string SwiftCode { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAddress { get; set; }
        public string Reference { get; set; }
        public string CorrespondentBank { get; set; }
        public string CorrespondentBankSwiftCode { get; set; }
        public string IntermediaryBank { get; set; }
        public string IntermediaryBankSwiftCode { get; set; }
    }
}