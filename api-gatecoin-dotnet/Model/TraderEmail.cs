using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderEmail
    {
        public string PrimaryEmail { get; set; }
        public bool PrimaryEmailVerified { get; set; }
        public string SecondaryEmail { get; set; }
        public bool SecondaryEmailVerified { get; set; }
    }
}