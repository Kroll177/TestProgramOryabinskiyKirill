namespace TestMessageSend.Forms
{
	partial class MessageBBodyViewForm
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
			bodyTB = new TextBox();
			backBtn = new Button();
			SuspendLayout();
			// 
			// bodyTB
			// 
			bodyTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			bodyTB.Location = new Point(13, 13);
			bodyTB.Margin = new Padding(5);
			bodyTB.Multiline = true;
			bodyTB.Name = "bodyTB";
			bodyTB.ReadOnly = true;
			bodyTB.Size = new Size(579, 528);
			bodyTB.TabIndex = 0;
			// 
			// backBtn
			// 
			backBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			backBtn.Location = new Point(13, 551);
			backBtn.Margin = new Padding(5);
			backBtn.MinimumSize = new Size(167, 47);
			backBtn.Name = "backBtn";
			backBtn.Size = new Size(167, 47);
			backBtn.TabIndex = 1;
			backBtn.Text = "Назад";
			backBtn.UseVisualStyleBackColor = true;
			backBtn.Click += backBtn_Click;
			// 
			// MessageBBodyViewForm
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(603, 630);
			ControlBox = false;
			Controls.Add(backBtn);
			Controls.Add(bodyTB);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(5);
			MinimumSize = new Size(619, 646);
			Name = "MessageBBodyViewForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Содержание";
			FormClosing += MessageBBodyViewForm_FormClosing;
			Load += MessageBBodyViewForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox bodyTB;
		private Button backBtn;
	}
}