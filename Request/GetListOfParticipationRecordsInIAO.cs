using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request
{
    [Route("/InitialAssetOffering/Pledges/{InitialAssetOfferingId}", "GET", Summary = @"Gets list of participation records in ico", Notes = @"")]
    public class GetIAO : IReturn<ParticipationsResponse>
    {
        [ApiMember(Name = "InitialAssetOfferingId", Description = "Id of ico", ParameterType = "path", DataType = "int", IsRequired = false)]
        public System.Int32 IaoId { get; set; }
    }
}