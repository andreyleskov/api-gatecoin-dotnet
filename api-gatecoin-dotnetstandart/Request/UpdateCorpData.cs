using System;
using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/CorporateData", "PUT", Summary = @"Update user company data for corporate account", Notes = @"")]
    public class UpdateCorpData : IReturn<CommonResponse>
    {
        [ApiMember(Name = "CompanyName", Description = "Company name", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string CompanyName { get; set; }

        [ApiMember(Name = "RegistrationTaxNumber", Description = "Registration / Tax Number", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string RegistrationTaxNumber { get; set; }

        [ApiMember(Name = "RegistrationDate", Description = "Company registration date", ParameterType = "query",
            DataType = "datetime", IsRequired = false)]
        public DateTime RegistrationDate { get; set; }

        [ApiMember(Name = "Nationality", Description = "Nationality", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Nationality { get; set; }

        [ApiMember(Name = "DirectorFirstName", Description = "Director first name", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string DirectorFirstName { get; set; }

        [ApiMember(Name = "DirectorFamilyName", Description = "Director family name", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string DirectorFamilyName { get; set; }

        [ApiMember(Name = "CompanyPhoneNumber", Description = "Company phone number", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string CompanyPhoneNumber { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}