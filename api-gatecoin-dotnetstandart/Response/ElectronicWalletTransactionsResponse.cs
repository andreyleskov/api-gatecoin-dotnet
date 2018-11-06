using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ElectronicWalletTransactionsResponse : CommonResponse
    {
        public List<DigitalCurrencyTransfer> Transfers { get; set; }
    }
}