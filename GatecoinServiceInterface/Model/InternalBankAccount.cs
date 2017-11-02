using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class InternalBankAccount 
{
public System.String BankName {get; set; } 
public System.String BankAddress1 {get; set; } 
public System.String BankAddress2 {get; set; } 
public System.String BankAddress3 {get; set; } 
public System.String RecipientAddress1 {get; set; } 
public System.String RecipientAddress2 {get; set; } 
public System.String RecipientAddress3 {get; set; } 
public System.String BankOfBeneficiary {get; set; } 
public System.String BankCode {get; set; } 
public System.String AccountNumber {get; set; } 
public System.String BranchCode {get; set; } 
public System.String IBANCode {get; set; } 
public System.String SwiftCode {get; set; } 
public System.String RecipientName {get; set; } 
public System.String RecipientAddress {get; set; } 
public System.String Reference {get; set; } 
public System.String CorrespondentBank {get; set; } 
public System.String CorrespondentBankSwiftCode {get; set; } 
public System.String IntermediaryBank {get; set; } 
public System.String IntermediaryBankSwiftCode {get; set; } 
}
}

