using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class GetOkPayWalletsResponse : CommonResponse
{
public List<WithdrawalLimit> WithdrawalLimits {get; set; } 
public List<TotalWithdrawn> TotalWithdrawns {get; set; } 
public List<OkPayWallet> Wallets {get; set; } 
}
}

