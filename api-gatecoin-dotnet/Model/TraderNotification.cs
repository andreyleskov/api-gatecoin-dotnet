using System;

namespace GatecoinServiceInterface.Model
{
    public class TraderNotification
    {
        public long ID { get; set; }
        public long trader_id { get; set; }
        public string messageCode { get; set; }
        public bool read { get; set; }
        public DateTime createDate { get; set; }
        public DateTime updateDate { get; set; }
    }
}