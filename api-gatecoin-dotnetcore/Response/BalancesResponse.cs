using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class BalancesResponse : CommonResponse
    {
        public List<AccountBalance> Balances { get; set; }
    }
}