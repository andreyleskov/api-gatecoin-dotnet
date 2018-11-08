using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetStatsHistoResponse : CommonResponse
    {
        public string TypeOfData { get; set; }
        public List<StatsHistoData> Data { get; set; }
    }
}