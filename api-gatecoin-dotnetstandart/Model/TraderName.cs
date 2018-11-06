using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderName
    {
        public string FamilyName { get; set; }
        public string GivenName { get; set; }
        public string Alias { get; set; }
    }
}