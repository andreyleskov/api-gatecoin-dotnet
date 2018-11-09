using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class MerchantPayment 
{
public System.String TxID {get; set; } 
public System.Decimal Amount {get; set; } 
public System.Decimal AmountReceived {get; set; } 
public System.String Status {get; set; } 
public Int32 Confirmation {get; set; } 
public System.DateTime CreateDate {get; set; } 
public System.DateTime ExpiryDate {get; set; } 
public System.String Reference {get; set; } 
public System.String ExtraData {get; set; } 
}
}

