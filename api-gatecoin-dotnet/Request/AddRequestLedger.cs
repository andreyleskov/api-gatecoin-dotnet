using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Ledger", "POST", Summary = @"Request to order ledger", Notes = @"")]
    public class AddRequestLedger : IReturn<CommonResponse>
    {
        [ApiMember(Name = "SingleAmount", Description = "The amount of single ledgers request", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int singleAmount { get; set; }

        [ApiMember(Name = "DuoAmount", Description = "The amount of duo ledgers request", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int duoAmount { get; set; }

        [ApiMember(Name = "ShippingFee", Description = "shipping fee", ParameterType = "query", DataType = "decimal",
            IsRequired = true)]
        public decimal shippingFee { get; set; }

        [ApiMember(Name = "FamilyName", Description = "FamilyName", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string FamilyName { get; set; }

        [ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string line1 { get; set; }

        [ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string line2 { get; set; }

        [ApiMember(Name = "City", Description = "City", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string City { get; set; }

        [ApiMember(Name = "Country", Description = "Country of residence", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Country { get; set; }

        [ApiMember(Name = "ZIP", Description = "Zip/Postal Code", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string ZIP { get; set; }
    }
}