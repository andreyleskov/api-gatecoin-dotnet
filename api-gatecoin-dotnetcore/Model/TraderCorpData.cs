using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderCorpData
    {
        public string CompanyName { get; set; }
        public string RegistrationTaxNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Nationality { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorFamilyName { get; set; }
        public string CompanyPhoneNumber { get; set; }
    }
}