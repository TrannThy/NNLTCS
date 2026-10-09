namespace TH4d
{
	partial class frmBai2MSN
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
			btnNhapMang = new Button();
			lblKetQua = new Label();
			btnReset = new Button();
			btnThoat = new Button();
			btnThucHien = new Button();
			btnTong = new Button();
			btnTim = new Button();
			grpSapXep = new GroupBox();
			rdoSXGiam = new RadioButton();
			rdoSXTang = new RadioButton();
			grpTimKiem = new GroupBox();
			txtSoTimDuoc = new TextBox();
			txtTimViTri = new TextBox();
			lblTim = new Label();
			rdoTimViTri = new RadioButton();
			rdoTimGiaTri = new RadioButton();
			grpXoa = new GroupBox();
			txtXoaViTri = new TextBox();
			txtXoaGiaTri = new TextBox();
			label2 = new Label();
			rdoXoaViTri = new RadioButton();
			rdoXoaGiaTri = new RadioButton();
			grpThem = new GroupBox();
			txtThemTaiViTri = new TextBox();
			txtThemGiaTri = new TextBox();
			label4 = new Label();
			label3 = new Label();
			rdoThemGiaTri = new RadioButton();
			grpTong = new GroupBox();
			txtTongLe = new TextBox();
			txtTongChan = new TextBox();
			txtTongMang = new TextBox();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			rdoThayGiaTri = new RadioButton();
			rdoThayViTri = new RadioButton();
			grpMaxMin = new GroupBox();
			txtGTNN = new TextBox();
			txtGTLN = new TextBox();
			label9 = new Label();
			label8 = new Label();
			grpThayThe = new GroupBox();
			txtSoThayThe = new TextBox();
			txtThayViTri = new TextBox();
			txtThayGiaTri = new TextBox();
			label10 = new Label();
			txtNhapMang = new TextBox();
			txtKetQuaMang = new TextBox();
			txtTimGiaTri = new TextBox();
			grpSapXep.SuspendLayout();
			grpTimKiem.SuspendLayout();
			grpXoa.SuspendLayout();
			grpThem.SuspendLayout();
			grpTong.SuspendLayout();
			grpMaxMin.SuspendLayout();
			grpThayThe.SuspendLayout();
			SuspendLayout();
			// 
			// lblTittle
			// 
			lblTittle.AutoSize = true;
			lblTittle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTittle.ForeColor = Color.Red;
			lblTittle.Location = new Point(104, 18);
			lblTittle.Name = "lblTittle";
			lblTittle.Size = new Size(211, 32);
			lblTittle.TabIndex = 0;
			lblTittle.Text = "Mảng số nguyên";
			// 
			// btnNhapMang
			// 
			btnNhapMang.Location = new Point(28, 70);
			btnNhapMang.Name = "btnNhapMang";
			btnNhapMang.Size = new Size(94, 29);
			btnNhapMang.TabIndex = 1;
			btnNhapMang.Text = "Nhập mảng";
			btnNhapMang.UseVisualStyleBackColor = true;
			// 
			// lblKetQua
			// 
			lblKetQua.AutoSize = true;
			lblKetQua.Location = new Point(28, 107);
			lblKetQua.Name = "lblKetQua";
			lblKetQua.Size = new Size(101, 19);
			lblKetQua.TabIndex = 2;
			lblKetQua.Text = "Kết quả mảng";
			// 
			// btnReset
			// 
			btnReset.Location = new Point(335, 70);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(94, 29);
			btnReset.TabIndex = 3;
			btnReset.Text = "Reset";
			btnReset.UseVisualStyleBackColor = true;
			btnReset.Click += btnReset_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(335, 100);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 26);
			btnThoat.TabIndex = 4;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// btnThucHien
			// 
			btnThucHien.Location = new Point(28, 129);
			btnThucHien.Name = "btnThucHien";
			btnThucHien.Size = new Size(94, 42);
			btnThucHien.TabIndex = 5;
			btnThucHien.Text = "Thực hiện";
			btnThucHien.UseVisualStyleBackColor = true;
			btnThucHien.Click += btnThucHien_Click;
			// 
			// btnTong
			// 
			btnTong.Location = new Point(137, 16);
			btnTong.Name = "btnTong";
			btnTong.Size = new Size(54, 79);
			btnTong.TabIndex = 6;
			btnTong.Text = "Tổng";
			btnTong.UseVisualStyleBackColor = true;
			btnTong.Click += btnTong_Click;
			// 
			// btnTim
			// 
			btnTim.Location = new Point(133, 26);
			btnTim.Name = "btnTim";
			btnTim.Size = new Size(56, 79);
			btnTim.TabIndex = 7;
			btnTim.Text = "Tìm";
			btnTim.UseVisualStyleBackColor = true;
			btnTim.Click += btnTim_Click;
			// 
			// grpSapXep
			// 
			grpSapXep.Controls.Add(rdoSXGiam);
			grpSapXep.Controls.Add(rdoSXTang);
			grpSapXep.Location = new Point(128, 129);
			grpSapXep.Name = "grpSapXep";
			grpSapXep.Size = new Size(298, 42);
			grpSapXep.TabIndex = 8;
			grpSapXep.TabStop = false;
			grpSapXep.Text = "Sắp xếp";
			// 
			// rdoSXGiam
			// 
			rdoSXGiam.AutoSize = true;
			rdoSXGiam.Location = new Point(150, 16);
			rdoSXGiam.Name = "rdoSXGiam";
			rdoSXGiam.Size = new Size(119, 23);
			rdoSXGiam.TabIndex = 1;
			rdoSXGiam.TabStop = true;
			rdoSXGiam.Text = "Sắp xếp giảm";
			rdoSXGiam.UseVisualStyleBackColor = true;
			rdoSXGiam.CheckedChanged += rdoSXGiam_CheckedChanged;
			// 
			// rdoSXTang
			// 
			rdoSXTang.AutoSize = true;
			rdoSXTang.Location = new Point(6, 16);
			rdoSXTang.Name = "rdoSXTang";
			rdoSXTang.Size = new Size(114, 23);
			rdoSXTang.TabIndex = 0;
			rdoSXTang.TabStop = true;
			rdoSXTang.Text = "Sắp xếp tăng";
			rdoSXTang.UseVisualStyleBackColor = true;
			rdoSXTang.CheckedChanged += rdoSXTang_CheckedChanged;
			// 
			// grpTimKiem
			// 
			grpTimKiem.Controls.Add(txtSoTimDuoc);
			grpTimKiem.Controls.Add(txtTimViTri);
			grpTimKiem.Controls.Add(lblTim);
			grpTimKiem.Controls.Add(rdoTimViTri);
			grpTimKiem.Controls.Add(rdoTimGiaTri);
			grpTimKiem.Location = new Point(28, 177);
			grpTimKiem.Name = "grpTimKiem";
			grpTimKiem.Size = new Size(195, 112);
			grpTimKiem.TabIndex = 0;
			grpTimKiem.TabStop = false;
			grpTimKiem.Text = "Tìm kiếm";
			// 
			// txtSoTimDuoc
			// 
			txtSoTimDuoc.Enabled = false;
			txtSoTimDuoc.Location = new Point(149, 79);
			txtSoTimDuoc.Name = "txtSoTimDuoc";
			txtSoTimDuoc.ReadOnly = true;
			txtSoTimDuoc.Size = new Size(40, 27);
			txtSoTimDuoc.TabIndex = 23;
			txtSoTimDuoc.TextChanged += txtSoTimDuoc_TextChanged;
			// 
			// txtTimViTri
			// 
			txtTimViTri.Location = new Point(158, 51);
			txtTimViTri.Name = "txtTimViTri";
			txtTimViTri.Size = new Size(31, 27);
			txtTimViTri.TabIndex = 22;
			txtTimViTri.TextChanged += txtTimViTri_TextChanged;
			// 
			// lblTim
			// 
			lblTim.AutoSize = true;
			lblTim.Location = new Point(29, 81);
			lblTim.Name = "lblTim";
			lblTim.Size = new Size(114, 19);
			lblTim.TabIndex = 9;
			lblTim.Text = "Số tìm được là:";
			// 
			// rdoTimViTri
			// 
			rdoTimViTri.AutoSize = true;
			rdoTimViTri.Location = new Point(6, 55);
			rdoTimViTri.Name = "rdoTimViTri";
			rdoTimViTri.Size = new Size(147, 23);
			rdoTimViTri.TabIndex = 3;
			rdoTimViTri.TabStop = true;
			rdoTimViTri.Text = "Tìm vị trí cần tìm";
			rdoTimViTri.UseVisualStyleBackColor = true;
			rdoTimViTri.CheckedChanged += rdoTimViTri_CheckedChanged;
			// 
			// rdoTimGiaTri
			// 
			rdoTimGiaTri.AutoSize = true;
			rdoTimGiaTri.Location = new Point(6, 26);
			rdoTimGiaTri.Name = "rdoTimGiaTri";
			rdoTimGiaTri.Size = new Size(155, 23);
			rdoTimGiaTri.TabIndex = 2;
			rdoTimGiaTri.TabStop = true;
			rdoTimGiaTri.Text = "Tìm giá trị cần tìm";
			rdoTimGiaTri.UseVisualStyleBackColor = true;
			rdoTimGiaTri.CheckedChanged += rdoTimGiaTri_CheckedChanged;
			// 
			// grpXoa
			// 
			grpXoa.Controls.Add(txtXoaViTri);
			grpXoa.Controls.Add(txtXoaGiaTri);
			grpXoa.Controls.Add(label2);
			grpXoa.Controls.Add(rdoXoaViTri);
			grpXoa.Controls.Add(rdoXoaGiaTri);
			grpXoa.Location = new Point(229, 177);
			grpXoa.Name = "grpXoa";
			grpXoa.Size = new Size(197, 112);
			grpXoa.TabIndex = 0;
			grpXoa.TabStop = false;
			grpXoa.Text = "Xóa";
			// 
			// txtXoaViTri
			// 
			txtXoaViTri.Location = new Point(157, 54);
			txtXoaViTri.Name = "txtXoaViTri";
			txtXoaViTri.Size = new Size(34, 27);
			txtXoaViTri.TabIndex = 25;
			txtXoaViTri.TextChanged += txtXoaViTri_TextChanged;
			// 
			// txtXoaGiaTri
			// 
			txtXoaGiaTri.Location = new Point(157, 22);
			txtXoaGiaTri.Name = "txtXoaGiaTri";
			txtXoaGiaTri.Size = new Size(34, 27);
			txtXoaGiaTri.TabIndex = 24;
			txtXoaGiaTri.TextChanged += txtXoaGiaTri_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.Red;
			label2.Location = new Point(35, 81);
			label2.Name = "label2";
			label2.Size = new Size(121, 19);
			label2.TabIndex = 10;
			label2.Text = "Cần sắp xếp tăng";
			// 
			// rdoXoaViTri
			// 
			rdoXoaViTri.AutoSize = true;
			rdoXoaViTri.Location = new Point(6, 55);
			rdoXoaViTri.Name = "rdoXoaViTri";
			rdoXoaViTri.Size = new Size(148, 23);
			rdoXoaViTri.TabIndex = 5;
			rdoXoaViTri.TabStop = true;
			rdoXoaViTri.Text = "Tìm vị trí cần xóa";
			rdoXoaViTri.UseVisualStyleBackColor = true;
			rdoXoaViTri.CheckedChanged += rdoXoaViTri_CheckedChanged;
			// 
			// rdoXoaGiaTri
			// 
			rdoXoaGiaTri.AutoSize = true;
			rdoXoaGiaTri.Location = new Point(6, 26);
			rdoXoaGiaTri.Name = "rdoXoaGiaTri";
			rdoXoaGiaTri.Size = new Size(156, 23);
			rdoXoaGiaTri.TabIndex = 4;
			rdoXoaGiaTri.TabStop = true;
			rdoXoaGiaTri.Text = "Tìm giá trị cần xóa";
			rdoXoaGiaTri.UseVisualStyleBackColor = true;
			rdoXoaGiaTri.CheckedChanged += rdoXoaGiaTri_CheckedChanged;
			// 
			// grpThem
			// 
			grpThem.Controls.Add(txtThemTaiViTri);
			grpThem.Controls.Add(txtThemGiaTri);
			grpThem.Controls.Add(label4);
			grpThem.Controls.Add(label3);
			grpThem.Controls.Add(rdoThemGiaTri);
			grpThem.Location = new Point(28, 295);
			grpThem.Name = "grpThem";
			grpThem.Size = new Size(195, 110);
			grpThem.TabIndex = 9;
			grpThem.TabStop = false;
			grpThem.Text = "Thêm";
			// 
			// txtThemTaiViTri
			// 
			txtThemTaiViTri.Location = new Point(133, 55);
			txtThemTaiViTri.Name = "txtThemTaiViTri";
			txtThemTaiViTri.Size = new Size(56, 27);
			txtThemTaiViTri.TabIndex = 27;
			txtThemTaiViTri.TextChanged += txtThemTaiViTri_TextChanged;
			// 
			// txtThemGiaTri
			// 
			txtThemGiaTri.Location = new Point(158, 27);
			txtThemGiaTri.Name = "txtThemGiaTri";
			txtThemGiaTri.Size = new Size(31, 27);
			txtThemGiaTri.TabIndex = 26;
			txtThemGiaTri.TextChanged += txtThemGiaTri_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.Red;
			label4.Location = new Point(29, 88);
			label4.Name = "label4";
			label4.Size = new Size(121, 19);
			label4.TabIndex = 12;
			label4.Text = "Cần sắp xếp tăng";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(0, 52);
			label3.Name = "label3";
			label3.Size = new Size(136, 19);
			label3.TabIndex = 11;
			label3.Text = "Tại vị trí cần thêm:";
			// 
			// rdoThemGiaTri
			// 
			rdoThemGiaTri.AutoSize = true;
			rdoThemGiaTri.Location = new Point(0, 26);
			rdoThemGiaTri.Name = "rdoThemGiaTri";
			rdoThemGiaTri.Size = new Size(166, 23);
			rdoThemGiaTri.TabIndex = 6;
			rdoThemGiaTri.TabStop = true;
			rdoThemGiaTri.Text = "Tìm giá trị cần thêm";
			rdoThemGiaTri.UseVisualStyleBackColor = true;
			rdoThemGiaTri.CheckedChanged += rdoThemGiaTri_CheckedChanged;
			// 
			// grpTong
			// 
			grpTong.Controls.Add(txtTongLe);
			grpTong.Controls.Add(txtTongChan);
			grpTong.Controls.Add(txtTongMang);
			grpTong.Controls.Add(label7);
			grpTong.Controls.Add(label6);
			grpTong.Controls.Add(label5);
			grpTong.Controls.Add(btnTong);
			grpTong.Location = new Point(229, 295);
			grpTong.Name = "grpTong";
			grpTong.Size = new Size(197, 110);
			grpTong.TabIndex = 0;
			grpTong.TabStop = false;
			grpTong.Text = "Tổng";
			// 
			// txtTongLe
			// 
			txtTongLe.Enabled = false;
			txtTongLe.Location = new Point(70, 80);
			txtTongLe.Name = "txtTongLe";
			txtTongLe.ReadOnly = true;
			txtTongLe.Size = new Size(61, 27);
			txtTongLe.TabIndex = 30;
			txtTongLe.TextChanged += txtTongLe_TextChanged;
			// 
			// txtTongChan
			// 
			txtTongChan.Enabled = false;
			txtTongChan.Location = new Point(95, 52);
			txtTongChan.Name = "txtTongChan";
			txtTongChan.ReadOnly = true;
			txtTongChan.Size = new Size(36, 27);
			txtTongChan.TabIndex = 29;
			txtTongChan.TextChanged += txtTongChan_TextChanged;
			// 
			// txtTongMang
			// 
			txtTongMang.Enabled = false;
			txtTongMang.Location = new Point(95, 26);
			txtTongMang.Name = "txtTongMang";
			txtTongMang.ReadOnly = true;
			txtTongMang.Size = new Size(36, 27);
			txtTongMang.TabIndex = 28;
			txtTongMang.TextChanged += txtTongMang_TextChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 76);
			label7.Name = "label7";
			label7.Size = new Size(65, 19);
			label7.TabIndex = 15;
			label7.Text = "Tổng lẻ:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 49);
			label6.Name = "label6";
			label6.Size = new Size(83, 19);
			label6.TabIndex = 14;
			label6.Text = "Tổng chẵn:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 30);
			label5.Name = "label5";
			label5.Size = new Size(88, 19);
			label5.TabIndex = 13;
			label5.Text = "Tổng mảng:";
			// 
			// rdoThayGiaTri
			// 
			rdoThayGiaTri.AutoSize = true;
			rdoThayGiaTri.Location = new Point(12, 26);
			rdoThayGiaTri.Name = "rdoThayGiaTri";
			rdoThayGiaTri.Size = new Size(158, 23);
			rdoThayGiaTri.TabIndex = 8;
			rdoThayGiaTri.TabStop = true;
			rdoThayGiaTri.Text = "Giá trị cần thay thế";
			rdoThayGiaTri.UseVisualStyleBackColor = true;
			rdoThayGiaTri.CheckedChanged += rdoThayGiaTri_CheckedChanged;
			// 
			// rdoThayViTri
			// 
			rdoThayViTri.AutoSize = true;
			rdoThayViTri.Location = new Point(12, 55);
			rdoThayViTri.Name = "rdoThayViTri";
			rdoThayViTri.Size = new Size(150, 23);
			rdoThayViTri.TabIndex = 7;
			rdoThayViTri.TabStop = true;
			rdoThayViTri.Text = "Vị trí cần thay thế";
			rdoThayViTri.UseVisualStyleBackColor = true;
			rdoThayViTri.CheckedChanged += rdoThayViTri_CheckedChanged;
			// 
			// grpMaxMin
			// 
			grpMaxMin.Controls.Add(txtGTNN);
			grpMaxMin.Controls.Add(txtGTLN);
			grpMaxMin.Controls.Add(label9);
			grpMaxMin.Controls.Add(label8);
			grpMaxMin.Controls.Add(btnTim);
			grpMaxMin.Location = new Point(28, 421);
			grpMaxMin.Name = "grpMaxMin";
			grpMaxMin.Size = new Size(195, 115);
			grpMaxMin.TabIndex = 10;
			grpMaxMin.TabStop = false;
			grpMaxMin.Text = "Max - Min";
			// 
			// txtGTNN
			// 
			txtGTNN.Enabled = false;
			txtGTNN.Location = new Point(107, 70);
			txtGTNN.Name = "txtGTNN";
			txtGTNN.ReadOnly = true;
			txtGTNN.Size = new Size(29, 27);
			txtGTNN.TabIndex = 23;
			txtGTNN.TextChanged += txtGTNN_TextChanged;
			// 
			// txtGTLN
			// 
			txtGTLN.Enabled = false;
			txtGTLN.Location = new Point(107, 34);
			txtGTLN.Name = "txtGTLN";
			txtGTLN.ReadOnly = true;
			txtGTLN.Size = new Size(29, 27);
			txtGTLN.TabIndex = 22;
			txtGTLN.TextChanged += txtGTLN_TextChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(0, 73);
			label9.Name = "label9";
			label9.Size = new Size(119, 19);
			label9.TabIndex = 17;
			label9.Text = "Giá trị nhỏ nhất:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(0, 42);
			label8.Name = "label8";
			label8.Size = new Size(116, 19);
			label8.TabIndex = 16;
			label8.Text = "Giá trị lớn nhất:";
			// 
			// grpThayThe
			// 
			grpThayThe.Controls.Add(txtSoThayThe);
			grpThayThe.Controls.Add(txtThayViTri);
			grpThayThe.Controls.Add(txtThayGiaTri);
			grpThayThe.Controls.Add(label10);
			grpThayThe.Controls.Add(rdoThayGiaTri);
			grpThayThe.Controls.Add(rdoThayViTri);
			grpThayThe.Location = new Point(223, 421);
			grpThayThe.Name = "grpThayThe";
			grpThayThe.Size = new Size(206, 115);
			grpThayThe.TabIndex = 8;
			grpThayThe.TabStop = false;
			grpThayThe.Text = "Thay thế";
			// 
			// txtSoThayThe
			// 
			txtSoThayThe.Location = new Point(143, 83);
			txtSoThayThe.Name = "txtSoThayThe";
			txtSoThayThe.Size = new Size(54, 27);
			txtSoThayThe.TabIndex = 21;
			txtSoThayThe.TextChanged += txtSoThayThe_TextChanged;
			// 
			// txtThayViTri
			// 
			txtThayViTri.Location = new Point(163, 55);
			txtThayViTri.Name = "txtThayViTri";
			txtThayViTri.Size = new Size(34, 27);
			txtThayViTri.TabIndex = 20;
			txtThayViTri.TextChanged += txtThayViTri_TextChanged;
			// 
			// txtThayGiaTri
			// 
			txtThayGiaTri.Location = new Point(168, 22);
			txtThayGiaTri.Name = "txtThayGiaTri";
			txtThayGiaTri.Size = new Size(29, 27);
			txtThayGiaTri.TabIndex = 19;
			txtThayGiaTri.TextChanged += txtThayGiaTri_TextChanged;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(32, 86);
			label10.Name = "label10";
			label10.Size = new Size(105, 19);
			label10.TabIndex = 18;
			label10.Text = "Số thay thế là:";
			// 
			// txtNhapMang
			// 
			txtNhapMang.Location = new Point(134, 72);
			txtNhapMang.Name = "txtNhapMang";
			txtNhapMang.Size = new Size(189, 27);
			txtNhapMang.TabIndex = 19;
			txtNhapMang.TextChanged += txtNhapMang_TextChanged;
			// 
			// txtKetQuaMang
			// 
			txtKetQuaMang.Enabled = false;
			txtKetQuaMang.Location = new Point(135, 104);
			txtKetQuaMang.Name = "txtKetQuaMang";
			txtKetQuaMang.ReadOnly = true;
			txtKetQuaMang.Size = new Size(188, 27);
			txtKetQuaMang.TabIndex = 20;
			txtKetQuaMang.TextChanged += txtKetQuaMang_TextChanged;
			// 
			// txtTimGiaTri
			// 
			txtTimGiaTri.Location = new Point(186, 202);
			txtTimGiaTri.Name = "txtTimGiaTri";
			txtTimGiaTri.Size = new Size(31, 27);
			txtTimGiaTri.TabIndex = 21;
			txtTimGiaTri.TextChanged += txtTimGiaTri_TextChanged;
			// 
			// frmBai2MSN
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(438, 555);
			Controls.Add(txtTimGiaTri);
			Controls.Add(txtKetQuaMang);
			Controls.Add(txtNhapMang);
			Controls.Add(grpThayThe);
			Controls.Add(grpMaxMin);
			Controls.Add(grpTong);
			Controls.Add(grpThem);
			Controls.Add(grpXoa);
			Controls.Add(grpTimKiem);
			Controls.Add(grpSapXep);
			Controls.Add(btnThucHien);
			Controls.Add(btnThoat);
			Controls.Add(btnReset);
			Controls.Add(lblKetQua);
			Controls.Add(btnNhapMang);
			Controls.Add(lblTittle);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2MSN";
			Text = "Form1";
			FormClosing += frmBai2MSN_FormClosing;
			grpSapXep.ResumeLayout(false);
			grpSapXep.PerformLayout();
			grpTimKiem.ResumeLayout(false);
			grpTimKiem.PerformLayout();
			grpXoa.ResumeLayout(false);
			grpXoa.PerformLayout();
			grpThem.ResumeLayout(false);
			grpThem.PerformLayout();
			grpTong.ResumeLayout(false);
			grpTong.PerformLayout();
			grpMaxMin.ResumeLayout(false);
			grpMaxMin.PerformLayout();
			grpThayThe.ResumeLayout(false);
			grpThayThe.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTittle;
		private Button btnNhapMang;
		private Label lblKetQua;
		private Button btnReset;
		private Button btnThoat;
		private Button btnThucHien;
		private Button btnTong;
		private Button btnTim;
		private GroupBox grpSapXep;
		private GroupBox grpTimKiem;
		private GroupBox grpXoa;
		private GroupBox grpThem;
		private GroupBox grpTong;
		private RadioButton rdoSXGiam;
		private RadioButton rdoSXTang;
		private RadioButton rdoTimViTri;
		private RadioButton rdoTimGiaTri;
		private RadioButton rdoXoaGiaTri;
		private GroupBox grpMaxMin;
		private GroupBox grpThayThe;
		private Label lblTim;
		private Label label2;
		private RadioButton rdoXoaViTri;
		private RadioButton rdoThemGiaTri;
		private RadioButton rdoThayGiaTri;
		private RadioButton rdoThayViTri;
		private Label label4;
		private Label label3;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label9;
		private Label label8;
		private Label label10;
		private TextBox txtSoTimDuoc;
		private TextBox txtTimViTri;
		private TextBox txtXoaViTri;
		private TextBox txtXoaGiaTri;
		private TextBox txtThemTaiViTri;
		private TextBox txtThemGiaTri;
		private TextBox txtTongMang;
		private TextBox txtNhapMang;
		private TextBox txtKetQuaMang;
		private TextBox txtTimGiaTri;
		private TextBox txtTongLe;
		private TextBox txtTongChan;
		private TextBox txtSoThayThe;
		private TextBox txtThayViTri;
		private TextBox txtThayGiaTri;
		private TextBox txtGTNN;
		private TextBox txtGTLN;
	}
}