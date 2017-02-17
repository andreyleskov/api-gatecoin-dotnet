using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderTransaction
{
public System.Int64 TransactionId { get; set; }
public System.DateTime TransactionTime { get; set; }
public System.String AskOrderID { get; set; }
public System.String BidOrderID { get; set; }
public System.Decimal Price { get; set; }
public System.Decimal Quantity { get; set; }
public System.String CurrencyPair { get; set; }
public System.String Way { get; set; }
public System.String FeeRole { get; set; }
public System.Decimal FeeRate { get; set; }
public System.Decimal? CrossFeeRate { get; set; }
}
}

