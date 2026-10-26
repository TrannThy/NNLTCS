namespace Thuchanh5d
{
	partial class frmBai2_tailop
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
			txtTenKhachHang = new TextBox();
			txtDiaChi = new TextBox();
			txtSoTien = new TextBox();
			txtSoTaiKhoan = new TextBox();
			btnThem = new Button();
			btnLuu = new Button();
			btnXoa = new Button();
			btnThoat = new Button();
			lstvTaiKhoan = new ListView();
			STT = new ColumnHeader();
			STK = new ColumnHeader();
			TenKhachHang = new ColumnHeader();
			DiaChi = new ColumnHeader();
			SoTien = new ColumnHeader();
			label6 = new Label();
			txtTongTien = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Blue;
			label1.Location = new Point(120, 21);
			label1.Name = "label1";
			label1.Size = new Size(474, 32);
			label1.TabIndex = 0;
			label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(117, 92);
			label2.Name = "label2";
			label2.Size = new Size(92, 19);
			label2.TabIndex = 1;
			label2.Text = "Số tài khoản";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(97, 131);
			label3.Name = "label3";
			label3.Size = new Size(112, 19);
			label3.TabIndex = 2;
			label3.Text = "Tên khách hàng";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(73, 172);
			label4.Name = "label4";
			label4.Size = new Size(136, 19);
			label4.TabIndex = 3;
			label4.Text = "Địa chỉ khách hàng";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(48, 216);
			label5.Name = "label5";
			label5.Size = new Size(162, 19);
			label5.TabIndex = 4;
			label5.Text = "Số tiền trong tài khoản";
			// 
			// txtTenKhachHang
			// 
			txtTenKhachHang.Location = new Point(216, 123);
			txtTenKhachHang.Name = "txtTenKhachHang";
			txtTenKhachHang.Size = new Size(434, 27);
			txtTenKhachHang.TabIndex = 5;
			// 
			// txtDiaChi
			// 
			txtDiaChi.Location = new Point(216, 164);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(434, 27);
			txtDiaChi.TabIndex = 6;
			// 
			// txtSoTien
			// 
			txtSoTien.Location = new Point(216, 208);
			txtSoTien.Name = "txtSoTien";
			txtSoTien.Size = new Size(434, 27);
			txtSoTien.TabIndex = 7;
			// 
			// txtSoTaiKhoan
			// 
			txtSoTaiKhoan.Location = new Point(216, 84);
			txtSoTaiKhoan.Name = "txtSoTaiKhoan";
			txtSoTaiKhoan.Size = new Size(434, 27);
			txtSoTaiKhoan.TabIndex = 8;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(256, 255);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 9;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnLuu
			// 
			btnLuu.Enabled = false;
			btnLuu.Location = new Point(356, 255);
			btnLuu.Name = "btnLuu";
			btnLuu.Size = new Size(94, 29);
			btnLuu.TabIndex = 10;
			btnLuu.Text = "Lưu";
			btnLuu.UseVisualStyleBackColor = true;
			btnLuu.Click += btnLuu_Click;
			// 
			// btnXoa
			// 
			btnXoa.Enabled = false;
			btnXoa.Location = new Point(456, 255);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 11;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(556, 255);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 12;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// lstvTaiKhoan
			// 
			lstvTaiKhoan.Columns.AddRange(new ColumnHeader[] { STT, STK, TenKhachHang, DiaChi, SoTien });
			lstvTaiKhoan.FullRowSelect = true;
			lstvTaiKhoan.GridLines = true;
			lstvTaiKhoan.Location = new Point(57, 295);
			lstvTaiKhoan.Name = "lstvTaiKhoan";
			lstvTaiKhoan.Size = new Size(593, 121);
			lstvTaiKhoan.TabIndex = 13;
			lstvTaiKhoan.UseCompatibleStateImageBehavior = false;
			lstvTaiKhoan.View = View.Details;
			lstvTaiKhoan.SelectedIndexChanged += lstvTaiKhoan_SelectedIndexChanged;
			// 
			// STT
			// 
			STT.Text = "STT";
			// 
			// STK
			// 
			STK.Text = "Số tài khoản";
			STK.Width = 100;
			// 
			// TenKhachHang
			// 
			TenKhachHang.Text = "Tên khách hàng";
			TenKhachHang.Width = 200;
			// 
			// DiaChi
			// 
			DiaChi.Text = "Địa chỉ";
			DiaChi.Width = 100;
			// 
			// SoTien
			// 
			SoTien.Text = "Số tiền";
			SoTien.Width = 120;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(396, 429);
			label6.Name = "label6";
			label6.Size = new Size(73, 19);
			label6.TabIndex = 14;
			label6.Text = "Tổng tiền";
			// 
			// txtTongTien
			// 
			txtTongTien.Enabled = false;
			txtTongTien.Location = new Point(484, 426);
			txtTongTien.Name = "txtTongTien";
			txtTongTien.Size = new Size(125, 27);
			txtTongTien.TabIndex = 15;
			// 
			// frmBai2_tailop
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(698, 471);
			Controls.Add(txtTongTien);
			Controls.Add(label6);
			Controls.Add(lstvTaiKhoan);
			Controls.Add(btnThoat);
			Controls.Add(btnXoa);
			Controls.Add(btnLuu);
			Controls.Add(btnThem);
			Controls.Add(txtSoTaiKhoan);
			Controls.Add(txtSoTien);
			Controls.Add(txtDiaChi);
			Controls.Add(txtTenKhachHang);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2_tailop";
			Text = "Form1";
			Load += frmBai2_tailop_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtTenKhachHang;
		private TextBox txtDiaChi;
		private TextBox txtSoTien;
		private TextBox txtSoTaiKhoan;
		private Button btnThem;
		private Button btnLuu;
		private Button btnXoa;
		private Button btnThoat;
		private ListView lstvTaiKhoan;
		private Label label6;
		private TextBox txtTongTien;
		private ColumnHeader STT;
		private ColumnHeader STK;
		private ColumnHeader TenKhachHang;
		private ColumnHeader DiaChi;
		private ColumnHeader SoTien;
	}
}