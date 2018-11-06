using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ElectronicAddressesResponse : CommonResponse
    {
        public List<TraderElectronicWallet> Addresses { get; set; }
        public List<WithdrawalLimit> WithdrawalLimits { get; set; }
        public List<TotalWithdrawn> TotalWithdrawns { get; set; }
    }
}