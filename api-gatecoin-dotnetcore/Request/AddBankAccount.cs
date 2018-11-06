using GatecoinServiceInterface.Response;
using ServiceStack;

namespace GatecoinServiceInterface.Request
{
    [Route("/Bank/UserAccounts", "POST", Summary = @"Add an account the logged in user",
        Notes = @"The account needs to be approved before transfer is possible.")]
    [Route("/Bank/Account", "POST", Summary = @"Add bank account",
        Notes = @"The account needs to be approved before transfer is possible.")]
    public class AddBankAccount : IReturn<CommonResponse>
    {
        [ApiMember(Name = "AccountNumber", Description = "Bank account number (IBAN where available)",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string AccountNumber { get; set; }

        [ApiMember(Name = "BankAddressCity", Description = "Bank address city", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string BankAddressCity { get; set; }

        [ApiMember(Name = "BankAddressCountryCode", Description = "Bank Address Country Code", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string BankAddressCountryCode { get; set; }

        [ApiMember(Name = "BankAddressPostalCode", Description = "Bank address Postal Code", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string BankAddressPostalCode { get; set; }

        [ApiMember(Name = "BankAddressStreet", Description = "Bank address street", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string BankAddressStreet { get; set; }

        [ApiMember(Name = "BankName", Description = "Bank name", ParameterType = "query", DataType = "string",
            IsRequired = true)]
        public string BankName { get; set; }

        [ApiMember(Name = "CorrespondentBank", Description = "Correspondent Bank", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string CorrespondentBank { get; set; }

        [ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string Currency { get; set; }

        [ApiMember(Name = "HolderFirstName",
            Description = "The name of the bank account holder. This should be the same as the logged in trader",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string HolderFirstName { get; set; }

        [ApiMember(Name = "HolderLastName", Description = "Holder Last Name", ParameterType = "query",
            DataType = "string", IsRequired = true)]
        public string HolderLastName { get; set; }

        [ApiMember(Name = "Label", Description = "Bank account label (for use on Gatecoin website only)",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Label { get; set; }

        [ApiMember(Name = "Password", Description = "Require password confirm to add bank account",
            ParameterType = "query", DataType = "string", IsRequired = true)]
        public string Password { get; set; }

        [ApiMember(Name = "SwiftCode", Description = "SWIFT  or BIC code", ParameterType = "query", DataType = "string",
            IsRequired = false)]
        public string SwiftCode { get; set; }

        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query",
            DataType = "string", IsRequired = false)]
        public string ValidationCode { get; set; }
    }
}