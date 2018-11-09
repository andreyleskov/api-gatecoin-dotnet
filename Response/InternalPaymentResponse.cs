using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class InternalPaymentResponse : CommonResponse
{
public System.String PaymentLink {get; set; } 
}
}

