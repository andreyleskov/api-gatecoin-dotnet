using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class AllUserInfo 
{
public System.String UserId {get; set; } 
public System.String FamilyName {get; set; } 
public System.String GivenName {get; set; } 
public System.String Alias {get; set; } 
public System.String HomePhone {get; set; } 
public System.String BusinessPhone {get; set; } 
public System.String MobilePhone {get; set; } 
public System.String Email {get; set; } 
public System.String Email2 {get; set; } 
public System.String Line1 {get; set; } 
public System.String Line2 {get; set; } 
public System.String City {get; set; } 
public System.String State {get; set; } 
public System.String CountryCode {get; set; } 
public System.String ZIP {get; set; } 
public System.String Citizenship {get; set; } 
public Int32 IDType {get; set; } 
public System.String IDTypeDesc {get; set; } 
public System.String IDNumber {get; set; } 
public System.DateTime? Birthday {get; set; } 
public System.String BirthPlace {get; set; } 
public System.String Gender {get; set; } 
public Int32 CurrentStatus {get; set; } 
public System.String CurrentStatusDesc {get; set; } 
public Int32 SourceOfIncome {get; set; } 
public System.String SourceOfIncomeDesc {get; set; } 
public Int32 NatureOfBusiness {get; set; } 
public System.String NatureOfBusinessDesc {get; set; } 
public System.String Employer {get; set; } 
public Int32 TotalAnnualIncome {get; set; } 
public System.String TotalAnnualIncomeDesc {get; set; } 
public Int32 LiquidNetWorth {get; set; } 
public System.String LiquidNetWorthDesc {get; set; } 
public Int32 TotalNetWorth {get; set; } 
public System.String TotalNetWorthDesc {get; set; } 
public System.String Password {get; set; } 
}
}

