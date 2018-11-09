using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class ConnectionHistory 
{
public System.DateTime Time {get; set; } 
public System.String IP {get; set; } 
public System.String Country {get; set; } 
public Boolean IsSuccess {get; set; } 
}
}

