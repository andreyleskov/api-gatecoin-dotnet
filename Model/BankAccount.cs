using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class BankAccount 
    {
        public System.String AccountNumber { get; set; }
        public System.String BankAddressCity {get; set; } 
        public System.String BankAddressCountryCode {get; set; } 
        public System.String BankAddressStreet { get; set; }
        public System.String BankAddressPostalCode { get; set; }
        public System.String BankName { get; set; }
        public System.String CorrespondentBank {get; set; } 
        public System.String Currency { get; set; }
        public System.String HolderFirstName { get; set; }
        public System.String HolderLastName {get; set; } 
        public System.String Label { get; set; }
        public System.String SwiftCode {get; set; } 

    }
}

