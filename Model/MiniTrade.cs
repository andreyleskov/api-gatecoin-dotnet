using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class MiniTrade : CommonResponse
{
public Int64 I {get; set; } 
public System.Decimal P {get; set; } 
public System.Decimal A {get; set; } 
public System.DateTime D {get; set; } 
}
}
