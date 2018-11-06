using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Name", "PUT", Summary = @"Update user name", Notes = @"")]
    public class UpdateName : IReturn<CommonResponse>
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

        [ApiMember(Name = "Password", Description = "Require password confirm to change names", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}