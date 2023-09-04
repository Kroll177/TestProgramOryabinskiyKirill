using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMessageSend.Classes.DataBase.Controllers;
using TestMessageSend.Classes.DataBase.Domains;

namespace TestMessageSend.Forms
{
	public partial class MessageAddForm : Form
	{
		readonly CompanyContext _context;
		readonly UserController _userController;
		readonly MessageController _messageController;

		public MessageAddForm()
		{
			InitializeComponent();
			_context = new CompanyContext();
			_userController = new UserController(_context);
			_messageController = new MessageController(_context);
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void sendBtn_Click(object sender, EventArgs e)
		{
			if (messageTB.Text != "")
			{
				var message = new Classes.DataBase.Domains.Message
				{
					SenderID = _userController.UserIdGet(LoginForm.loginUserMain),
					ReceiverID = (int)receiverTB.SelectedValue,
					Body = messageTB.Text,
					Timestamp = DateTime.Now,
					IsRead = false
				};
				_messageController.Add(message);
				this.Close();
			}
			else
				MessageBox.Show("Заполните поле");
		}

		private void MessageAddForm_Load(object sender, EventArgs e)
		{
			var ListOfUsers = _userController.UserComboBox(LoginForm.loginUserMain);
			receiverTB.ValueMember = "userid";
			receiverTB.DisplayMember = "FullName";
			receiverTB.DataSource = ListOfUsers;
		}

		private void MessageAddForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_context.Dispose();
		}
	}
}
