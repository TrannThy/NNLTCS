namespace Thuchanh5c
{
	partial class frmBai2_venha
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
			groupBox1 = new GroupBox();
			btnNhap = new Button();
			lstDanhSach = new ListBox();
			txtNhapSo = new TextBox();
			groupBox2 = new GroupBox();
			btnTong = new Button();
			btnXoaDauCuoi = new Button();
			btnChon = new Button();
			btnTang2 = new Button();
			btnBinhPhuong = new Button();
			btnChonChan = new Button();
			btnChonLe = new Button();
			btnKetThuc = new Button();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(255, 128, 0);
			label1.Location = new Point(233, 9);
			label1.Name = "label1";
			label1.Size = new Size(139, 32);
			label1.TabIndex = 0;
			label1.Text = "LISTBOX";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnNhap);
			groupBox1.Controls.Add(lstDanhSach);
			groupBox1.Controls.Add(txtNhapSo);
			groupBox1.Location = new Point(12, 44);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(259, 300);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Listbox";
			// 
			// btnNhap
			// 
			btnNhap.Location = new Point(6, 56);
			btnNhap.Name = "btnNhap";
			btnNhap.Size = new Size(247, 29);
			btnNhap.TabIndex = 2;
			btnNhap.Text = "&Nhập";
			btnNhap.UseVisualStyleBackColor = true;
			btnNhap.Click += btnNhap_Click;
			// 
			// lstDanhSach
			// 
			lstDanhSach.FormattingEnabled = true;
			lstDanhSach.ItemHeight = 19;
			lstDanhSach.Location = new Point(6, 89);
			lstDanhSach.Name = "lstDanhSach";
			lstDanhSach.SelectionMode = SelectionMode.MultiSimple;
			lstDanhSach.Size = new Size(247, 194);
			lstDanhSach.TabIndex = 1;
			// 
			// txtNhapSo
			// 
			txtNhapSo.Location = new Point(3, 23);
			txtNhapSo.Name = "txtNhapSo";
			txtNhapSo.Size = new Size(250, 27);
			txtNhapSo.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnTong);
			groupBox2.Controls.Add(btnXoaDauCuoi);
			groupBox2.Controls.Add(btnChon);
			groupBox2.Controls.Add(btnTang2);
			groupBox2.Controls.Add(btnBinhPhuong);
			groupBox2.Controls.Add(btnChonChan);
			groupBox2.Controls.Add(btnChonLe);
			groupBox2.Location = new Point(277, 44);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(298, 300);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Xử lý listbox";
			// 
			// btnTong
			// 
			btnTong.Location = new Point(6, 36);
			btnTong.Name = "btnTong";
			btnTong.Size = new Size(286, 29);
			btnTong.TabIndex = 3;
			btnTong.Text = "Tổng các phần tử trong list";
			btnTong.UseVisualStyleBackColor = true;
			btnTong.Click += btnTong_Click;
			// 
			// btnXoaDauCuoi
			// 
			btnXoaDauCuoi.Location = new Point(6, 69);
			btnXoaDauCuoi.Name = "btnXoaDauCuoi";
			btnXoaDauCuoi.Size = new Size(286, 29);
			btnXoaDauCuoi.TabIndex = 4;
			btnXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
			btnXoaDauCuoi.UseVisualStyleBackColor = true;
			btnXoaDauCuoi.Click += btnXoaDauCuoi_Click;
			// 
			// btnChon
			// 
			btnChon.Location = new Point(6, 104);
			btnChon.Name = "btnChon";
			btnChon.Size = new Size(286, 29);
			btnChon.TabIndex = 5;
			btnChon.Text = "Xóa phần tử đang chọn";
			btnChon.UseVisualStyleBackColor = true;
			btnChon.Click += btnChon_Click;
			// 
			// btnTang2
			// 
			btnTang2.Location = new Point(6, 140);
			btnTang2.Name = "btnTang2";
			btnTang2.Size = new Size(286, 29);
			btnTang2.TabIndex = 6;
			btnTang2.Text = "Tăng mỗi phần tử lên 2";
			btnTang2.UseVisualStyleBackColor = true;
			btnTang2.Click += btnTang2_Click;
			// 
			// btnBinhPhuong
			// 
			btnBinhPhuong.Location = new Point(6, 175);
			btnBinhPhuong.Name = "btnBinhPhuong";
			btnBinhPhuong.Size = new Size(286, 29);
			btnBinhPhuong.TabIndex = 7;
			btnBinhPhuong.Text = "Thay bằng bình phương";
			btnBinhPhuong.UseVisualStyleBackColor = true;
			btnBinhPhuong.Click += btnBinhPhuong_Click;
			// 
			// btnChonChan
			// 
			btnChonChan.Location = new Point(6, 210);
			btnChonChan.Name = "btnChonChan";
			btnChonChan.Size = new Size(286, 29);
			btnChonChan.TabIndex = 8;
			btnChonChan.Text = "Chọn số chẵn";
			btnChonChan.UseVisualStyleBackColor = true;
			btnChonChan.Click += btnChonChan_Click;
			// 
			// btnChonLe
			// 
			btnChonLe.Location = new Point(6, 245);
			btnChonLe.Name = "btnChonLe";
			btnChonLe.Size = new Size(286, 29);
			btnChonLe.TabIndex = 9;
			btnChonLe.Text = "Chọn số lẻ";
			btnChonLe.UseVisualStyleBackColor = true;
			btnChonLe.Click += btnChonLe_Click;
			// 
			// btnKetThuc
			// 
			btnKetThuc.Location = new Point(66, 350);
			btnKetThuc.Name = "btnKetThuc";
			btnKetThuc.Size = new Size(470, 29);
			btnKetThuc.TabIndex = 10;
			btnKetThuc.Text = "&Kết thúc";
			btnKetThuc.UseVisualStyleBackColor = true;
			btnKetThuc.Click += btnKetThuc_Click;
			// 
			// frmBai2_venha
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(587, 378);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(btnKetThuc);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2_venha";
			Text = "frmListBox";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Button btnNhap;
		private ListBox lstDanhSach;
		private TextBox txtNhapSo;
		private GroupBox groupBox2;
		private Button btnTong;
		private Button btnXoaDauCuoi;
		private Button btnChon;
		private Button btnTang2;
		private Button btnBinhPhuong;
		private Button btnChonChan;
		private Button btnChonLe;
		private Button btnKetThuc;
	}
}