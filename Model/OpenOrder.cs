using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class OpenOrder 
{
public System.String Code {get; set; } 
public System.String ClOrderId {get; set; } 
public System.String OrigClOrderId {get; set; }
public Byte Side {get; set; } 
public System.Decimal Price {get; set; } 
public System.Decimal InitialQuantity {get; set; } 
public System.Decimal RemainingQuantity {get; set; } 
public Byte Status {get; set; } 
public System.String StatusDesc {get; set; } 
public Int64 TranSeqNo {get; set; } 
public Byte Type {get; set; } 
public System.DateTime Date {get; set; } 
public List<TraderTransaction> Trades {get; set; }
}
}

