using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderLedger
{
public System.String model { get; set; }
public System.Int32 amount { get; set; }
public System.Decimal price { get; set; }
public System.String currency { get; set; }
}
}