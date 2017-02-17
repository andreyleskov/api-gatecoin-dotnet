using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderSecurityOption 
{
public Boolean LoginWarning {get; set; } 
public Int32 LoginValidation {get; set; } 
public Boolean TradeWarning {get; set; } 
public Int32 TradeValidation {get; set; } 
public Boolean WithdrawWarning {get; set; } 
public Int32 WithdrawValidation {get; set; } 
public Boolean AddAccountWarning {get; set; } 
public Int32 AddAccountValidation {get; set; } 
public Boolean ChangeDetailsWarning {get; set; } 
public Int32 ChangeDetailsValidation {get; set; } 
public Int32 ChangePasswordValidation {get; set; } 
public Boolean IsGoogleAuthEnabled {get; set; } 
public Boolean IsSmsValidationEnabled {get; set; } 
}
}

