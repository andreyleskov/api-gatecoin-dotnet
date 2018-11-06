using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class PersonalInformation
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Nationality { get; set; }
    }
}