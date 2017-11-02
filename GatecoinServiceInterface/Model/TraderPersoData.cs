using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderPersoData 
{
public System.String Citiznship {get; set; } 
public System.Int32 IDType {get; set; } 
public System.String IDTypeDesc {get; set; } 
public System.String IDNumber {get; set; } 
public System.DateTime? Birthday {get; set; } 
public System.String BirthPlace {get; set; } 
public System.String Gender {get; set; } 
public System.Int32 CurrentStatus {get; set; } 
public System.String CurrentStatusDesc {get; set; } 
public System.Int32 SourceOfIncome {get; set; } 
public System.String SourceOfIncomeDesc {get; set; } 
public System.Int32 NatureOfBusiness {get; set; } 
public System.String NatureOfBusinessDesc {get; set; } 
public System.String Employer {get; set; } 
public System.Int32 TotalAnnualIncome {get; set; } 
public System.String TotalAnnualIncomeDesc {get; set; } 
public System.Int32 LiquidNetWorth {get; set; } 
public System.String LiquidNetWorthDesc {get; set; } 
public System.Int32 TotalNetWorth {get; set; } 
public System.String TotalNetWorthDesc {get; set; } 
}
}