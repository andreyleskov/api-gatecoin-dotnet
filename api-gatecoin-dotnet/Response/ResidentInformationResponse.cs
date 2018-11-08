using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ResidentInformationResponse : CommonResponse
    {
        public ResidentInformation residentInfo { get; set; }
    }
}