using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMessageSend.Forms
{
	public partial class UserMainForm : Form
	{

		public UserMainForm()
		{
			InitializeComponent();
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			LoginForm LF = new LoginForm();
			LF.Show();
			this.Close();
		}

		private void sendMessageBtn_Click(object sender, EventArgs e)
		{
			MessageAddForm MAF = new MessageAddForm();
			MAF.ShowDialog();
		}

		private void viewMessageBtn_Click(object sender, EventArgs e)
		{
			MessageViewForm MVF = new MessageViewForm();
			MVF.ShowDialog();
		}

		private void UserMainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
