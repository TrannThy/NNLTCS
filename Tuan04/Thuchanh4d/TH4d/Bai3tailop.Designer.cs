namespace TH4d
{
	partial class frmBai3tailop
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
			lblTittle = new Label();
			grpChon = new GroupBox();
			rdoBacHai = new RadioButton();
			rdoBacNhat = new RadioButton();
			lblA = new Label();
			lblB = new Label();
			lblC = new Label();
			txtA = new TextBox();
			txtB = new TextBox();
			txtC = new TextBox();
			lblKetQua = new Label();
			txtKetQua = new TextBox();
			btnGiai = new Button();
			btnThoat = new Button();
			grpChon.SuspendLayout();
			SuspendLayout();
			// 
			// lblTittle
			// 
			lblTittle.AutoSize = true;
			lblTittle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTittle.ForeColor = Color.Red;
			lblTittle.Location = new Point(39, 18);
			lblTittle.Name = "lblTittle";
			lblTittle.Size = new Size(236, 32);
			lblTittle.TabIndex = 0;
			lblTittle.Text = "Giải phương trình";
			// 
			// grpChon
			// 
			grpChon.Controls.Add(rdoBacHai);
			grpChon.Controls.Add(rdoBacNhat);
			grpChon.Location = new Point(39, 74);
			grpChon.Name = "grpChon";
			grpChon.Size = new Size(250, 88);
			grpChon.TabIndex = 1;
			grpChon.TabStop = false;
			grpChon.Text = "bạn vui lòng chọn";
			// 
			// rdoBacHai
			// 
			rdoBacHai.AutoSize = true;
			rdoBacHai.Location = new Point(14, 58);
			rdoBacHai.Name = "rdoBacHai";
			rdoBacHai.Size = new Size(169, 23);
			rdoBacHai.TabIndex = 1;
			rdoBacHai.TabStop = true;
			rdoBacHai.Text = "Phương trình bậc hai";
			rdoBacHai.UseVisualStyleBackColor = true;
			// 
			// rdoBacNhat
			// 
			rdoBacNhat.AutoSize = true;
			rdoBacNhat.Location = new Point(14, 29);
			rdoBacNhat.Name = "rdoBacNhat";
			rdoBacNhat.Size = new Size(177, 23);
			rdoBacNhat.TabIndex = 0;
			rdoBacNhat.TabStop = true;
			rdoBacNhat.Text = "Phương trình bậc nhất";
			rdoBacNhat.UseVisualStyleBackColor = true;
			rdoBacNhat.CheckedChanged += rdoBacNhat_CheckedChanged;
			// 
			// lblA
			// 
			lblA.AutoSize = true;
			lblA.Location = new Point(45, 179);
			lblA.Name = "lblA";
			lblA.Size = new Size(55, 19);
			lblA.TabIndex = 2;
			lblA.Text = "Nhập a";
			// 
			// lblB
			// 
			lblB.AutoSize = true;
			lblB.Location = new Point(45, 207);
			lblB.Name = "lblB";
			lblB.Size = new Size(56, 19);
			lblB.TabIndex = 3;
			lblB.Text = "Nhập b";
			// 
			// lblC
			// 
			lblC.AutoSize = true;
			lblC.Enabled = false;
			lblC.Location = new Point(45, 237);
			lblC.Name = "lblC";
			lblC.Size = new Size(56, 19);
			lblC.TabIndex = 4;
			lblC.Text = "Nhập c";
			// 
			// txtA
			// 
			txtA.Location = new Point(107, 179);
			txtA.Name = "txtA";
			txtA.Size = new Size(125, 27);
			txtA.TabIndex = 5;
			txtA.TextChanged += txtA_TextChanged;
			// 
			// txtB
			// 
			txtB.Location = new Point(107, 207);
			txtB.Name = "txtB";
			txtB.Size = new Size(125, 27);
			txtB.TabIndex = 6;
			txtB.TextChanged += txtB_TextChanged;
			// 
			// txtC
			// 
			txtC.Enabled = false;
			txtC.Location = new Point(107, 234);
			txtC.Multiline = true;
			txtC.Name = "txtC";
			txtC.Size = new Size(125, 34);
			txtC.TabIndex = 7;
			txtC.TextChanged += txtC_TextChanged;
			// 
			// lblKetQua
			// 
			lblKetQua.AutoSize = true;
			lblKetQua.Location = new Point(17, 293);
			lblKetQua.Name = "lblKetQua";
			lblKetQua.Size = new Size(65, 19);
			lblKetQua.TabIndex = 8;
			lblKetQua.Text = "Kết Quả";
			// 
			// txtKetQua
			// 
			txtKetQua.Enabled = false;
			txtKetQua.Location = new Point(88, 293);
			txtKetQua.Multiline = true;
			txtKetQua.Name = "txtKetQua";
			txtKetQua.ReadOnly = true;
			txtKetQua.Size = new Size(200, 47);
			txtKetQua.TabIndex = 9;
			// 
			// btnGiai
			// 
			btnGiai.Enabled = false;
			btnGiai.Location = new Point(238, 174);
			btnGiai.Name = "btnGiai";
			btnGiai.Size = new Size(79, 29);
			btnGiai.TabIndex = 10;
			btnGiai.Text = "Giải";
			btnGiai.UseVisualStyleBackColor = true;
			btnGiai.Click += btnGiai_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(238, 209);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(79, 29);
			btnThoat.TabIndex = 11;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmBai3tailop
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(329, 352);
			Controls.Add(btnThoat);
			Controls.Add(btnGiai);
			Controls.Add(txtKetQua);
			Controls.Add(lblKetQua);
			Controls.Add(txtC);
			Controls.Add(txtB);
			Controls.Add(txtA);
			Controls.Add(lblC);
			Controls.Add(lblB);
			Controls.Add(lblA);
			Controls.Add(grpChon);
			Controls.Add(lblTittle);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai3tailop";
			Text = "Giải phương trình bậc 1-2";
			FormClosing += frmBai3tailop_FormClosing;
			grpChon.ResumeLayout(false);
			grpChon.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTittle;
		private GroupBox grpChon;
		private RadioButton rdoBacHai;
		private RadioButton rdoBacNhat;
		private Label lblA;
		private Label lblB;
		private Label lblC;
		private TextBox txtA;
		private TextBox txtB;
		private TextBox txtC;
		private Label lblKetQua;
		private TextBox txtKetQua;
		private Button btnGiai;
		private Button btnThoat;
	}
}