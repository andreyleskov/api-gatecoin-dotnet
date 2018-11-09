using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class ReferenceItem 
{
public Int32 ID {get; set; } 
public System.String Description {get; set; } 
}
}