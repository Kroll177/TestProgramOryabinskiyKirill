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
	public partial class MessageBBodyViewForm : Form
	{
		CompanyContext _context;
		MessageController _controller;
		public MessageBBodyViewForm()
		{
			InitializeComponent();
			_context = new CompanyContext();
			_controller = new MessageController(_context);
		}

		private void MessageBBodyViewForm_Load(object sender, EventArgs e)
		{
			bodyTB.Text = _controller.ViewBodyMessage(MessageViewForm.nMessage);
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MessageBBodyViewForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_context.Dispose();
		}
	}
}
