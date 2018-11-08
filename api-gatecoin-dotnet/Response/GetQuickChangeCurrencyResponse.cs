using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetQuickChangeCurrencyResponse : CommonResponse
    {
        public List<ExchangeRate> CurrenciesRate { get; set; }
    }
}