using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class GetNetworkStatsResponse : CommonResponse
{
public System.Decimal Blocks_Mined {get; set; } 
public System.Decimal Time_Between_Blocks {get; set; } 
public System.Decimal Bitcoins_Mined {get; set; } 
public System.Decimal Total_Transaction_Fees {get; set; } 
public Int32 No_of_Transactions {get; set; } 
public System.Decimal Total_Output_Volume {get; set; } 
public System.Decimal Difficulty {get; set; } 
public System.Decimal Hash_Rate {get; set; } 
}
}

