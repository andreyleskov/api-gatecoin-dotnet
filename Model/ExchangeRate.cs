using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class ExchangeRate 
{
public System.String BuyingCurrency {get; set; } 
public System.String SellingCurrency {get; set; } 
public System.Decimal Rate {get; set; } 
public System.DateTime UpdateDate {get; set; } 
}
}

