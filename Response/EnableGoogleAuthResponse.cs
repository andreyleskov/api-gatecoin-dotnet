using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class EnableGoogleAuthResponse : CommonResponse
{
public System.String SecretKey {get; set; } 
public System.String QRCode {get; set; } 
}
}

