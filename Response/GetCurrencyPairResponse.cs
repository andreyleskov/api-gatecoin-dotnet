using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class GetCurrencyPairResponse : CommonResponse
{
public List<CurrencyPair> CurrencyPairs {get; set; } 
}
}
