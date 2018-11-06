using System;
using System.Collections.Generic;

namespace GatecoinServiceInterface.Model
{
    [Serializable]
    public class TraderTicket
    {
        public long TicketID { get; set; }
        public long TraderID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Attachment { get; set; }
        public long AnswerTicketID { get; set; }
        public DateTime Date { get; set; }
        public bool IsInternal { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public List<TraderTicket> Replies { get; set; }
        public long RootTicketID { get; set; }
        public bool IsFromUser { get; set; }
    }
}