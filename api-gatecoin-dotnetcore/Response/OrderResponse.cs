using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class OrderResponse : CommonResponse
    {
        public OpenOrder Order { get; set; }
    }
}