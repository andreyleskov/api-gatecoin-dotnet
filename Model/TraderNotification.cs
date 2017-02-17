using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatecoinServiceInterface.Model
{
public class TraderNotification
{
public System.Int64 ID { get; set; }
public System.Int64 trader_id { get; set; }
public System.String messageCode { get; set; }
public System.Boolean read { get; set; }
public System.DateTime createDate { get; set; }
public System.DateTime updateDate { get; set; }
}
}
