using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class UserQuickOrder
{
public System.String CurrencyFrom { get; set; }
public System.String CurrencyTo { get; set; }
public System.Decimal Amount { get; set; }
public System.Decimal Price { get; set; }
public System.Decimal TransactionTime { get; set; }
}
}

