using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class MarketData 
{
public System.String CurrencyPair {get; set; } 
public System.Decimal Open {get; set; } 
public System.Decimal Last {get; set; } 
public System.Decimal High {get; set; } 
public System.Decimal Low {get; set; } 
public System.Decimal Volume {get; set; } 
public System.Decimal Vwap {get; set; } 
public System.DateTime CreateDateTime {get; set; } 
}
}
