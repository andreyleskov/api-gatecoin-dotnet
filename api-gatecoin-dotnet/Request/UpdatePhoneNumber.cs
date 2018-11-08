using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Phone", "PUT", Summary = @"Update user phone number", Notes = @"")]
    public class UpdatePhoneNumber : IReturn<CommonResponse>
    {
        [ApiMember(Name = "HomePhone", Description = "Home phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string HomePhone { get; set; }

        [ApiMember(Name = "BusinessPhone", Description = "Business Phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string BusinessPhone { get; set; }

        [ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string MobilePhone { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirm to change phone number",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}