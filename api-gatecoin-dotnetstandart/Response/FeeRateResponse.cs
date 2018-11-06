using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class FeeRateResponse : CommonResponse
    {
        public List<FeeRate> FeeRates { get; set; }
    }
}