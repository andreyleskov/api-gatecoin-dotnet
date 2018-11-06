using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class AllWithdrawalsResponse : CommonResponse
    {
        public List<BankTransfer> BankTransfers { get; set; }
        public List<DigitalCurrencyTransfer> DigiTransfers { get; set; }
        public List<InternalTransfer> InternalTransfers { get; set; }
    }
}