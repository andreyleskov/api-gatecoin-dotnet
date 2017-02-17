using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class DynamicOrder
{
public System.Int64 ID { get; }
public System.String OrderType { get; }
public System.String OrderID { get; }
public System.String Status { get; }
public System.DateTime LastUpdateDate { get; }

public System.Decimal LastLevelUpper { get; set; }
public System.Decimal LastLevelLower { get; set; }
}
}
