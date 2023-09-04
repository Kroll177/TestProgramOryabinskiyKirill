namespace TestMessageSend.Forms
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			passwordCheckBox = new CheckBox();
			exitBtn = new Button();
			newUserBtn = new Button();
			loginBtn = new Button();
			passwordTB = new TextBox();
			label2 = new Label();
			loginTB = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// passwordCheckBox
			// 
			passwordCheckBox.AutoSize = true;
			passwordCheckBox.Location = new Point(53, 130);
			passwordCheckBox.Name = "passwordCheckBox";
			passwordCheckBox.Size = new Size(150, 25);
			passwordCheckBox.TabIndex = 15;
			passwordCheckBox.Text = "Показать пароль";
			passwordCheckBox.UseVisualStyleBackColor = true;
			passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
			// 
			// exitBtn
			// 
			exitBtn.Location = new Point(12, 231);
			exitBtn.Name = "exitBtn";
			exitBtn.Size = new Size(226, 29);
			exitBtn.TabIndex = 14;
			exitBtn.Text = "Выход";
			exitBtn.UseVisualStyleBackColor = true;
			exitBtn.Click += exitBtnClick;
			// 
			// newUserBtn
			// 
			newUserBtn.Location = new Point(12, 196);
			newUserBtn.Name = "newUserBtn";
			newUserBtn.Size = new Size(226, 29);
			newUserBtn.TabIndex = 13;
			newUserBtn.Text = "Новый пользователь";
			newUserBtn.UseVisualStyleBackColor = true;
			newUserBtn.Click += newUserBtn_Click;
			// 
			// loginBtn
			// 
			loginBtn.Location = new Point(12, 161);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(226, 29);
			loginBtn.TabIndex = 12;
			loginBtn.Text = "Вход";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += button1_Click;
			// 
			// passwordTB
			// 
			passwordTB.Location = new Point(12, 94);
			passwordTB.Margin = new Padding(4);
			passwordTB.Name = "passwordTB";
			passwordTB.Size = new Size(225, 29);
			passwordTB.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(92, 69);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(63, 21);
			label2.TabIndex = 10;
			label2.Text = "Пароль";
			// 
			// loginTB
			// 
			loginTB.Location = new Point(12, 36);
			loginTB.Margin = new Padding(4);
			loginTB.Name = "loginTB";
			loginTB.Size = new Size(225, 29);
			loginTB.TabIndex = 9;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(95, 11);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(54, 21);
			label1.TabIndex = 8;
			label1.Text = "Логин";
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(250, 293);
			ControlBox = false;
			Controls.Add(passwordCheckBox);
			Controls.Add(exitBtn);
			Controls.Add(newUserBtn);
			Controls.Add(loginBtn);
			Controls.Add(passwordTB);
			Controls.Add(label2);
			Controls.Add(loginTB);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			MinimumSize = new Size(266, 309);
			Name = "LoginForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Авторизация";
			Load += LoginForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckBox passwordCheckBox;
		private Button exitBtn;
		private Button newUserBtn;
		private Button loginBtn;
		private TextBox passwordTB;
		private Label label2;
		private TextBox loginTB;
		private Label label1;
	}
}