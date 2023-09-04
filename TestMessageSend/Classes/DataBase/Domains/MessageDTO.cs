using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMessageSend.Classes.DataBase.Domains
{
	internal class MessageDTO
	{
		public int MessageID { get; set; }
		public string FullName { get; set; }
		public bool IsRead { get; set; }
		public DateTime Timestamp { get; set; }
		public int ReceiverID { get; set; }
	}
}
