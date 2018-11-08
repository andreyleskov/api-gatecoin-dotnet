using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Reference/QuickChangeCurrency", "Get", Summary = @"Get the available currency in quick change.",
        Notes = @"")]
    public class GetQuickChangeCurrency : IReturn<GetQuickChangeCurrencyResponse>
    {
    }
}