using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;


using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/UserAccounts", "POST", Summary = @"Add an account the logged in user", Notes = @"The account needs to be approved before transfer is possible.")]
[Route("/Bank/Account", "POST", Summary = @"Add bank account", Notes = @"The account needs to be approved before transfer is possible.")]
public class AddBankAccount : IReturn<CommonResponse>
    {
        [ApiMember(Name = "AccountNumber", Description = "Bank account number (IBAN where available)", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String AccountNumber {get; set; } 
        [ApiMember(Name = "BankAddressCity", Description = "Bank address city", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String BankAddressCity {get; set; } 
        [ApiMember(Name = "BankAddressCountryCode", Description = "Bank Address Country Code", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String BankAddressCountryCode {get; set; } 
        [ApiMember(Name = "BankAddressPostalCode", Description = "Bank address Postal Code", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String BankAddressPostalCode {get; set; } 
        [ApiMember(Name = "BankAddressStreet", Description = "Bank address street", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String BankAddressStreet {get; set; } 
        [ApiMember(Name = "BankName", Description = "Bank name", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String BankName {get; set; } 
        [ApiMember(Name = "CorrespondentBank", Description = "Correspondent Bank", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String CorrespondentBank {get; set; } 
        [ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String Currency {get; set; } 
        [ApiMember(Name = "HolderFirstName", Description = "The name of the bank account holder. This should be the same as the logged in trader", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String HolderFirstName {get; set; } 
        [ApiMember(Name = "HolderLastName", Description = "Holder Last Name", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String HolderLastName {get; set; } 
        [ApiMember(Name = "Label", Description = "Bank account label (for use on Gatecoin website only)", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String Label {get; set; } 
        [ApiMember(Name = "Password", Description = "Require password confirm to add bank account", ParameterType = "query", DataType = "string", IsRequired = true)]
        public System.String Password {get; set; } 
        [ApiMember(Name = "SwiftCode", Description = "SWIFT  or BIC code", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String SwiftCode {get; set; } 
        [ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
        public System.String ValidationCode {get; set; } 
    }
}

