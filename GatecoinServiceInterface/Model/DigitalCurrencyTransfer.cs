using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class DigitalCurrencyTransfer 
{
public System.Decimal Amount {get; set; } 
public System.DateTime Date {get; set; } 
public System.String Currency {get; set; } 
public System.String TxID {get; set; } 
public System.String Status {get; set; } 
public System.String AddressName {get; set; } 
public System.String Address {get; set; } 
public System.String Comment {get; set; } 
public System.Boolean IsExternal {get; set; } 
public System.Int32 Confirms {get; set; }
public System.String ExtraInfo {get; set; } 
}
}
