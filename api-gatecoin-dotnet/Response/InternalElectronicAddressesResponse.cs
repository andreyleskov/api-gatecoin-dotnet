using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class InternalElectronicAddressesResponse : CommonResponse
    {
        public List<InternalTraderElectronicWallet> Addresses { get; set; }
        public List<WithdrawalLimit> WithdrawalLimits { get; set; }
        public List<TotalWithdrawn> TotalWithdrawns { get; set; }
    }
}