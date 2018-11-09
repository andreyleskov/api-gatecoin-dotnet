using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class GetInternalPaymentResponse : CommonResponse
{
public System.String Requester {get; set; } 
public System.String Currency {get; set; } 
public System.Decimal Amount {get; set; } 
public System.String Comment {get; set; } 
}
}

