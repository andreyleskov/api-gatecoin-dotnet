using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class NameResponse : CommonResponse
    {
        public TraderName Name { get; set; }
    }
}