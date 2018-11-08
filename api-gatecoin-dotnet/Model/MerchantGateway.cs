using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class MerchantGateway
    {
        public string Label { get; set; }
        public int MinConfirmation { get; set; }
        public int ExpirySecond { get; set; }
        public string Webhook { get; set; }
        public string GatewayType { get; set; }
        public string Currency { get; set; }
    }
}