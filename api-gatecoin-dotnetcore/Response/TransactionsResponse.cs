using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class TransactionsResponse : CommonResponse
    {
        public List<Transaction> Transactions { get; set; }
    }
}