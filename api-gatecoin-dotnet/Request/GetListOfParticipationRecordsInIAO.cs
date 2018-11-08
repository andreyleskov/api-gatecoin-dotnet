using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/InitialAssetOffering/Pledges/{InitialAssetOfferingId}", "GET",
        Summary = @"Gets list of participation records in ico", Notes = @"")]
    public class GetIAO : IReturn<ParticipationsResponse>
    {
        [ApiMember(Name = "InitialAssetOfferingId", Description = "Id of ico", ParameterType = "path", DataType = "int",
            IsRequired = false)]
        public int IaoId { get; set; }
    }
}