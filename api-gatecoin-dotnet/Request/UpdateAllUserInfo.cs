using System;
using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/User", "PUT", Summary = @"Update all user info", Notes = @"")]
    public class UpdateAllUserInfo : IReturn<CommonResponse>
    {
        [ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string FamilyName { get; set; }

        [ApiMember(Name = "GivenName", Description = "Given Name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string GivenName { get; set; }

        [ApiMember(Name = "Alias", Description = "Alias", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Alias { get; set; }

        [ApiMember(Name = "HomePhone", Description = "Home phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string HomePhone { get; set; }

        [ApiMember(Name = "BusinessPhone", Description = "Business Phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string BusinessPhone { get; set; }

        [ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string MobilePhone { get; set; }

        [ApiMember(Name = "Email", Description = "Email", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Email { get; set; }

        [ApiMember(Name = "Email2", Description = "2nd Email", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Email2 { get; set; }

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
            IsRequired = false)]
        public string State { get; set; }

        [ApiMember(Name = "CountryCode", Description = "Country of residence", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string CountryCode { get; set; }

        [ApiMember(Name = "ZIP", Description = "Zip/Postal Code", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string ZIP { get; set; }

        [ApiMember(Name = "Citiznship", Description = "Citizenship", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Citiznship { get; set; }

        [ApiMember(Name = "Birthday", Description = "Birthday", ParameterType = "query", DataType = "datetime",
            IsRequired = false)]
        public DateTime? Birthday { get; set; }

        [ApiMember(Name = "BirthPlace", Description = "Birth Place", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string BirthPlace { get; set; }

        [ApiMember(Name = "Gender", Description = "Gender (M/F)", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Gender { get; set; }

        [ApiMember(Name = "CurrentStatus", Description = "Current employment status", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int CurrentStatus { get; set; }

        [ApiMember(Name = "SourceOfIncome", Description = "Source of income", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int SourceOfIncome { get; set; }

        [ApiMember(Name = "NatureOfBusiness", Description = "Nature of business", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int NatureOfBusiness { get; set; }

        [ApiMember(Name = "Employer", Description = "Employer", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Employer { get; set; }

        [ApiMember(Name = "TotalAnnualIncome", Description = "Total annual income", ParameterType = "query",
            DataType = "int", IsRequired = false)]
        public int TotalAnnualIncome { get; set; }

        [ApiMember(Name = "LiquidNetWorth", Description = "Liquid net worth", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int LiquidNetWorth { get; set; }

        [ApiMember(Name = "TotalNetWorth", Description = "Total net worth", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int TotalNetWorth { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirm to change names", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}