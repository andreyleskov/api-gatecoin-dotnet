using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderAddress 
{
public System.String Line1 {get; set; } 
public System.String Line2 {get; set; } 
public System.String City {get; set; } 
public System.String State {get; set; } 
public System.String CountryCode {get; set; } 
public System.String CountryISO {get; set; } 
public System.String ZIP {get; set; } 
}
}

