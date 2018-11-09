using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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