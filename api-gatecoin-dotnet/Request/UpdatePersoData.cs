using System;
using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/PersonalData", "PUT", Summary = @"Update user personal data", Notes =
        @"IDType : /Reference/IdentydocumentTypes
<br>CurrentStatus : /Reference/CurrentStatusList
<br>SourceOfIncome : /Reference/IncomeSourceList
<br>NatureOfBusiness : /Reference/BusinessNatureList
<br>TotalAnnualIncome : /Reference/IncomeRangeList
<br>LiquidNetWorth : /Reference/IncomeRangeList
<br>TotalNetWorth : /Reference/IncomeRangeList")]
    public class UpdatePersoData : IReturn<PersoDataResponse>
    {
        [ApiMember(Name = "Citiznship", Description = "Citizenship", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Citiznship { get; set; }

        [ApiMember(Name = "IDType", Description = "ID type", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int IDType { get; set; }

        [ApiMember(Name = "IDNumber", Description = "ID number", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string IDNumber { get; set; }

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

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}