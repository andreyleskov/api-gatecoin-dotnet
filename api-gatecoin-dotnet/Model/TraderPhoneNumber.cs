using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderPhoneNumber
    {
        public string HomePhone { get; set; }
        public string BusinessPhone { get; set; }
        public string MobilePhone { get; set; }
    }
}