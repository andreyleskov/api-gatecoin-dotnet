using System;
using GatecoinServiceInterface.Response;

namespace GatecoinServiceInterface.Model
{
    public class MiniTrade : CommonResponse
    {
        public long I { get; set; }
        public decimal P { get; set; }
        public decimal A { get; set; }
        public DateTime D { get; set; }
    }
}