using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ExchangeRateResponse : CommonResponse
    {
        public List<ExchangeRate> Rates { get; set; }
    }
}