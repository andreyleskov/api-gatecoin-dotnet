using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class TransactionsHistoryResponse : CommonResponse
    {
        public List<MiniTrade> Transactions { get; set; }
    }
}