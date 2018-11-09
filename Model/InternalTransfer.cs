using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InternalTransfer
    {
        public System.String Currency { get; set; }
        public System.String TxId { get; set; }
        public System.Decimal Amount { get; set; }
        public System.String Status { get; set; }
        public System.String Comment { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime TransferDate { get; set; }
    }
}
