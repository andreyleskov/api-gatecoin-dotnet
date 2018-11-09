using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderPhoneNumber 
{
public System.String HomePhone {get; set; } 
public System.String BusinessPhone {get; set; } 
public System.String MobilePhone {get; set; } 
}
}

