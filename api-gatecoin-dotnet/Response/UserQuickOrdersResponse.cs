using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class UserQuickOrdersResponse : CommonResponse
    {
        public List<UserQuickOrder> QuickOrders { get; set; }
    }
}