using System.Collections.Generic;
using GatecoinServiceInterface.Model;

namespace GatecoinServiceInterface.Response
{
    public class GetCountriesResponse : CommonResponse
    {
        public List<Country> Countries { get; set; }
    }
}