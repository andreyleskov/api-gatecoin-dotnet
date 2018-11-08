using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class UserTransactionsResponse : CommonResponse
    {
        public List<TraderTransaction> Transactions { get; set; }
    }
}