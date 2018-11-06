using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ReferenceListResponse : CommonResponse
    {
        public List<ReferenceItem> Items { get; set; }
    }
}