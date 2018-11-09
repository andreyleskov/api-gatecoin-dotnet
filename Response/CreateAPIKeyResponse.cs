using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class CreateAPIKeyResponse : CommonResponse
{
public System.String PublicKey {get; set; } 
public System.String Key {get; set; } 
}
}

