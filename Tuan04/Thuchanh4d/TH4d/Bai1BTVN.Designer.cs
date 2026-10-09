namespace TH4d
{
	partial class frmBai1BTVN
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
			label6 = new Label();
			label7 = new Label();
			groupBox1 = new GroupBox();
			rdoPhongBa = new RadioButton();
			rdoPhongDoi = new RadioButton();
			rdoPhongDon = new RadioButton();
			groupBox2 = new GroupBox();
			chkMayNuocNong = new CheckBox();
			chkInternet = new CheckBox();
			chkTivi = new CheckBox();
			groupBox3 = new GroupBox();
			chkAnSang = new CheckBox();
			chkKaraoke = new CheckBox();
			groupBox4 = new GroupBox();
			txtTongSoTien = new TextBox();
			txtSoLuotNguoi = new TextBox();
			txtHoTen = new TextBox();
			txtDiaChi = new TextBox();
			txtSoNgay = new TextBox();
			txtThanhTien = new TextBox();
			btnTongKet = new Button();
			btnThanhToan = new Button();
			btnNhapMoi = new Button();
			btnThoat = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox4.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(192, 64, 0);
			label1.Location = new Point(120, 9);
			label1.Name = "label1";
			label1.Size = new Size(591, 32);
			label1.TabIndex = 0;
			label1.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(40, 78);
			label2.Name = "label2";
			label2.Size = new Size(78, 19);
			label2.TabIndex = 1;
			label2.Text = "Họ và tên:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(40, 108);
			label3.Name = "label3";
			label3.Size = new Size(58, 19);
			label3.TabIndex = 2;
			label3.Text = "Dịa chỉ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(40, 139);
			label4.Name = "label4";
			label4.Size = new Size(75, 19);
			label4.TabIndex = 3;
			label4.Text = "Số ngày ở";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(518, 108);
			label5.Name = "label5";
			label5.Size = new Size(79, 19);
			label5.TabIndex = 4;
			label5.Text = "Thành tiền";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(16, 66);
			label6.Name = "label6";
			label6.Size = new Size(93, 19);
			label6.TabIndex = 5;
			label6.Text = "Tổng số tiền";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(16, 33);
			label7.Name = "label7";
			label7.Size = new Size(107, 19);
			label7.TabIndex = 6;
			label7.Text = "Số lượt người:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rdoPhongBa);
			groupBox1.Controls.Add(rdoPhongDoi);
			groupBox1.Controls.Add(rdoPhongDon);
			groupBox1.Location = new Point(40, 184);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(140, 132);
			groupBox1.TabIndex = 7;
			groupBox1.TabStop = false;
			groupBox1.Text = "Loại phòng";
			// 
			// rdoPhongBa
			// 
			rdoPhongBa.AutoSize = true;
			rdoPhongBa.Location = new Point(0, 92);
			rdoPhongBa.Name = "rdoPhongBa";
			rdoPhongBa.Size = new Size(92, 23);
			rdoPhongBa.TabIndex = 2;
			rdoPhongBa.TabStop = true;
			rdoPhongBa.Text = "Phòng ba";
			rdoPhongBa.UseVisualStyleBackColor = true;
			rdoPhongBa.CheckedChanged += rdoPhongBa_CheckedChanged;
			// 
			// rdoPhongDoi
			// 
			rdoPhongDoi.AutoSize = true;
			rdoPhongDoi.Location = new Point(0, 62);
			rdoPhongDoi.Name = "rdoPhongDoi";
			rdoPhongDoi.Size = new Size(100, 23);
			rdoPhongDoi.TabIndex = 1;
			rdoPhongDoi.TabStop = true;
			rdoPhongDoi.Text = "Phòng đôi";
			rdoPhongDoi.UseVisualStyleBackColor = true;
			rdoPhongDoi.CheckedChanged += rdoPhongDoi_CheckedChanged;
			// 
			// rdoPhongDon
			// 
			rdoPhongDon.AutoSize = true;
			rdoPhongDon.Location = new Point(0, 33);
			rdoPhongDon.Name = "rdoPhongDon";
			rdoPhongDon.Size = new Size(103, 23);
			rdoPhongDon.TabIndex = 0;
			rdoPhongDon.TabStop = true;
			rdoPhongDon.Text = "Phòng đơn";
			rdoPhongDon.UseVisualStyleBackColor = true;
			rdoPhongDon.CheckedChanged += rdoPhongDon_CheckedChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(chkMayNuocNong);
			groupBox2.Controls.Add(chkInternet);
			groupBox2.Controls.Add(chkTivi);
			groupBox2.Location = new Point(186, 184);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(146, 132);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Tiện nghi";
			// 
			// chkMayNuocNong
			// 
			chkMayNuocNong.AutoSize = true;
			chkMayNuocNong.Location = new Point(6, 93);
			chkMayNuocNong.Name = "chkMayNuocNong";
			chkMayNuocNong.Size = new Size(136, 23);
			chkMayNuocNong.TabIndex = 5;
			chkMayNuocNong.Text = "Máy nước nóng";
			chkMayNuocNong.UseVisualStyleBackColor = true;
			chkMayNuocNong.CheckedChanged += chkMayNuocNong_CheckedChanged;
			// 
			// chkInternet
			// 
			chkInternet.AutoSize = true;
			chkInternet.Location = new Point(6, 62);
			chkInternet.Name = "chkInternet";
			chkInternet.Size = new Size(84, 23);
			chkInternet.TabIndex = 4;
			chkInternet.Text = "Internet";
			chkInternet.UseVisualStyleBackColor = true;
			chkInternet.CheckedChanged += chkInternet_CheckedChanged;
			// 
			// chkTivi
			// 
			chkTivi.AutoSize = true;
			chkTivi.Location = new Point(6, 30);
			chkTivi.Name = "chkTivi";
			chkTivi.Size = new Size(56, 23);
			chkTivi.TabIndex = 3;
			chkTivi.Text = "Tivi";
			chkTivi.UseVisualStyleBackColor = true;
			chkTivi.CheckedChanged += chkTivi_CheckedChanged;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(chkAnSang);
			groupBox3.Controls.Add(chkKaraoke);
			groupBox3.Location = new Point(338, 184);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(137, 132);
			groupBox3.TabIndex = 0;
			groupBox3.TabStop = false;
			groupBox3.Text = "Dịch vụ";
			// 
			// chkAnSang
			// 
			chkAnSang.AutoSize = true;
			chkAnSang.Location = new Point(6, 92);
			chkAnSang.Name = "chkAnSang";
			chkAnSang.Size = new Size(84, 23);
			chkAnSang.TabIndex = 7;
			chkAnSang.Text = "Ăn sáng";
			chkAnSang.UseVisualStyleBackColor = true;
			chkAnSang.CheckedChanged += chkAnSang_CheckedChanged;
			// 
			// chkKaraoke
			// 
			chkKaraoke.AutoSize = true;
			chkKaraoke.Location = new Point(6, 62);
			chkKaraoke.Name = "chkKaraoke";
			chkKaraoke.Size = new Size(88, 23);
			chkKaraoke.TabIndex = 6;
			chkKaraoke.Text = "Karaoke";
			chkKaraoke.UseVisualStyleBackColor = true;
			chkKaraoke.CheckedChanged += chkKaraoke_CheckedChanged;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(txtTongSoTien);
			groupBox4.Controls.Add(txtSoLuotNguoi);
			groupBox4.Controls.Add(label7);
			groupBox4.Controls.Add(label6);
			groupBox4.Location = new Point(502, 184);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(318, 115);
			groupBox4.TabIndex = 8;
			groupBox4.TabStop = false;
			groupBox4.Text = "Thông tin tổng kết";
			// 
			// txtTongSoTien
			// 
			txtTongSoTien.Location = new Point(120, 63);
			txtTongSoTien.Name = "txtTongSoTien";
			txtTongSoTien.ReadOnly = true;
			txtTongSoTien.Size = new Size(180, 27);
			txtTongSoTien.TabIndex = 14;
			// 
			// txtSoLuotNguoi
			// 
			txtSoLuotNguoi.Location = new Point(120, 26);
			txtSoLuotNguoi.Name = "txtSoLuotNguoi";
			txtSoLuotNguoi.ReadOnly = true;
			txtSoLuotNguoi.Size = new Size(180, 27);
			txtSoLuotNguoi.TabIndex = 13;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(120, 78);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(196, 27);
			txtHoTen.TabIndex = 9;
			txtHoTen.TextChanged += txtHoTen_TextChanged;
			// 
			// txtDiaChi
			// 
			txtDiaChi.Location = new Point(120, 105);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(278, 27);
			txtDiaChi.TabIndex = 10;
			txtDiaChi.TextChanged += txtDiaChi_TextChanged;
			// 
			// txtSoNgay
			// 
			txtSoNgay.Location = new Point(120, 131);
			txtSoNgay.Name = "txtSoNgay";
			txtSoNgay.Size = new Size(117, 27);
			txtSoNgay.TabIndex = 11;
			txtSoNgay.TextChanged += txtSoNgay_TextChanged;
			txtSoNgay.KeyPress += txtSoNgay_KeyPress;
			// 
			// txtThanhTien
			// 
			txtThanhTien.Location = new Point(602, 105);
			txtThanhTien.Name = "txtThanhTien";
			txtThanhTien.ReadOnly = true;
			txtThanhTien.Size = new Size(218, 27);
			txtThanhTien.TabIndex = 12;
			// 
			// btnTongKet
			// 
			btnTongKet.Enabled = false;
			btnTongKet.Location = new Point(518, 149);
			btnTongKet.Name = "btnTongKet";
			btnTongKet.Size = new Size(94, 29);
			btnTongKet.TabIndex = 15;
			btnTongKet.Text = "Tổng &Kết";
			btnTongKet.UseVisualStyleBackColor = true;
			btnTongKet.Click += btnTongKet_Click;
			// 
			// btnThanhToan
			// 
			btnThanhToan.Enabled = false;
			btnThanhToan.Location = new Point(518, 68);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(94, 29);
			btnThanhToan.TabIndex = 16;
			btnThanhToan.Text = "&Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = true;
			btnThanhToan.Click += btnThanhToan_Click;
			// 
			// btnNhapMoi
			// 
			btnNhapMoi.Enabled = false;
			btnNhapMoi.Location = new Point(631, 68);
			btnNhapMoi.Name = "btnNhapMoi";
			btnNhapMoi.Size = new Size(94, 29);
			btnNhapMoi.TabIndex = 17;
			btnNhapMoi.Text = "&Nhập mới";
			btnNhapMoi.UseVisualStyleBackColor = true;
			btnNhapMoi.Click += btnNhapMoi_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(502, 305);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 18;
			btnThoat.Text = "Th&oát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmBai1BTVN
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(832, 338);
			Controls.Add(btnThoat);
			Controls.Add(btnNhapMoi);
			Controls.Add(btnThanhToan);
			Controls.Add(btnTongKet);
			Controls.Add(txtThanhTien);
			Controls.Add(txtSoNgay);
			Controls.Add(txtDiaChi);
			Controls.Add(txtHoTen);
			Controls.Add(groupBox4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1BTVN";
			Text = "frmDangKyKS";
			FormClosing += frmBai1BTVN_FormClosing;
			Load += frmBai1BTVN_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private TextBox txtHoTen;
		private TextBox txtDiaChi;
		private TextBox txtSoNgay;
		private TextBox txtThanhTien;
		private RadioButton rdoPhongBa;
		private RadioButton rdoPhongDoi;
		private RadioButton rdoPhongDon;
		private CheckBox chkMayNuocNong;
		private CheckBox chkInternet;
		private CheckBox chkTivi;
		private CheckBox chkAnSang;
		private CheckBox chkKaraoke;
		private TextBox txtTongSoTien;
		private TextBox txtSoLuotNguoi;
		private Button btnTongKet;
		private Button btnThanhToan;
		private Button btnNhapMoi;
		private Button btnThoat;
	}
}