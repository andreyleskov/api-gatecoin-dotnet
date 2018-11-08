using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class FiatDepositInfo
    {
        public long Id { get; set; }
        public string Currency { get; set; }
        public string AccountNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string BeneficiaryBankName { get; set; }
        public string BeneficiaryBankAddress { get; set; }
        public string BankCode { get; set; }
        public string IbanCode { get; set; }
        public string SwiftCode { get; set; }
        public decimal DepositFixedFee { get; set; }
        public decimal WithdrawalFee { get; set; }
        public string Prefix { get; set; }
        public decimal DepositPercentageFee { get; set; }
    }
}