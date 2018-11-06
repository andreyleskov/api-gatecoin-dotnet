using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Address", "PUT", Summary = @"Update user address", Notes = @"")]
    public class UpdateAddress : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Line1 { get; set; }

        [ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Line2 { get; set; }

        [ApiMember(Name = "City", Description = "City", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string City { get; set; }

        [ApiMember(Name = "State", Description = "State/Province", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string State { get; set; }

        [ApiMember(Name = "CountryCode", Description = "Country of residence", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string CountryCode { get; set; }

        [ApiMember(Name = "ZIP", Description = "Zip/Postal Code", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string ZIP { get; set; }
    }
}