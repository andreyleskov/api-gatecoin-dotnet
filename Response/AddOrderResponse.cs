using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class AddOrderResponse : CommonResponse
{
public System.String ClOrderId {get; set; } 
public System.String OrderStatus {get; set; } 
}
}

