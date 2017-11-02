using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class OkpayTransaction
{
public System.String Currency { get; set; }
public System.Decimal Amount { get; set; }
public System.String Status { get; set; }
public System.String TxId { get; set; }
public System.String IpAddress { get; set; }
public System.DateTime Date { get; set; }
public System.DateTime TransferDate { get; set; }
public System.String WalletId { get; set; }
public System.String Label { get; set; }
}
}