using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetIdentityDocumentTypeResponse : CommonResponse
    {
        public List<IdentityDocumentType> Types { get; set; }
    }
}