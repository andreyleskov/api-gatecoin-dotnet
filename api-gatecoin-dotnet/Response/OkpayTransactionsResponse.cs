using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class OkpayTransactionsResponse : CommonResponse
    {
        public List<OkpayTransaction> Transactions { get; set; }
    }
}