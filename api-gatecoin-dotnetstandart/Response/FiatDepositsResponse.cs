using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class FiatDepositsResponse : CommonResponse
    {
        public string DepositReferenceCode { get; set; }
        public List<FiatDepositInfo> Accounts { get; set; }
    }
}