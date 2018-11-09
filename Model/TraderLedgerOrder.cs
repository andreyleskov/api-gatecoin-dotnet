using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderLedgerOrder 
{
public System.Int64 ID { get; set; }
public System.String orderID { get; set; }
public System.Decimal shippingFee { get; set; }
public System.String shippingMethod { get; set; }
public System.String addressLine1 { get; set; }
public System.String addressLine2 { get; set; }
public System.String familyName { get; set; }
public System.String zip { get; set; }
public System.String country { get; set; }
public System.String city { get; set; }
public System.String currency { get; set; }
public System.DateTime requestDate { get; set; }
public System.DateTime shipDate { get; set; }
public List<TraderLedger> ledgers { get; set; }
}
}