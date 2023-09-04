namespace TestMessageSend.Forms
{
	partial class MessageAddForm
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
			label1 = new Label();
			receiverTB = new ComboBox();
			messageTB = new TextBox();
			label2 = new Label();
			backBtn = new Button();
			sendBtn = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(14, 9);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(115, 25);
			label1.TabIndex = 0;
			label1.Text = "Получатель";
			// 
			// receiverTB
			// 
			receiverTB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			receiverTB.DropDownStyle = ComboBoxStyle.DropDownList;
			receiverTB.FormattingEnabled = true;
			receiverTB.Location = new Point(14, 37);
			receiverTB.Name = "receiverTB";
			receiverTB.Size = new Size(397, 33);
			receiverTB.TabIndex = 1;
			// 
			// messageTB
			// 
			messageTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			messageTB.Location = new Point(14, 110);
			messageTB.Multiline = true;
			messageTB.Name = "messageTB";
			messageTB.Size = new Size(397, 277);
			messageTB.TabIndex = 2;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(14, 82);
			label2.Name = "label2";
			label2.Size = new Size(163, 25);
			label2.TabIndex = 3;
			label2.Text = "Текст сообщения";
			// 
			// backBtn
			// 
			backBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			backBtn.Location = new Point(14, 393);
			backBtn.Name = "backBtn";
			backBtn.Size = new Size(161, 46);
			backBtn.TabIndex = 4;
			backBtn.Text = "Назад";
			backBtn.UseVisualStyleBackColor = true;
			backBtn.Click += backBtn_Click;
			// 
			// sendBtn
			// 
			sendBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			sendBtn.Location = new Point(250, 393);
			sendBtn.Name = "sendBtn";
			sendBtn.Size = new Size(161, 46);
			sendBtn.TabIndex = 5;
			sendBtn.Text = "Отправить";
			sendBtn.UseVisualStyleBackColor = true;
			sendBtn.Click += sendBtn_Click;
			// 
			// MessageAddForm
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(428, 474);
			ControlBox = false;
			Controls.Add(sendBtn);
			Controls.Add(backBtn);
			Controls.Add(label2);
			Controls.Add(messageTB);
			Controls.Add(receiverTB);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(5);
			MinimumSize = new Size(444, 490);
			Name = "MessageAddForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Отправка сообщения";
			FormClosed += MessageAddForm_FormClosed;
			Load += MessageAddForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox receiverTB;
		private TextBox messageTB;
		private Label label2;
		private Button backBtn;
		private Button sendBtn;
	}
}