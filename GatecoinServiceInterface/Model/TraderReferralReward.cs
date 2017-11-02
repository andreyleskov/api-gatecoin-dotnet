using ServiceStack.ServiceInterface.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Model{
[Serializable]
public class TraderReferralReward 
{
public List<Reward> RewardsHistory {get; set; } 
public System.Decimal CurrentReward {get; set; } 
}
}

