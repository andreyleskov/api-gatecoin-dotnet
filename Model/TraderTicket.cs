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
public class TraderTicket
{
public System.Int64 TicketID { get; set; }
public System.Int64 TraderID { get; set; }
public System.String Subject { get; set; }
public System.String Message { get; set; }
public System.String Attachment { get; set; }
public System.Int64 AnswerTicketID { get; set; }
public DateTime Date { get; set; }
public System.Boolean IsInternal { get; set; }
public System.String Status { get; set; }
public System.DateTime LastUpdateDate { get; set; }
public List<TraderTicket> Replies { get; set; }
public System.Int64 RootTicketID { get; set; }
public System.Boolean IsFromUser { get; set; }
}
}
