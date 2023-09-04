using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMessageSend.Classes.DataBase.Controllers;
using TestMessageSend.Classes.DataBase.Domains;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TestMessageSend.Forms
{
	public partial class NewUserAddForm : Form
	{
		private readonly UserController _controller;
		private readonly CompanyContext _context;
		public NewUserAddForm()
		{
			InitializeComponent();
			_context = new CompanyContext();
			_controller = new UserController(_context);
		}
		readonly string patternEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
		readonly string patternFIO = @"^[А-Я][а-я]+ [А-Я]\.[А-Я]\.$";



		private void NewUserAddForm_Load(object sender, EventArgs e)
		{
			passwordTB.UseSystemPasswordChar = true;
		}

		private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (passwordCheckBox.Checked == true)
				passwordTB.UseSystemPasswordChar = false;
			else
				passwordTB.UseSystemPasswordChar = true;
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			foreach (TextBox tb in this.Controls.OfType<TextBox>())
			{
				if (tb.Text == "")
				{
					MessageBox.Show("Заполните все поля");
					return;
				}
			}

			if (!Regex.IsMatch(eMailTB.Text, patternEmail))
			{
				MessageBox.Show("Неправильный формат почты");
				return;
			}
			if (!Regex.IsMatch(fioTB.Text, patternFIO))
			{
				MessageBox.Show("Формат ФИО должен быть Фамилия И.О.");
				return;
			}

			var user = new User
			{
				UserName = userNameTB.Text,
				Email = eMailTB.Text,
				Password = passwordTB.Text,
				FullName = fioTB.Text,
			};

			_controller.Add(user);

		}

		private void fioTB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			_context.Dispose();
			this.Close();
			LoginForm LF = new LoginForm();
			LF.Show();
		}

		private void NewUserAddForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			_context.Dispose();
		}
	}
}
