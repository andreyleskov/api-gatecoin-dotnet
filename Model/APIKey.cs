using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class APIKey 
{
public System.Int64 TraderId {get; set; } 
public System.DateTime Created {get; set; } 
public System.DateTime Expire {get; set; } 
public System.DateTime HardExpire {get; set; } 
public Int32 Status {get; set; } 
public Int32 Type {get; set; } 
public System.String Key {get; set; } 
public System.String PublicKey {get; set; } 
public Boolean HasIpRestrictions {get; set; } 
public Boolean AllowPrivateData {get; set; } 
public Boolean AllowTrade {get; set; } 
public Boolean AllowWithDrawal {get; set; } 
public List<System.String> AllowedIpNumbers {get; set; } 
public List<System.String> ForbiddenIpNumbers {get; set; } 
public System.String DataKey {get; set; } 
public Byte[] EncryptedDataKey {get; set; }
public System.String HashKey {get; set; } 
public System.String Purpose {get; set; } 
public Int32 ThrottlePolicyLevel {get; set; }
public System.Boolean AllowMerchantPaymentOnly { get; set; }
}
}

