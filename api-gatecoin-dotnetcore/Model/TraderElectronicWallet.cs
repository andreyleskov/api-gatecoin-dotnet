using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderElectronicWallet
    {
        public string AddressName { get; set; }
        public string Currency { get; set; }
        public string Address { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}