using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class AccountBalance 
{
public System.String Currency {get; set; } 
public System.Decimal Balance {get; set; } 
public System.Decimal AvailableBalance {get; set; } 
public System.Decimal PendingIncoming {get; set; } 
public System.Decimal PendingOutgoing {get; set; } 
public System.Decimal OpenOrder {get; set; } 
public Boolean IsDigital {get; set; } 
}
}

