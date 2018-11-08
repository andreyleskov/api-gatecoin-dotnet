using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class DigitalCurrencyTransfer
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public string TxID { get; set; }
        public string Status { get; set; }
        public string AddressName { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public bool IsExternal { get; set; }
        public int Confirms { get; set; }
        public string ExtraInfo { get; set; }
    }
}