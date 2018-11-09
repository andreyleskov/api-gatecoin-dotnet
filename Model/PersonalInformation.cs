using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class PersonalInformation 
{
public System.String GivenName {get; set; } 
public System.String FamilyName {get; set; } 
public System.DateTime? Birthday {get; set; } 
public System.String Nationality {get; set; } 
}
}

