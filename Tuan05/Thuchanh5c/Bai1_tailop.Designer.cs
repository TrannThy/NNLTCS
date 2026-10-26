namespace Thuchanh5c
{
	partial class frmBai1_tailop
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
			groupBox1 = new GroupBox();
			btnCapNhat = new Button();
			txtNhapSo = new TextBox();
			cboSo = new ComboBox();
			groupBox2 = new GroupBox();
			lstUocSo = new ListBox();
			btnSoLuongNguyenTo = new Button();
			btnSoLuongChan = new Button();
			btnTongUoc = new Button();
			btnThoat = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnCapNhat);
			groupBox1.Controls.Add(txtNhapSo);
			groupBox1.Controls.Add(cboSo);
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(235, 119);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nhập số";
			// 
			// btnCapNhat
			// 
			btnCapNhat.Location = new Point(141, 24);
			btnCapNhat.Name = "btnCapNhat";
			btnCapNhat.Size = new Size(88, 29);
			btnCapNhat.TabIndex = 6;
			btnCapNhat.Text = "&Cập nhật";
			btnCapNhat.UseVisualStyleBackColor = true;
			btnCapNhat.Click += btnCapNhat_Click;
			// 
			// txtNhapSo
			// 
			txtNhapSo.Location = new Point(12, 26);
			txtNhapSo.Name = "txtNhapSo";
			txtNhapSo.Size = new Size(125, 27);
			txtNhapSo.TabIndex = 2;
			// 
			// cboSo
			// 
			cboSo.FormattingEnabled = true;
			cboSo.Location = new Point(12, 66);
			cboSo.Name = "cboSo";
			cboSo.Size = new Size(198, 27);
			cboSo.TabIndex = 1;
			cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lstUocSo);
			groupBox2.Location = new Point(245, 0);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(281, 119);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh sách các ước số";
			// 
			// lstUocSo
			// 
			lstUocSo.FormattingEnabled = true;
			lstUocSo.ItemHeight = 19;
			lstUocSo.Location = new Point(6, 24);
			lstUocSo.Name = "lstUocSo";
			lstUocSo.Size = new Size(269, 80);
			lstUocSo.TabIndex = 7;
			// 
			// btnSoLuongNguyenTo
			// 
			btnSoLuongNguyenTo.Location = new Point(264, 195);
			btnSoLuongNguyenTo.Name = "btnSoLuongNguyenTo";
			btnSoLuongNguyenTo.Size = new Size(231, 29);
			btnSoLuongNguyenTo.TabIndex = 3;
			btnSoLuongNguyenTo.Text = "Số lượng các ước số &nguyên tố";
			btnSoLuongNguyenTo.UseVisualStyleBackColor = true;
			btnSoLuongNguyenTo.Click += btnSoLuongNguyenTo_Click;
			// 
			// btnSoLuongChan
			// 
			btnSoLuongChan.Location = new Point(264, 160);
			btnSoLuongChan.Name = "btnSoLuongChan";
			btnSoLuongChan.Size = new Size(231, 29);
			btnSoLuongChan.TabIndex = 4;
			btnSoLuongChan.Text = "&Số lượng các ước số chẵn";
			btnSoLuongChan.UseVisualStyleBackColor = true;
			btnSoLuongChan.Click += btnSoLuongChan_Click;
			// 
			// btnTongUoc
			// 
			btnTongUoc.Location = new Point(264, 125);
			btnTongUoc.Name = "btnTongUoc";
			btnTongUoc.Size = new Size(231, 29);
			btnTongUoc.TabIndex = 5;
			btnTongUoc.Text = "&Tổng các ước số";
			btnTongUoc.UseVisualStyleBackColor = true;
			btnTongUoc.Click += btnTongUoc_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(82, 195);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 7;
			btnThoat.Text = "Th&oát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmBai1_tailop
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(540, 240);
			Controls.Add(btnThoat);
			Controls.Add(btnTongUoc);
			Controls.Add(btnSoLuongNguyenTo);
			Controls.Add(btnSoLuongChan);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1_tailop";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button btnCapNhat;
		private TextBox txtNhapSo;
		private ComboBox cboSo;
		private ListBox lstUocSo;
		private Button btnSoLuongNguyenTo;
		private Button btnSoLuongChan;
		private Button btnTongUoc;
		private Button btnThoat;
	}
}