using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class CorpDataResponse : CommonResponse
    {
        public TraderCorpData CorpData { get; set; }
    }
}