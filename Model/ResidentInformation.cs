using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class ResidentInformation 
{
public System.String HomePhone {get; set; } 
public System.String MobilePhone {get; set; } 
public System.String Line1 {get; set; } 
public System.String Line2 {get; set; } 
public System.String City {get; set; } 
public System.String State {get; set; } 
public System.String ZIP {get; set; } 
public System.String CountryCode {get; set; } 
}
}

