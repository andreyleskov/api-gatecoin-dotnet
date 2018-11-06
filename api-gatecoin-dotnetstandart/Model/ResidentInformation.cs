using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class ResidentInformation
    {
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string CountryCode { get; set; }
    }
}