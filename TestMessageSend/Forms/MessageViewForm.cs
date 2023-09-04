using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMessageSend.Classes.DataBase.Controllers;
using TestMessageSend.Classes.DataBase.Domains;

namespace TestMessageSend.Forms
{
	public partial class MessageViewForm : Form
	{
		private CompanyContext _context;
		private UserController _userControl;
		private MessageController _messageController;
		static public int nMessage;
		public MessageViewForm()
		{
			InitializeComponent();
			_context = new CompanyContext();
			_userControl = new UserController(_context);
			_messageController = new MessageController(_context);
		}

		private void MessageViewFormLoad(object sender, EventArgs e)
		{
			dataMessageView.DataSource = _messageController.ViewMessages(_userControl.UserIdGet(LoginForm.loginUserMain));
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MessageViewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_context.Dispose();
		}

		private void dataMessageView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dataMessageView.Columns[0].Index && e.RowIndex >= 0)
			{
				bool value = (bool)dataMessageView.Rows[e.RowIndex].Cells["IsRead"].Value;
				nMessage = (int)dataMessageView.Rows[e.RowIndex].Cells["ID"].Value;
				if (!value)
				{
					_messageController.UpdateIsRead(nMessage);
					MessageBBodyViewForm messageBBodyViewForm = new MessageBBodyViewForm();
					messageBBodyViewForm.ShowDialog();
				}
				else
				{
					MessageBBodyViewForm messageBBodyViewForm = new MessageBBodyViewForm();
					messageBBodyViewForm.ShowDialog();
				}
			}
		}

		private void MessageViewForm_Activated(object sender, EventArgs e)
		{
			dataMessageView.DataSource = _messageController.ViewMessages(_userControl.UserIdGet(LoginForm.loginUserMain));
		}
	}
}
