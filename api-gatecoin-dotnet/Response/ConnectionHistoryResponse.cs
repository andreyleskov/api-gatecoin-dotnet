using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ConnectionHistoryResponse : CommonResponse
    {
        public List<ConnectionHistory> History { get; set; }
    }
}