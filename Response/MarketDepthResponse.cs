using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class MarketDepthResponse : CommonResponse
{
public System.String Currency {get; set; } 
public List<Limit> Asks {get; set; } 
public List<Limit> Bids {get; set; } 
}
}

