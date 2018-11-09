using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class Trades 
{
public System.Int64 Tid {get; set; } 
public System.Decimal Price {get; set; } 
public System.Decimal Amount {get; set; } 
public System.DateTime Date {get; set; } 
}
}


