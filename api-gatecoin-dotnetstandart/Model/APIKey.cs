using System;
using System.Collections.Generic;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class APIKey
    {
        public long TraderId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expire { get; set; }
        public DateTime HardExpire { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public string Key { get; set; }
        public string PublicKey { get; set; }
        public bool HasIpRestrictions { get; set; }
        public bool AllowPrivateData { get; set; }
        public bool AllowTrade { get; set; }
        public bool AllowWithDrawal { get; set; }
        public List<string> AllowedIpNumbers { get; set; }
        public List<string> ForbiddenIpNumbers { get; set; }
        public string DataKey { get; set; }
        public byte[] EncryptedDataKey { get; set; }
        public string HashKey { get; set; }
        public string Purpose { get; set; }
        public int ThrottlePolicyLevel { get; set; }
        public bool AllowMerchantPaymentOnly { get; set; }
    }
}