using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class BankAccountTransfersResponse : CommonResponse
    {
        public List<BankTransfer> Transfers { get; set; }
    }
}