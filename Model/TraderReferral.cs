using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderReferral 
{
public System.String ReferralCode {get; set; } 
public System.DateTime? verifDate {get; set; } 
public System.Decimal totalReferralVolume {get; set; } 
public System.DateTime lastUpdate {get; set; } 
public System.String FamilyName {get; set; } 
public System.String GivenName {get; set; } 
}
}

