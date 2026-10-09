namespace MyProject
{
	partial class frmBaiTap1
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
			components = new System.ComponentModel.Container();
			lblYourname = new Label();
			txtYourName = new TextBox();
			lblYear = new Label();
			txtYear = new TextBox();
			btnShow = new Button();
			btnClear = new Button();
			btnExit = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// lblYourname
			// 
			lblYourname.AutoSize = true;
			lblYourname.Location = new Point(29, 24);
			lblYourname.Name = "lblYourname";
			lblYourname.Size = new Size(101, 22);
			lblYourname.TabIndex = 0;
			lblYourname.Text = "Your name:";
			// 
			// txtYourName
			// 
			txtYourName.BorderStyle = BorderStyle.FixedSingle;
			txtYourName.Location = new Point(136, 22);
			txtYourName.Name = "txtYourName";
			txtYourName.Size = new Size(280, 29);
			txtYourName.TabIndex = 1;
			txtYourName.Leave += txtYourName_Leave;
			// 
			// lblYear
			// 
			lblYear.AutoSize = true;
			lblYear.Location = new Point(16, 64);
			lblYear.Name = "lblYear";
			lblYear.Size = new Size(114, 22);
			lblYear.TabIndex = 2;
			lblYear.Text = "Year of birth:";
			// 
			// txtYear
			// 
			txtYear.BorderStyle = BorderStyle.FixedSingle;
			txtYear.Location = new Point(136, 62);
			txtYear.Name = "txtYear";
			txtYear.Size = new Size(280, 29);
			txtYear.TabIndex = 3;
			txtYear.TextChanged += txtYear_TextChanged;
			// 
			// btnShow
			// 
			btnShow.Location = new Point(29, 178);
			btnShow.Name = "btnShow";
			btnShow.Size = new Size(91, 29);
			btnShow.TabIndex = 4;
			btnShow.Text = "&Show";
			btnShow.UseVisualStyleBackColor = true;
			btnShow.Click += btnShow_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(177, 178);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(85, 29);
			btnClear.TabIndex = 5;
			btnClear.Text = "&Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(315, 178);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(83, 29);
			btnExit.TabIndex = 6;
			btnExit.Text = "E&xit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmBaiTap1
			// 
			AutoScaleDimensions = new SizeF(10F, 22F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(442, 232);
			Controls.Add(btnExit);
			Controls.Add(btnClear);
			Controls.Add(btnShow);
			Controls.Add(txtYear);
			Controls.Add(lblYear);
			Controls.Add(txtYourName);
			Controls.Add(lblYourname);
			Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(4, 3, 4, 3);
			Name = "frmBaiTap1";
			Text = "My name project";
			FormClosing += frmBaiTap1_FormClosing;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblYourname;
		private TextBox txtYourName;
		private Label lblYear;
		private TextBox txtYear;
		private Button btnShow;
		private Button btnClear;
		private Button btnExit;
		private ErrorProvider errorProvider1;
	}
}