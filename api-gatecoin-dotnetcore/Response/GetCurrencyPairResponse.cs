using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetCurrencyPairResponse : CommonResponse
    {
        public List<CurrencyPair> CurrencyPairs { get; set; }
    }
}