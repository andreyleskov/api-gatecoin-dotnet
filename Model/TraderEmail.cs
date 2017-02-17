using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderEmail 
{
public System.String PrimaryEmail {get; set; } 
public Boolean PrimaryEmailVerified {get; set; } 
public System.String SecondaryEmail {get; set; } 
public Boolean SecondaryEmailVerified {get; set; } 
}
}

