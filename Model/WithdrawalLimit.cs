using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class WithdrawalLimit 
{
public System.String Currency {get; set; } 
public System.Decimal Limit {get; set; } 
public System.Decimal Minimum {get; set; } 
}
}

