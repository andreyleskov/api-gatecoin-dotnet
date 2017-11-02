using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class Transaction
{
public System.Int64 TransactionId { get; set; }
public System.DateTime TransactionTime { get; set; }
public System.Decimal Price { get; set; }
public System.Decimal Quantity { get; set; }
public System.String CurrencyPair { get; set; }
public System.String Way { get; set; }
public System.String AskOrderId { get; set; }
public System.String BidOrderId { get; set; }
}
}