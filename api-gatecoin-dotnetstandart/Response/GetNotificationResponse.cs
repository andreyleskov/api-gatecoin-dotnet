using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetNotificationResponse : CommonResponse
    {
        public List<TraderNotification> Notifications { get; set; }
    }
}