namespace TH4d
{
	partial class frmBai1NC
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtTenKhach = new TextBox();
			txtSoKhach = new TextBox();
			groupBox1 = new GroupBox();
			rdoCafeKem = new RadioButton();
			rdoCafeDa = new RadioButton();
			rdoCafeSuaDa = new RadioButton();
			rdoCafeSua = new RadioButton();
			rdoCafeDen = new RadioButton();
			groupBox2 = new GroupBox();
			chkMyCay = new CheckBox();
			chkMyXaoBo = new CheckBox();
			chkMyTomTrung = new CheckBox();
			chkBanhMyCa = new CheckBox();
			chkBanhMyTrung = new CheckBox();
			chkSinhVien = new CheckBox();
			txtTongKhachHang = new TextBox();
			txtTongTien = new TextBox();
			btnTinhTien = new Button();
			btnNhapLai = new Button();
			btnThanhToan = new Button();
			btnThoat = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(192, 192, 0);
			label1.Location = new Point(144, 9);
			label1.Name = "label1";
			label1.Size = new Size(241, 32);
			label1.TabIndex = 0;
			label1.Text = "CAFE SINH VIÊN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(2, 61);
			label2.Name = "label2";
			label2.Size = new Size(122, 19);
			label2.TabIndex = 1;
			label2.Text = "Tên khách hàng";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(11, 100);
			label3.Name = "label3";
			label3.Size = new Size(113, 19);
			label3.TabIndex = 2;
			label3.Text = "Số khách hàng";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(42, 349);
			label4.Name = "label4";
			label4.Size = new Size(121, 19);
			label4.TabIndex = 3;
			label4.Text = "Tổng khách hàng";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(17, 381);
			label5.Name = "label5";
			label5.Size = new Size(146, 19);
			label5.TabIndex = 4;
			label5.Text = "Tổng tiền thanh toán";
			// 
			// txtTenKhach
			// 
			txtTenKhach.Location = new Point(130, 58);
			txtTenKhach.Name = "txtTenKhach";
			txtTenKhach.Size = new Size(347, 27);
			txtTenKhach.TabIndex = 5;
			txtTenKhach.TextChanged += txtTenKhach_TextChanged;
			// 
			// txtSoKhach
			// 
			txtSoKhach.Location = new Point(130, 100);
			txtSoKhach.Name = "txtSoKhach";
			txtSoKhach.Size = new Size(347, 27);
			txtSoKhach.TabIndex = 6;
			txtSoKhach.TextChanged += txtSoKhach_TextChanged;
			txtSoKhach.KeyPress += txtSoKhach_KeyPress;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rdoCafeKem);
			groupBox1.Controls.Add(rdoCafeDa);
			groupBox1.Controls.Add(rdoCafeSuaDa);
			groupBox1.Controls.Add(rdoCafeSua);
			groupBox1.Controls.Add(rdoCafeDen);
			groupBox1.Location = new Point(29, 157);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(223, 125);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			groupBox1.Text = "Nước uống";
			// 
			// rdoCafeKem
			// 
			rdoCafeKem.AutoSize = true;
			rdoCafeKem.Location = new Point(120, 55);
			rdoCafeKem.Name = "rdoCafeKem";
			rdoCafeKem.Size = new Size(95, 23);
			rdoCafeKem.TabIndex = 17;
			rdoCafeKem.TabStop = true;
			rdoCafeKem.Text = "Cafe kem";
			rdoCafeKem.UseVisualStyleBackColor = true;
			rdoCafeKem.CheckedChanged += rdoCafeKem_CheckedChanged;
			// 
			// rdoCafeDa
			// 
			rdoCafeDa.AutoSize = true;
			rdoCafeDa.Location = new Point(120, 26);
			rdoCafeDa.Name = "rdoCafeDa";
			rdoCafeDa.Size = new Size(82, 23);
			rdoCafeDa.TabIndex = 16;
			rdoCafeDa.TabStop = true;
			rdoCafeDa.Text = "Cafe đá";
			rdoCafeDa.UseVisualStyleBackColor = true;
			rdoCafeDa.CheckedChanged += rdoCafeDa_CheckedChanged;
			// 
			// rdoCafeSuaDa
			// 
			rdoCafeSuaDa.AutoSize = true;
			rdoCafeSuaDa.Location = new Point(6, 84);
			rdoCafeSuaDa.Name = "rdoCafeSuaDa";
			rdoCafeSuaDa.Size = new Size(109, 23);
			rdoCafeSuaDa.TabIndex = 15;
			rdoCafeSuaDa.TabStop = true;
			rdoCafeSuaDa.Text = "Cafe sữa đá";
			rdoCafeSuaDa.UseVisualStyleBackColor = true;
			rdoCafeSuaDa.CheckedChanged += rdoCafeSuaDa_CheckedChanged;
			// 
			// rdoCafeSua
			// 
			rdoCafeSua.AutoSize = true;
			rdoCafeSua.Location = new Point(6, 55);
			rdoCafeSua.Name = "rdoCafeSua";
			rdoCafeSua.Size = new Size(89, 23);
			rdoCafeSua.TabIndex = 14;
			rdoCafeSua.TabStop = true;
			rdoCafeSua.Text = "Cafe sữa";
			rdoCafeSua.UseVisualStyleBackColor = true;
			rdoCafeSua.CheckedChanged += rdoCafeSua_CheckedChanged;
			// 
			// rdoCafeDen
			// 
			rdoCafeDen.AutoSize = true;
			rdoCafeDen.Location = new Point(6, 26);
			rdoCafeDen.Name = "rdoCafeDen";
			rdoCafeDen.Size = new Size(91, 23);
			rdoCafeDen.TabIndex = 13;
			rdoCafeDen.TabStop = true;
			rdoCafeDen.Text = "Cafe đen";
			rdoCafeDen.UseVisualStyleBackColor = true;
			rdoCafeDen.CheckedChanged += rdoCafeDen_CheckedChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(chkMyCay);
			groupBox2.Controls.Add(chkMyXaoBo);
			groupBox2.Controls.Add(chkMyTomTrung);
			groupBox2.Controls.Add(chkBanhMyCa);
			groupBox2.Controls.Add(chkBanhMyTrung);
			groupBox2.Location = new Point(258, 162);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(240, 125);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thức ăn";
			// 
			// chkMyCay
			// 
			chkMyCay.AutoSize = true;
			chkMyCay.Location = new Point(126, 55);
			chkMyCay.Name = "chkMyCay";
			chkMyCay.Size = new Size(81, 23);
			chkMyCay.TabIndex = 12;
			chkMyCay.Text = "Mỳ cay";
			chkMyCay.UseVisualStyleBackColor = true;
			chkMyCay.CheckedChanged += chkMyCay_CheckedChanged;
			// 
			// chkMyXaoBo
			// 
			chkMyXaoBo.AutoSize = true;
			chkMyXaoBo.Location = new Point(126, 26);
			chkMyXaoBo.Name = "chkMyXaoBo";
			chkMyXaoBo.Size = new Size(103, 23);
			chkMyXaoBo.TabIndex = 11;
			chkMyXaoBo.Text = "Mỳ xào bò";
			chkMyXaoBo.UseVisualStyleBackColor = true;
			chkMyXaoBo.CheckedChanged += chkMyXaoBo_CheckedChanged;
			// 
			// chkMyTomTrung
			// 
			chkMyTomTrung.AutoSize = true;
			chkMyTomTrung.Location = new Point(6, 84);
			chkMyTomTrung.Name = "chkMyTomTrung";
			chkMyTomTrung.Size = new Size(125, 23);
			chkMyTomTrung.TabIndex = 10;
			chkMyTomTrung.Text = "Mỳ tôm trứng";
			chkMyTomTrung.UseVisualStyleBackColor = true;
			chkMyTomTrung.CheckedChanged += chkMyTomTrung_CheckedChanged;
			// 
			// chkBanhMyCa
			// 
			chkBanhMyCa.AutoSize = true;
			chkBanhMyCa.Location = new Point(6, 55);
			chkBanhMyCa.Name = "chkBanhMyCa";
			chkBanhMyCa.Size = new Size(106, 23);
			chkBanhMyCa.TabIndex = 9;
			chkBanhMyCa.Text = "Bánh mì cá";
			chkBanhMyCa.UseVisualStyleBackColor = true;
			chkBanhMyCa.CheckedChanged += chkBanhMyCa_CheckedChanged;
			// 
			// chkBanhMyTrung
			// 
			chkBanhMyTrung.AutoSize = true;
			chkBanhMyTrung.Location = new Point(6, 26);
			chkBanhMyTrung.Name = "chkBanhMyTrung";
			chkBanhMyTrung.Size = new Size(127, 23);
			chkBanhMyTrung.TabIndex = 8;
			chkBanhMyTrung.Text = "Bánh mì trứng";
			chkBanhMyTrung.UseVisualStyleBackColor = true;
			chkBanhMyTrung.CheckedChanged += chkBanhMyTrung_CheckedChanged;
			// 
			// chkSinhVien
			// 
			chkSinhVien.AutoSize = true;
			chkSinhVien.Location = new Point(161, 133);
			chkSinhVien.Name = "chkSinhVien";
			chkSinhVien.Size = new Size(100, 23);
			chkSinhVien.TabIndex = 0;
			chkSinhVien.Text = "Sinh viên?";
			chkSinhVien.UseVisualStyleBackColor = true;
			chkSinhVien.CheckedChanged += chkSinhVien_CheckedChanged;
			// 
			// txtTongKhachHang
			// 
			txtTongKhachHang.Location = new Point(175, 346);
			txtTongKhachHang.Name = "txtTongKhachHang";
			txtTongKhachHang.Size = new Size(302, 27);
			txtTongKhachHang.TabIndex = 18;
			// 
			// txtTongTien
			// 
			txtTongTien.Location = new Point(175, 378);
			txtTongTien.Name = "txtTongTien";
			txtTongTien.Size = new Size(302, 27);
			txtTongTien.TabIndex = 19;
			// 
			// btnTinhTien
			// 
			btnTinhTien.Enabled = false;
			btnTinhTien.Location = new Point(42, 297);
			btnTinhTien.Name = "btnTinhTien";
			btnTinhTien.Size = new Size(94, 29);
			btnTinhTien.TabIndex = 20;
			btnTinhTien.Text = "Tính tiền";
			btnTinhTien.UseVisualStyleBackColor = true;
			btnTinhTien.Click += btnTinhTien_Click;
			// 
			// btnNhapLai
			// 
			btnNhapLai.Enabled = false;
			btnNhapLai.Location = new Point(149, 297);
			btnNhapLai.Name = "btnNhapLai";
			btnNhapLai.Size = new Size(94, 29);
			btnNhapLai.TabIndex = 21;
			btnNhapLai.Text = "Nhập lại";
			btnNhapLai.UseVisualStyleBackColor = true;
			btnNhapLai.Click += btnNhapLai_Click;
			// 
			// btnThanhToan
			// 
			btnThanhToan.Enabled = false;
			btnThanhToan.Location = new Point(258, 297);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(94, 29);
			btnThanhToan.TabIndex = 22;
			btnThanhToan.Text = "Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = true;
			btnThanhToan.Click += btnThanhToan_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(368, 297);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 23;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmBai1NC
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(510, 428);
			Controls.Add(btnThoat);
			Controls.Add(btnThanhToan);
			Controls.Add(btnNhapLai);
			Controls.Add(btnTinhTien);
			Controls.Add(txtTongTien);
			Controls.Add(txtTongKhachHang);
			Controls.Add(chkSinhVien);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(txtSoKhach);
			Controls.Add(txtTenKhach);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1NC";
			Text = "Thanh toán tiền";
			FormClosing += frmBai1NC_FormClosing;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtTenKhach;
		private TextBox txtSoKhach;
		private GroupBox groupBox1;
		private RadioButton rdoCafeSua;
		private RadioButton rdoCafeDen;
		private GroupBox groupBox2;
		private CheckBox chkMyCay;
		private CheckBox chkMyXaoBo;
		private CheckBox chkMyTomTrung;
		private CheckBox chkBanhMyCa;
		private CheckBox chkBanhMyTrung;
		private CheckBox chkSinhVien;
		private RadioButton rdoCafeKem;
		private RadioButton rdoCafeDa;
		private RadioButton rdoCafeSuaDa;
		private TextBox txtTongKhachHang;
		private TextBox txtTongTien;
		private Button btnTinhTien;
		private Button btnNhapLai;
		private Button btnThanhToan;
		private Button btnThoat;
	}
}