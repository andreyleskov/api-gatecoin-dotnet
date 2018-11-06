using System;
using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Export/Transactions", "POST",
        Summary = @"Request a export of all trades from based on currencypair, start date and end date", Notes = @"")]
    public class ExportTrades : IReturn<ExportResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "Transactions currency", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string CurrencyPair { get; set; }

        [ApiMember(Name = "Currency", Description = "Transactions currency", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string Currency { get; set; }

        [ApiMember(Name = "DateFrom", Description = "Start Date", ParameterType = "query", DataType = "datetime",
            IsRequired = true)]
        public DateTime DateFrom { get; set; }

        [ApiMember(Name = "DateTo", Description = "End Date", ParameterType = "query", DataType = "datetime",
            IsRequired = true)]
        public DateTime DateTo { get; set; }
    }
}