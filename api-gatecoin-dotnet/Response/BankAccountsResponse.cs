using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class BankAccountsResponse : CommonResponse
    {
        public List<WithdrawalLimit> WithdrawalLimits { get; set; }
        public List<TotalWithdrawn> TotalWithdrawns { get; set; }
        public List<BankAccount> Accounts { get; set; }
    }
}