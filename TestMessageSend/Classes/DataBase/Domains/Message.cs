using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestMessageSend.Classes.DataBase.Domains
{
	public class Message
	{
		public int MessageID { get; set; }
		public int SenderID { get; set; }
		[ForeignKey("SenderID")]
		public User Sender { get; set; } = null!;
		[ForeignKey("ReceiverID")]
		public int ReceiverID { get; set; }
		public User Receiver { get; set; } = null!;
		public string Body { get; set; } = null!;
		public DateTime Timestamp { get; set; }
		public bool IsRead { get; set; }
	}
}
