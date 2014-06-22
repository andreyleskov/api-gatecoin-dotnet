using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class PingResponse : CommonResponse
{
public System.String Message {get; set; } 
public System.DateTime ServerTime {get; set; } 
}
}

