using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class AccountAll 
{
public System.String GivenName {get; set; } 
public System.String FamilyName {get; set; } 
public System.DateTime? Birthday {get; set; } 
public System.String Nationality {get; set; } 
public System.String HomePhone {get; set; } 
public System.String MobilePhone {get; set; } 
public System.String Line1 {get; set; } 
public System.String Line2 {get; set; } 
public System.String City {get; set; } 
public System.String ZIP {get; set; } 
public System.String State {get; set; } 
public System.String CountryCode {get; set; } 
public System.String IDDocumentNumber {get; set; } 
public System.String IDIssuingCountry {get; set; } 
public System.String IDDocumentExt {get; set; } 
public System.String IDMimeType {get; set; } 
public System.String IDContent {get; set; } 
public Byte[] IDContentByte {get; set; } 
public System.String ProofDocumentExt {get; set; } 
public System.String ProofMimeType {get; set; } 
public System.String ProofContent {get; set; } 
public Byte[] ProofContentByte {get; set; } 
public System.String SecurityQuestion {get; set; } 
public System.String SecurityAnswer {get; set; } 
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
public Boolean IsPhoneValidationEnabled {get; set; } 
}
}

