using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class ElectronicWalletTransactionsResponse : CommonResponse
{
public List<DigitalCurrencyTransfer> Transfers {get; set; } 
}
}

