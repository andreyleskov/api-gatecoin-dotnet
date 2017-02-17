using System;
using ServiceStack.ServiceInterface.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TradeTransfer
{
public System.String Type { get; set; }
public System.String Subtype { get; set; }
public System.String Date { get; set; }
public System.String Currency { get; set; }
public System.String CurrencyPair { get; set; }
public System.Decimal Amount { get; set; }
public System.Decimal Price { get; set; }
public System.Decimal FeeRate { get; set; }
public System.String FeeRole { get; set; }
public System.Decimal CrossFeeRate { get; set; }
}
}