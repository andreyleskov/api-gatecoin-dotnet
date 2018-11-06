using System;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class AccountAll
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Nationality { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public string IDDocumentNumber { get; set; }
        public string IDIssuingCountry { get; set; }
        public string IDDocumentExt { get; set; }
        public string IDMimeType { get; set; }
        public string IDContent { get; set; }
        public byte[] IDContentByte { get; set; }
        public string ProofDocumentExt { get; set; }
        public string ProofMimeType { get; set; }
        public string ProofContent { get; set; }
        public byte[] ProofContentByte { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public bool LoginWarning { get; set; }
        public int LoginValidation { get; set; }
        public bool TradeWarning { get; set; }
        public int TradeValidation { get; set; }
        public bool WithdrawWarning { get; set; }
        public int WithdrawValidation { get; set; }
        public bool AddAccountWarning { get; set; }
        public int AddAccountValidation { get; set; }
        public bool ChangeDetailsWarning { get; set; }
        public int ChangeDetailsValidation { get; set; }
        public int ChangePasswordValidation { get; set; }
        public bool IsGoogleAuthEnabled { get; set; }
        public bool IsPhoneValidationEnabled { get; set; }
    }
}