using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class InternalTraderElectronicWallet 
{
public System.String AddressName {get; set; } 
public System.String Currency {get; set; } 
public System.String Address {get; set; } 
public System.DateTime CreateDateTime {get; set; } 
public System.String AutoReceiveCurrency {get; set; } 
public System.Decimal Received { get; set; }
public System.String WalletType { get; set; }
}
}

