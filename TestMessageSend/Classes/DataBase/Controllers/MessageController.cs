using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMessageSend.Classes.DataBase.Domains;

namespace TestMessageSend.Classes.DataBase.Controllers
{
	internal class MessageController
	{
		readonly CompanyContext _context;
		public MessageController(CompanyContext context)
		{
			_context = context;
		}

		public void Add(Domains.Message message)
		{
			_context.Add(message);
			_context.SaveChanges();
			MessageBox.Show("Добавление успешно");
		}

		public void UpdateIsRead(int messageID)
		{
			var message = _context.Messages.FirstOrDefault(m => m.MessageID == messageID);
			message.IsRead=true;
			_context.SaveChanges();
		}

		public string ViewBodyMessage(int messageID)
		{
			var message = _context.Messages.FirstOrDefault(m => m.MessageID == messageID);
			return message.Body;
		}

		public List<MessageDTO> ViewMessages(int receiverID)
		{
			return _context.Messages
				.Include(o => o.Sender)
				.Where(o => o.ReceiverID == receiverID)
				.Select(o => new MessageDTO
				{
					MessageID= o.MessageID,
					FullName=o.Sender.FullName,
					Timestamp=o.Timestamp,
					IsRead=o.IsRead,
				})
				.ToList();
		}
	}
}
