using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public enum DocumentStatus 
{
NotPresent = 0,   
Present = 1,   
Validated = 2
}
}

