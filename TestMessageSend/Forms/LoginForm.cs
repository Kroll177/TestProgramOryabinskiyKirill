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
	public partial class LoginForm : Form
	{
		readonly UserController _control;
		readonly CompanyContext _context;
		static public string loginUserMain="";
		public LoginForm()
		{
			InitializeComponent();
			_context = new CompanyContext();
			_control = new UserController(_context);
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			passwordTB.UseSystemPasswordChar = true;
		}

		private void exitBtnClick(object sender, EventArgs e)
		{
			this.Close();
			_context.Dispose();
			Application.Exit();
		}

		private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (passwordCheckBox.Checked == true)
				passwordTB.UseSystemPasswordChar = false;
			else
				passwordTB.UseSystemPasswordChar = true;
		}

		private void newUserBtn_Click(object sender, EventArgs e)
		{
			NewUserAddForm NUAF = new NewUserAddForm();
			this.Hide();
			NUAF.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (loginTB.Text != "" && passwordTB.Text != "")
			{
				if (_control.LoginUser(loginTB.Text, passwordTB.Text) == true)
				{
					UserMainForm UMF = new UserMainForm();
					loginUserMain = loginTB.Text;
					UMF.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Неправильный логин или пароль");
				}
			}
			else
			{
				MessageBox.Show("Заполните все поля");
			}
		}
	}
}
