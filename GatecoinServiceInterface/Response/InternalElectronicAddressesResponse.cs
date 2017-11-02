using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class InternalElectronicAddressesResponse : CommonResponse
{
public List<InternalTraderElectronicWallet> Addresses {get; set; } 
public List<WithdrawalLimit> WithdrawalLimits {get; set; } 
public List<TotalWithdrawn> TotalWithdrawns {get; set; } 
}
}

