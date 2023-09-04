namespace TestMessageSend.Forms
{
	partial class UserMainForm
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
			sendMessageBtn = new Button();
			viewMessageBtn = new Button();
			backBtn = new Button();
			SuspendLayout();
			// 
			// sendMessageBtn
			// 
			sendMessageBtn.Location = new Point(13, 13);
			sendMessageBtn.Margin = new Padding(4);
			sendMessageBtn.Name = "sendMessageBtn";
			sendMessageBtn.Size = new Size(245, 33);
			sendMessageBtn.TabIndex = 0;
			sendMessageBtn.Text = "Отправить письмо";
			sendMessageBtn.UseVisualStyleBackColor = true;
			sendMessageBtn.Click += sendMessageBtn_Click;
			// 
			// viewMessageBtn
			// 
			viewMessageBtn.Location = new Point(13, 54);
			viewMessageBtn.Margin = new Padding(4);
			viewMessageBtn.Name = "viewMessageBtn";
			viewMessageBtn.Size = new Size(245, 33);
			viewMessageBtn.TabIndex = 1;
			viewMessageBtn.Text = "Входящие письма";
			viewMessageBtn.UseVisualStyleBackColor = true;
			viewMessageBtn.Click += viewMessageBtn_Click;
			// 
			// backBtn
			// 
			backBtn.Location = new Point(13, 94);
			backBtn.Name = "backBtn";
			backBtn.Size = new Size(121, 34);
			backBtn.TabIndex = 2;
			backBtn.Text = "Выход";
			backBtn.UseVisualStyleBackColor = true;
			backBtn.Click += backBtn_Click;
			// 
			// UserMainForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(271, 140);
			ControlBox = false;
			Controls.Add(backBtn);
			Controls.Add(viewMessageBtn);
			Controls.Add(sendMessageBtn);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			Name = "UserMainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Главная";
			Load += UserMainForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button sendMessageBtn;
		private Button viewMessageBtn;
		private Button backBtn;
	}
}