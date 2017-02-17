using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class IdentityDocumentType : CommonResponse
{
public Int64 Id {get; set; } 
public System.String Name {get; set; } 
public Boolean Enabled {get; set; } 
}
}

