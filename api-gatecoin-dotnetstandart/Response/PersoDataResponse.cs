using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class PersoDataResponse : CommonResponse
    {
        public TraderPersoData PersoData { get; set; }
    }
}