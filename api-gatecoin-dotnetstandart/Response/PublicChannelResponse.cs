using System.Collections.Generic;

namespace GatecoinServiceInterface.Response
{
    public class PublicChannelResponse : CommonResponse
    {
        public Dictionary<string, string> Data { get; set; }
    }
}