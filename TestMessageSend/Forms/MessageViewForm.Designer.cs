namespace TestMessageSend.Forms
{
	partial class MessageViewForm
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
			dataMessageView = new DataGridView();
			ID = new DataGridViewTextBoxColumn();
			fullname = new DataGridViewTextBoxColumn();
			Timestamp = new DataGridViewTextBoxColumn();
			isRead = new DataGridViewCheckBoxColumn();
			ReceiverID = new DataGridViewTextBoxColumn();
			Btn = new DataGridViewButtonColumn();
			backBtn = new Button();
			((System.ComponentModel.ISupportInitialize)dataMessageView).BeginInit();
			SuspendLayout();
			// 
			// dataMessageView
			// 
			dataMessageView.AllowUserToAddRows = false;
			dataMessageView.AllowUserToDeleteRows = false;
			dataMessageView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataMessageView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataMessageView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataMessageView.Columns.AddRange(new DataGridViewColumn[] { ID, fullname, Timestamp, isRead, ReceiverID, Btn });
			dataMessageView.Location = new Point(15, 17);
			dataMessageView.Margin = new Padding(4);
			dataMessageView.Name = "dataMessageView";
			dataMessageView.ReadOnly = true;
			dataMessageView.RowTemplate.Height = 25;
			dataMessageView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataMessageView.Size = new Size(942, 276);
			dataMessageView.TabIndex = 0;
			dataMessageView.CellClick += dataMessageView_CellClick;
			// 
			// ID
			// 
			ID.DataPropertyName = "MessageID";
			ID.HeaderText = "Номер";
			ID.Name = "ID";
			ID.ReadOnly = true;
			// 
			// fullname
			// 
			fullname.DataPropertyName = "fullname";
			fullname.HeaderText = "ФИО Отправителя";
			fullname.Name = "fullname";
			fullname.ReadOnly = true;
			// 
			// Timestamp
			// 
			Timestamp.DataPropertyName = "Timestamp";
			Timestamp.HeaderText = "Дата отправления";
			Timestamp.Name = "Timestamp";
			Timestamp.ReadOnly = true;
			// 
			// isRead
			// 
			isRead.DataPropertyName = "isRead";
			isRead.FalseValue = "false";
			isRead.HeaderText = "Прочитан";
			isRead.Name = "isRead";
			isRead.ReadOnly = true;
			isRead.Resizable = DataGridViewTriState.True;
			isRead.SortMode = DataGridViewColumnSortMode.Automatic;
			isRead.TrueValue = "true";
			// 
			// ReceiverID
			// 
			ReceiverID.DataPropertyName = "ReceiverID";
			ReceiverID.HeaderText = "ReceiverID";
			ReceiverID.Name = "ReceiverID";
			ReceiverID.ReadOnly = true;
			ReceiverID.Visible = false;
			// 
			// Btn
			// 
			Btn.HeaderText = "Содержание";
			Btn.Name = "Btn";
			Btn.ReadOnly = true;
			Btn.Text = "Прочитать";
			Btn.UseColumnTextForButtonValue = true;
			// 
			// backBtn
			// 
			backBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			backBtn.Location = new Point(15, 302);
			backBtn.Margin = new Padding(4);
			backBtn.Name = "backBtn";
			backBtn.Size = new Size(118, 44);
			backBtn.TabIndex = 1;
			backBtn.Text = "Назад";
			backBtn.UseVisualStyleBackColor = true;
			backBtn.Click += backBtn_Click;
			// 
			// MessageViewForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(972, 382);
			ControlBox = false;
			Controls.Add(backBtn);
			Controls.Add(dataMessageView);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4);
			MinimumSize = new Size(988, 398);
			Name = "MessageViewForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Просмотр сообщений";
			Activated += MessageViewForm_Activated;
			FormClosed += MessageViewForm_FormClosed;
			Load += MessageViewFormLoad;
			((System.ComponentModel.ISupportInitialize)dataMessageView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataMessageView;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn fullname;
		private DataGridViewTextBoxColumn Timestamp;
		private DataGridViewCheckBoxColumn isRead;
		private DataGridViewTextBoxColumn ReceiverID;
		private DataGridViewButtonColumn Btn;
		private Button backBtn;
	}
}