using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class EmailResponse : CommonResponse
    {
        public TraderEmail Email { get; set; }
    }
}