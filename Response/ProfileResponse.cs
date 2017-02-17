using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class ProfileResponse : CommonResponse
{
public System.String UserID {get; set; } 
public System.String Alias {get; set; } 
public Int32 Level {get; set; } 
public List<FeeRate> FeeRates {get; set; } 
public System.Decimal TotalReferralVolume {get; set; } 
public System.String DefaultCurrency {get; set; } 
public System.String DefaultLanguage {get; set; } 
}
}

