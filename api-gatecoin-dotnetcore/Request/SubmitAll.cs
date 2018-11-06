using System;
using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Account/User", "POST", Summary = @"Submit all account info", Notes = @"")]
    public class SubmitAll : IReturn<CommonResponse>
    {
        [ApiMember(Name = "ReferralCode", Description = "The referral code of user who recommend you to use gatecoin",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string ReferralCode { get; set; }

        [ApiMember(Name = "GivenName", Description = "Given name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string GivenName { get; set; }

        [ApiMember(Name = "FamilyName", Description = "Family Name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string FamilyName { get; set; }

        [ApiMember(Name = "Birthday", Description = "Birthday", ParameterType = "query", DataType = "datetime",
            IsRequired = true)]
        public DateTime? Birthday { get; set; }

        [ApiMember(Name = "Nationality", Description = "Nationality", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Nationality { get; set; }

        [ApiMember(Name = "HomePhone", Description = "Home Phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string HomePhone { get; set; }

        [ApiMember(Name = "MobilePhone", Description = "Mobile Phone", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string MobilePhone { get; set; }

        [ApiMember(Name = "Line1", Description = "Address line 1", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string Line1 { get; set; }

        [ApiMember(Name = "Line2", Description = "Address line 2", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string Line2 { get; set; }

        [ApiMember(Name = "City", Description = "City", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string City { get; set; }

        [ApiMember(Name = "State", Description = "State/Province", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string State { get; set; }

        [ApiMember(Name = "ZIP", Description = "ZIP", ParameterType = "query", DataType = "string", IsRequired = true)]
        public string ZIP { get; set; }

        [ApiMember(Name = "CountryCode", Description = "Country of residence", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string CountryCode { get; set; }

        [ApiMember(Name = "IDDocumentNumber", Description = "IDDocumentNumber", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string IDDocumentNumber { get; set; }

        [ApiMember(Name = "IDIssuingCountry", Description = "IDIssuingCountry", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string IDIssuingCountry { get; set; }

        [ApiMember(Name = "IDMimeType", Description = "The mime type of the id document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string IDMimeType { get; set; }

        [ApiMember(Name = "IDContent", Description = "File content in base64 of id document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string IDContent { get; set; }

        [ApiMember(Name = "ProofMimeType", Description = "The mime type of the proof document", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ProofMimeType { get; set; }

        [ApiMember(Name = "ProofContent", Description = "File content in base64 of proof document",
            ParameterType = "query", DataType = "string", IsRequired = false)]
        public string ProofContent { get; set; }

        [ApiMember(Name = "SecurityQuestion", Description = "SecurityQuestion", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string SecurityQuestion { get; set; }

        [ApiMember(Name = "SecurityAnswer", Description = "SecurityAnswer", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string SecurityAnswer { get; set; }

        [ApiMember(Name = "LoginWarning", Description = "Receive email warning for login", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool LoginWarning { get; set; }

        [ApiMember(Name = "LoginValidation",
            Description = "Require validation for login (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int LoginValidation { get; set; }

        [ApiMember(Name = "TradeWarning", Description = "Receive email warning for trade", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool TradeWarning { get; set; }

        [ApiMember(Name = "TradeValidation",
            Description = "Require validation for trade (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int TradeValidation { get; set; }

        [ApiMember(Name = "WithdrawWarning", Description = "WithdrawWarning", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool WithdrawWarning { get; set; }

        [ApiMember(Name = "WithdrawValidation",
            Description = "Require validation for withdraw (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int WithdrawValidation { get; set; }

        [ApiMember(Name = "AddAccountWarning", Description = "AddAccountWarning", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool AddAccountWarning { get; set; }

        [ApiMember(Name = "AddAccountValidation",
            Description =
                "Require validation for adding bank account and external electronic address (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int AddAccountValidation { get; set; }

        [ApiMember(Name = "ChangeDetailsWarning", Description = "ChangeDetailsWarning", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool ChangeDetailsWarning { get; set; }

        [ApiMember(Name = "ChangeDetailsValidation",
            Description = "Require validation for changing details (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ChangeDetailsValidation { get; set; }

        [ApiMember(Name = "ChangePasswordValidation",
            Description = "Require validation for changing password (none = 0, 1 = email, 2 = google auth, 3 = sms)",
            ParameterType = "query", DataType = "int", IsRequired = true)]
        public int ChangePasswordValidation { get; set; }

        [ApiMember(Name = "IsGoogleAuthEnabled", Description = "Enabled Google Auth", ParameterType = "query",
            DataType = "bool", IsRequired = true)]
        public bool IsGoogleAuthEnabled { get; set; }
    }
}