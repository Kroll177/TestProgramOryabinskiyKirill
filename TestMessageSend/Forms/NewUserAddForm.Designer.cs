namespace TestMessageSend.Forms
{
	partial class NewUserAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserAddForm));
			fioLabel = new Label();
			fioTB = new TextBox();
			eMailTB = new TextBox();
			eMailLabel = new Label();
			userNameTB = new TextBox();
			userNameLabel = new Label();
			passwordTB = new TextBox();
			passwordLabel = new Label();
			passwordCheckBox = new CheckBox();
			addBtn = new Button();
			exitBtn = new Button();
			SuspendLayout();
			// 
			// fioLabel
			// 
			fioLabel.AutoSize = true;
			fioLabel.Location = new Point(21, 17);
			fioLabel.Margin = new Padding(4, 0, 4, 0);
			fioLabel.Name = "fioLabel";
			fioLabel.Size = new Size(46, 21);
			fioLabel.TabIndex = 0;
			fioLabel.Text = "ФИО";
			// 
			// fioTB
			// 
			fioTB.Location = new Point(21, 41);
			fioTB.Name = "fioTB";
			fioTB.Size = new Size(189, 29);
			fioTB.TabIndex = 1;
			fioTB.KeyPress += fioTB_KeyPress;
			// 
			// eMailTB
			// 
			eMailTB.Location = new Point(21, 101);
			eMailTB.Name = "eMailTB";
			eMailTB.Size = new Size(189, 29);
			eMailTB.TabIndex = 3;
			// 
			// eMailLabel
			// 
			eMailLabel.AutoSize = true;
			eMailLabel.Location = new Point(21, 77);
			eMailLabel.Margin = new Padding(4, 0, 4, 0);
			eMailLabel.Name = "eMailLabel";
			eMailLabel.Size = new Size(54, 21);
			eMailLabel.TabIndex = 2;
			eMailLabel.Text = "Почта";
			// 
			// userNameTB
			// 
			userNameTB.Location = new Point(230, 41);
			userNameTB.Name = "userNameTB";
			userNameTB.Size = new Size(189, 29);
			userNameTB.TabIndex = 5;
			// 
			// userNameLabel
			// 
			userNameLabel.AutoSize = true;
			userNameLabel.Location = new Point(230, 17);
			userNameLabel.Margin = new Padding(4, 0, 4, 0);
			userNameLabel.Name = "userNameLabel";
			userNameLabel.Size = new Size(54, 21);
			userNameLabel.TabIndex = 4;
			userNameLabel.Text = "Логин";
			// 
			// passwordTB
			// 
			passwordTB.Location = new Point(230, 101);
			passwordTB.Name = "passwordTB";
			passwordTB.Size = new Size(189, 29);
			passwordTB.TabIndex = 7;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Location = new Point(230, 77);
			passwordLabel.Margin = new Padding(4, 0, 4, 0);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(63, 21);
			passwordLabel.TabIndex = 6;
			passwordLabel.Text = "Пароль";
			// 
			// passwordCheckBox
			// 
			passwordCheckBox.AutoSize = true;
			passwordCheckBox.Location = new Point(247, 136);
			passwordCheckBox.Name = "passwordCheckBox";
			passwordCheckBox.Size = new Size(150, 25);
			passwordCheckBox.TabIndex = 8;
			passwordCheckBox.Text = "Показать пароль";
			passwordCheckBox.UseVisualStyleBackColor = true;
			passwordCheckBox.CheckedChanged += passwordCheckBox_CheckedChanged;
			// 
			// addBtn
			// 
			addBtn.Location = new Point(232, 167);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(189, 29);
			addBtn.TabIndex = 9;
			addBtn.Text = "Добавить";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// exitBtn
			// 
			exitBtn.Location = new Point(21, 167);
			exitBtn.Name = "exitBtn";
			exitBtn.Size = new Size(189, 29);
			exitBtn.TabIndex = 10;
			exitBtn.Text = "Назад";
			exitBtn.UseVisualStyleBackColor = true;
			exitBtn.Click += exitBtn_Click;
			// 
			// NewUserAddForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(433, 211);
			ControlBox = false;
			Controls.Add(exitBtn);
			Controls.Add(addBtn);
			Controls.Add(passwordCheckBox);
			Controls.Add(passwordTB);
			Controls.Add(passwordLabel);
			Controls.Add(userNameTB);
			Controls.Add(userNameLabel);
			Controls.Add(eMailTB);
			Controls.Add(eMailLabel);
			Controls.Add(fioTB);
			Controls.Add(fioLabel);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4);
			Name = "NewUserAddForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Добавление нового пользователя";
			FormClosed += NewUserAddForm_FormClosed;
			Load += NewUserAddForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label fioLabel;
		private TextBox fioTB;
		private TextBox eMailTB;
		private Label eMailLabel;
		private TextBox userNameTB;
		private Label userNameLabel;
		private TextBox passwordTB;
		private Label passwordLabel;
		private CheckBox passwordCheckBox;
		private Button addBtn;
		private Button exitBtn;
	}
}