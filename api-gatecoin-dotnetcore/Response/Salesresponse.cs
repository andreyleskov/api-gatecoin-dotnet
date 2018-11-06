using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class SalesResponse : CommonResponse
    {
        public List<InitialAssetOfferingInformation> Sales { get; set; }
    }

    public class SalesResponsePreview : CommonResponse
    {
        public List<InitialAssetOfferingInformationPreview> Sales { get; set; }
    }
}