using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class FeeRate
{
public System.String CurrencyPair { get; set; }
public System.Decimal TakerFeeRate { get; set; }
public System.Decimal MakerFeeRate { get; set; }
}
}