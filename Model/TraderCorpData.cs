using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderCorpData 
{
public System.String CompanyName {get; set; } 
public System.String RegistrationTaxNumber {get; set; } 
public System.DateTime? RegistrationDate {get; set; } 
public System.String Nationality {get; set; } 
public System.String DirectorFirstName {get; set; } 
public System.String DirectorFamilyName {get; set; } 
public System.String CompanyPhoneNumber {get; set; } 
}
}

