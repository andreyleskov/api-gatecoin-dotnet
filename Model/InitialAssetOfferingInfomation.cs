using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class InitialAssetOfferingInformation
    {
        public System.String BaseCurrency { get; set; }
        public System.String Currency { get; set; }
        public System.Double CurrentPledgedAmount { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.Int64 Id { get; set; }
        public System.Double IndividualMaximumOfferingAmountInBaseCurrency { get; set; }
        public System.Double IndividualMinimumOfferingAmountInBaseCurrency { get; set; }
        public System.Boolean PledgingEnabled { get; set; }
        public System.Double PriceInBaseCurrency { get; set; }
        public System.DateTime PledgeDate { get; set; }
        public System.String RestrictedCountryCodes { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.Double TotalOfferingAmountInBaseCurrency { get; set; }
    }
}