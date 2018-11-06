using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/Level", "POST", Summary = @"Request verif level of logged in user", Notes = @"")]
    public class RequestVerifLevel : IReturn<CommonResponse>
    {
        [ApiMember(Name = "Level", Description = "Verif Level", ParameterType = "query", DataType = "int",
            IsRequired = false)]
        public int Level { get; set; }
    }
}