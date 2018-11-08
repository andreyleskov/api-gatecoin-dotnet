using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class OrdersResponse : CommonResponse
    {
        public List<OpenOrder> Orders { get; set; }
    }
}