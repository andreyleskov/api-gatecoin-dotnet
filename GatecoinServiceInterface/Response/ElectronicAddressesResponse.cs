using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class ElectronicAddressesResponse : CommonResponse
{
public List<TraderElectronicWallet> Addresses {get; set; } 
public List<WithdrawalLimit> WithdrawalLimits {get; set; } 
public List<TotalWithdrawn> TotalWithdrawns {get; set; } 
}
}

