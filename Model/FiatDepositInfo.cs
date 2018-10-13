using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class FiatDepositInfo
    {
        public System.Int64 Id { get; set; }
        public System.String Currency { get; set; }
        public System.String AccountNumber { get; set; }
        public System.String BeneficiaryName { get; set; }
        public System.String BeneficiaryAddress { get; set; }
        public System.String BeneficiaryBankName { get; set; }
        public System.String BeneficiaryBankAddress { get; set; }
        public System.String BankCode { get; set; }
        public System.String IbanCode { get; set; }
        public System.String SwiftCode { get; set; }
        public System.Decimal DepositFixedFee { get; set; }
        public System.Decimal WithdrawalFee { get; set; }
        public System.String Prefix { get; set; }
        public System.Decimal DepositPercentageFee { get; set; }
    }
}