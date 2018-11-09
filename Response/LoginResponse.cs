using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class LoginResponse : CommonResponse
{
public Boolean IsSuccess {get; set; } 
public System.String ApiKey {get; set; } 
public System.String PublicKey {get; set; } 
public System.String Alias {get; set; } 
public System.String DefaultCurrency {get; set; } 
public System.String DefaultLanguage {get; set; } 
public Int32 VerifLevel {get; set; } 
public Boolean UserHasUnreadTickets {get; set; } 
public System.DateTime LastLogonTime {get; set; } 
public Boolean IsPendingUnlockSecret {get; set; } 
}
}

