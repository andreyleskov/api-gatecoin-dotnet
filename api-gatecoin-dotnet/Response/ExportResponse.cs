using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ExportResponse : CommonResponse
    {
        public List<TradeTransfer> TradeTransfers { get; set; }
    }
}