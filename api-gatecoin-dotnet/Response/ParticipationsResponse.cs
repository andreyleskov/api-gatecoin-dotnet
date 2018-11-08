using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class ParticipationsResponse : CommonResponse
    {
        public List<InitialAssetOfferingParticipation> Participations { get; set; }
    }
}