namespace Thuchanh5c
{
	partial class frmBai1_nangcao
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
			btnNgauNhien = new Button();
			btnXoaChon = new Button();
			btnThanhThuong = new Button();
			btnXoaSon = new Button();
			btnXoaLe = new Button();
			btnThanhHoa = new Button();
			btnVietHoaDauMoiTu = new Button();
			btnXoaTatCa = new Button();
			lstDanhSach = new ListBox();
			SuspendLayout();
			// 
			// btnNgauNhien
			// 
			btnNgauNhien.Location = new Point(49, 12);
			btnNgauNhien.Name = "btnNgauNhien";
			btnNgauNhien.Size = new Size(190, 29);
			btnNgauNhien.TabIndex = 0;
			btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
			btnNgauNhien.UseVisualStyleBackColor = true;
			btnNgauNhien.Click += btnNgauNhien_Click;
			// 
			// btnXoaChon
			// 
			btnXoaChon.Location = new Point(251, 50);
			btnXoaChon.Name = "btnXoaChon";
			btnXoaChon.Size = new Size(315, 29);
			btnXoaChon.TabIndex = 1;
			btnXoaChon.Text = "Xóa phần tử đang chọn";
			btnXoaChon.UseVisualStyleBackColor = true;
			btnXoaChon.Click += btnXoaChon_Click;
			// 
			// btnThanhThuong
			// 
			btnThanhThuong.Location = new Point(251, 190);
			btnThanhThuong.Name = "btnThanhThuong";
			btnThanhThuong.Size = new Size(315, 29);
			btnThanhThuong.TabIndex = 2;
			btnThanhThuong.Text = "Chuyển PT đang chọn thành chữ thường";
			btnThanhThuong.UseVisualStyleBackColor = true;
			btnThanhThuong.Click += btnThanhThuong_Click;
			// 
			// btnXoaSon
			// 
			btnXoaSon.Location = new Point(251, 85);
			btnXoaSon.Name = "btnXoaSon";
			btnXoaSon.Size = new Size(315, 29);
			btnXoaSon.TabIndex = 3;
			btnXoaSon.Text = "Xóa phần tử có tên là Sơn";
			btnXoaSon.UseVisualStyleBackColor = true;
			btnXoaSon.Click += btnXoaSon_Click;
			// 
			// btnXoaLe
			// 
			btnXoaLe.Location = new Point(251, 120);
			btnXoaLe.Name = "btnXoaLe";
			btnXoaLe.Size = new Size(315, 29);
			btnXoaLe.TabIndex = 4;
			btnXoaLe.Text = "Xóa phần tử có họ là Lê";
			btnXoaLe.UseVisualStyleBackColor = true;
			btnXoaLe.Click += btnXoaLe_Click;
			// 
			// btnThanhHoa
			// 
			btnThanhHoa.Location = new Point(251, 155);
			btnThanhHoa.Name = "btnThanhHoa";
			btnThanhHoa.Size = new Size(315, 29);
			btnThanhHoa.TabIndex = 5;
			btnThanhHoa.Text = "Chuyển PTđang chọn thành chữ Hoa";
			btnThanhHoa.UseVisualStyleBackColor = true;
			btnThanhHoa.Click += btnThanhHoa_Click;
			// 
			// btnVietHoaDauMoiTu
			// 
			btnVietHoaDauMoiTu.Location = new Point(251, 225);
			btnVietHoaDauMoiTu.Name = "btnVietHoaDauMoiTu";
			btnVietHoaDauMoiTu.Size = new Size(315, 48);
			btnVietHoaDauMoiTu.TabIndex = 6;
			btnVietHoaDauMoiTu.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ";
			btnVietHoaDauMoiTu.UseVisualStyleBackColor = true;
			btnVietHoaDauMoiTu.Click += btnVietHoaDauMoiTu_Click;
			// 
			// btnXoaTatCa
			// 
			btnXoaTatCa.Location = new Point(251, 277);
			btnXoaTatCa.Name = "btnXoaTatCa";
			btnXoaTatCa.Size = new Size(315, 29);
			btnXoaTatCa.TabIndex = 7;
			btnXoaTatCa.Text = "Xóa tất cả các phần tử";
			btnXoaTatCa.UseVisualStyleBackColor = true;
			btnXoaTatCa.Click += btnXoaTatCa_Click;
			// 
			// lstDanhSach
			// 
			lstDanhSach.FormattingEnabled = true;
			lstDanhSach.ItemHeight = 19;
			lstDanhSach.Location = new Point(49, 50);
			lstDanhSach.Name = "lstDanhSach";
			lstDanhSach.SelectionMode = SelectionMode.MultiSimple;
			lstDanhSach.Size = new Size(196, 251);
			lstDanhSach.TabIndex = 8;
			lstDanhSach.DoubleClick += lstDanhSach_DoubleClick;
			// 
			// frmBai1_nangcao
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 320);
			Controls.Add(lstDanhSach);
			Controls.Add(btnXoaTatCa);
			Controls.Add(btnVietHoaDauMoiTu);
			Controls.Add(btnThanhHoa);
			Controls.Add(btnXoaLe);
			Controls.Add(btnXoaSon);
			Controls.Add(btnThanhThuong);
			Controls.Add(btnXoaChon);
			Controls.Add(btnNgauNhien);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1_nangcao";
			Text = "frmChuoi";
			ResumeLayout(false);
		}

		#endregion

		private Button btnNgauNhien;
		private Button btnXoaChon;
		private Button btnThanhThuong;
		private Button btnXoaSon;
		private Button btnXoaLe;
		private Button btnThanhHoa;
		private Button btnVietHoaDauMoiTu;
		private Button btnXoaTatCa;
		private ListBox lstDanhSach;
	}
}