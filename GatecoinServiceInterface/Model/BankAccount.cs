using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class BankAccount 
{
public System.String Label {get; set; } 
public System.String Currency {get; set; } 
public System.String BankName {get; set; } 
public System.String SwiftCode {get; set; } 
public System.String HolderAddress {get; set; } 
public System.String AccountNumber {get; set; } 
public System.String HolderName {get; set; } 
public System.String Country {get; set; } 
public System.String CorrespondentBank {get; set; } 
}
}

