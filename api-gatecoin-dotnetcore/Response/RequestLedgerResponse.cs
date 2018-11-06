using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class RequestLedgerResponse : CommonResponse
    {
        public List<TraderLedgerOrder> LedgerOrders { get; set; }
    }
}