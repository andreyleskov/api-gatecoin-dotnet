using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetCurrenciesResponse : CommonResponse
    {
        public List<Currency> Currencies { get; set; }
    }
}