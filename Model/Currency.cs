using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class Currency 
{
public System.String Code {get; set; } 
public System.String DisplayName {get; set; } 
public System.String Symbol {get; set; } 
public Boolean IsDigital {get; set; } 
public Int32 DisplayDecimalPlace {get; set; } 
}
}

