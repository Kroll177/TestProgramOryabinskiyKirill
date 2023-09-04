using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMessageSend.Classes.DataBase.Domains;

namespace TestMessageSend.Classes.DataBase.Controllers
{
	internal class UserController
	{
		readonly CompanyContext _context;
		public UserController(CompanyContext context)
		{
			_context = context;
		}

		public bool IsLoginDuplicated(string login)
		{
			return _context.Users
				.Any(u => u.UserName == login);
		}
		public bool IsEMailDuplicated(string eMail)
		{
			return _context.Users
				.Any(u => u.Email == eMail);
		}

		public void Add(User user)
		{
			if (IsLoginDuplicated(user.UserName))
			{
				MessageBox.Show("Такой логин уже существует");
			}
			else
			{
				if (IsEMailDuplicated(user.Email))
				{
					MessageBox.Show("Такой E-Mail уже существует");
				}
				else
				{
					_context.Users.Add(user);
					_context.SaveChanges();
				}
			}
		}

		public List<User> UserComboBox(string loginUserLogged)
		{
			return _context.Users
				.Where(u => u.UserName != loginUserLogged).ToList();
		}

		public int UserIdGet(string loginUserLogged)
		{
			return (int)_context.Users
				.Where(u=>u.UserName==loginUserLogged)
				.Select(u=>u.UserID)
				.Single();
		}

		public bool LoginUser(string login, string password)
		{
			return _context.Users
				.Any(u=> u.UserName==login && u.Password==password);
		}
	}
}
