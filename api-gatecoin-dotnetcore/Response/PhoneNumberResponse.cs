using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class PhoneNumberResponse : CommonResponse
    {
        public TraderPhoneNumber PhoneNumber { get; set; }
    }
}