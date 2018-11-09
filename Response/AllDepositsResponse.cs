using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class AllDepositsResponse : CommonResponse
{
public List<BankTransfer> BankTransfers {get; set; } 
public List<DigitalCurrencyTransfer> DigiTransfers {get; set; } 
public List<InternalTransfer> InternalTransfers {get; set; } 
}
}

