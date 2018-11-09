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
    public class InitialAssetOfferingParticipation
    {
        public System.Int64 Id { get; set; }
        public System.Int64 InitialAssetOfferingId { get; set; }
        public System.Int64 TraderId { get; set; }
        public System.String Currency { get; set; }
        public System.String BaseCurrency { get; set; }
        public System.Double AmountInBaseCurrency { get; set; }
        public System.String Status { get; set; }
        public System.DateTime PledgeDate { get; set; }
    }
}