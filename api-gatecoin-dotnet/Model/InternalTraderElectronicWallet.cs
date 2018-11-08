using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InternalTraderElectronicWallet
    {
        public string AddressName { get; set; }
        public string Currency { get; set; }
        public string Address { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string AutoReceiveCurrency { get; set; }
        public decimal Received { get; set; }
        public string WalletType { get; set; }
    }
}