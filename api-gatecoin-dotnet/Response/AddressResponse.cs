using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class AddressResponse : CommonResponse
    {
        public TraderAddress Address { get; set; }
    }
}