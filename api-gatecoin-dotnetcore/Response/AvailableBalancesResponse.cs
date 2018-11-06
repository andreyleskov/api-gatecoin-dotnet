using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class AvailableBalancesResponse : CommonResponse
    {
        public List<AccountBalance> Balances { get; set; }
    }
}