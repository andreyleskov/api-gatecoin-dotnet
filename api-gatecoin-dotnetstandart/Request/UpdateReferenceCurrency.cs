using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Info/ReferenceCurrency", "PUT", Summary = @"User's reference currency", Notes = @"")]
    public class UpdateReferenceCurrency : IReturn<CommonResponse>
    {
        [ApiMember(Name = "CurrencyPair", Description = "Currency pair", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string CurrencyPair { get; set; }
    }
}