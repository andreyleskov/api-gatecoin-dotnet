using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Bank/UserAccounts", "POST", Summary = @"Add an account the logged in user", Notes = @"The account needs to be approved before transfer is possible.")]
public class AddBankAccount : IReturn<CommonResponse>
{
[ApiMember(Name = "BankName", Description = "Bank name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String BankName {get; set; } 
[ApiMember(Name = "Label", Description = "Bank account label (for use on Gatecoin website only)", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Label {get; set; } 
[ApiMember(Name = "AccountNumber", Description = "Bank account number (IBAN where available)", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String AccountNumber {get; set; } 
[ApiMember(Name = "Currency", Description = "Currency of the bank account", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Currency {get; set; } 
[ApiMember(Name = "SwiftCode", Description = "SWIFT  or BIC code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String SwiftCode {get; set; } 
[ApiMember(Name = "HolderName", Description = "The name of the bank account holder. This should be the same as the logged in trader", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String HolderName {get; set; } 
[ApiMember(Name = "HolderAddress", Description = "Holder's Address", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String HolderAddress {get; set; } 
[ApiMember(Name = "CorrespondentBank", Description = "Correspondent Bank", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String CorrespondentBank {get; set; } 
[ApiMember(Name = "CountryCode", Description = "Bank country", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String CountryCode {get; set; } 
[ApiMember(Name = "Password", Description = "Require password confirm to add bank account", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String Password {get; set; } 
[ApiMember(Name = "ValidationCode", Description = "Validation code", ParameterType = "query", DataType = "string", IsRequired = false)]
public System.String ValidationCode {get; set; } 
}
}

