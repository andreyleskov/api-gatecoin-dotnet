using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetAPIKeyResponse : CommonResponse
    {
        public List<APIKey> Keys { get; set; }
    }
}