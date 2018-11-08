using System;
using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/PersonalInformation", "PUT", Summary = @"Update Step1 Data", Notes = @"")]
    public class PutPersonalInformation : IReturn<CommonResponse>
    {
        [ApiMember(Name = "GivenName", Description = "Given name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string GivenName { get; set; }

        [ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string FamilyName { get; set; }

        [ApiMember(Name = "Birthday", Description = "Birthday", ParameterType = "query", DataType = "datetime",
            IsRequired = true)]
        public DateTime? Birthday { get; set; }

        [ApiMember(Name = "Nationality", Description = "Nationality", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Nationality { get; set; }
    }
}