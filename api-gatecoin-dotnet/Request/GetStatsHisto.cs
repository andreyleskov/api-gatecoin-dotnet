using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Public/StatisticHistory/{DigiCurrency}/{Typeofdata}", "GET",
        Summary = @"Get the historical data of a specific digital currency",
        Notes = @"If From or to is provded, count will be ignored.")]
    public class GetStatsHisto : IReturn<GetStatsHistoResponse>
    {
        [ApiMember(Name = "DigiCurrency", Description = "The digital currency", ParameterType = "path",
            DataType = "string", IsRequired = false)]
        public string DigiCurrency { get; set; }

        [ApiMember(Name = "Typeofdata", Description = "The type of data", ParameterType = "path", DataType = "string",
            IsRequired = false)]
        public string Typeofdata { get; set; }

        [ApiMember(Name = "Count", Description = "Number of records", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int? Count { get; set; }

        [ApiMember(Name = "From", Description = "From time in unix timestamp", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public long? From { get; set; }

        [ApiMember(Name = "To", Description = "To time in unix timestamp", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public long? To { get; set; }
    }
}