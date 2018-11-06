using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetTicketsResponse : CommonResponse
    {
        public List<TraderTicket> Tickets { get; set; }
    }
}