using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class OkPayWallet
    {
        public string WalletId { get; set; }
        public string Label { get; set; }
    }
}