using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMessageSend.Classes.DataBase.Domains
{
	public class User
	{
		public int UserID { get; set; }
		public string UserName { get; set; } = null!;
		public string Password { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string FullName { get; set; } = null!;

		public ICollection<Message> SentMessages { get; set; } = new List<Message>();
		public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();

	}
}
