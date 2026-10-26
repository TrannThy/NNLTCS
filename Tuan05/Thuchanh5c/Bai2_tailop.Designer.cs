namespace Thuchanh5c
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
			trv_DanhSach = new TreeView();
			groupBox1 = new GroupBox();
			btnXoa = new Button();
			btnCapNhat = new Button();
			txtMaSV = new TextBox();
			txtDiaChi = new TextBox();
			txtHoTen = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			grpThemLop = new GroupBox();
			btnThemLop = new Button();
			txtTenLop = new TextBox();
			label1 = new Label();
			label6 = new Label();
			cboChonLop = new ComboBox();
			chkThemLop = new CheckBox();
			groupBox1.SuspendLayout();
			grpThemLop.SuspendLayout();
			SuspendLayout();
			// 
			// trv_DanhSach
			// 
			trv_DanhSach.Location = new Point(0, 0);
			trv_DanhSach.Name = "trv_DanhSach";
			trv_DanhSach.Size = new Size(339, 428);
			trv_DanhSach.TabIndex = 0;
			trv_DanhSach.AfterSelect += trv_DanhSach_AfterSelect;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnXoa);
			groupBox1.Controls.Add(btnCapNhat);
			groupBox1.Controls.Add(txtMaSV);
			groupBox1.Controls.Add(txtDiaChi);
			groupBox1.Controls.Add(txtHoTen);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label5);
			groupBox1.Location = new Point(345, 89);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(543, 222);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin sinh viên";
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(314, 163);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(104, 41);
			btnXoa.TabIndex = 10;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnCapNhat
			// 
			btnCapNhat.Location = new Point(150, 163);
			btnCapNhat.Name = "btnCapNhat";
			btnCapNhat.Size = new Size(135, 41);
			btnCapNhat.TabIndex = 11;
			btnCapNhat.Text = "Cập Nhật";
			btnCapNhat.UseVisualStyleBackColor = true;
			btnCapNhat.Click += btnCapNhat_Click;
			// 
			// txtMaSV
			// 
			txtMaSV.Location = new Point(88, 36);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(431, 27);
			txtMaSV.TabIndex = 7;
			// 
			// txtDiaChi
			// 
			txtDiaChi.Location = new Point(88, 130);
			txtDiaChi.Name = "txtDiaChi";
			txtDiaChi.Size = new Size(431, 27);
			txtDiaChi.TabIndex = 6;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(88, 86);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(431, 27);
			txtHoTen.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 134);
			label3.Name = "label3";
			label3.Size = new Size(58, 19);
			label3.TabIndex = 2;
			label3.Text = "Địa chỉ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(19, 89);
			label4.Name = "label4";
			label4.Size = new Size(55, 19);
			label4.TabIndex = 3;
			label4.Text = "Họ tên";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(19, 44);
			label5.Name = "label5";
			label5.Size = new Size(55, 19);
			label5.TabIndex = 4;
			label5.Text = "Mã SV";
			// 
			// grpThemLop
			// 
			grpThemLop.Controls.Add(btnThemLop);
			grpThemLop.Controls.Add(txtTenLop);
			grpThemLop.Controls.Add(label1);
			grpThemLop.Location = new Point(345, 346);
			grpThemLop.Name = "grpThemLop";
			grpThemLop.Size = new Size(543, 70);
			grpThemLop.TabIndex = 0;
			grpThemLop.TabStop = false;
			grpThemLop.Text = "Thông tin lớp";
			// 
			// btnThemLop
			// 
			btnThemLop.Location = new Point(425, 28);
			btnThemLop.Name = "btnThemLop";
			btnThemLop.Size = new Size(94, 29);
			btnThemLop.TabIndex = 9;
			btnThemLop.Text = "Thêm lớp";
			btnThemLop.UseVisualStyleBackColor = true;
			btnThemLop.Click += btnThemLop_Click;
			// 
			// txtTenLop
			// 
			txtTenLop.Location = new Point(88, 30);
			txtTenLop.Name = "txtTenLop";
			txtTenLop.Size = new Size(320, 27);
			txtTenLop.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(19, 33);
			label1.Name = "label1";
			label1.Size = new Size(60, 19);
			label1.TabIndex = 0;
			label1.Text = "Tên lớp";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(356, 40);
			label6.Name = "label6";
			label6.Size = new Size(71, 19);
			label6.TabIndex = 5;
			label6.Text = "Chọn lớp";
			// 
			// cboChonLop
			// 
			cboChonLop.FormattingEnabled = true;
			cboChonLop.Location = new Point(433, 32);
			cboChonLop.Name = "cboChonLop";
			cboChonLop.Size = new Size(431, 27);
			cboChonLop.TabIndex = 12;
			// 
			// chkThemLop
			// 
			chkThemLop.AutoSize = true;
			chkThemLop.Location = new Point(356, 317);
			chkThemLop.Name = "chkThemLop";
			chkThemLop.Size = new Size(95, 23);
			chkThemLop.TabIndex = 13;
			chkThemLop.Text = "Thêm lớp";
			chkThemLop.UseVisualStyleBackColor = true;
			chkThemLop.CheckedChanged += chkThemLop_CheckedChanged;
			// 
			// frmBai2_tailop
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(900, 428);
			Controls.Add(chkThemLop);
			Controls.Add(cboChonLop);
			Controls.Add(label6);
			Controls.Add(grpThemLop);
			Controls.Add(groupBox1);
			Controls.Add(trv_DanhSach);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2_tailop";
			Text = "Quản lý sinh viên";
			Load += frmBai2_tailop_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			grpThemLop.ResumeLayout(false);
			grpThemLop.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TreeView trv_DanhSach;
		private GroupBox groupBox1;
		private GroupBox grpThemLop;
		private Button btnXoa;
		private Button btnCapNhat;
		private TextBox txtMaSV;
		private TextBox txtDiaChi;
		private TextBox txtHoTen;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button btnThemLop;
		private TextBox txtTenLop;
		private Label label1;
		private Label label6;
		private ComboBox cboChonLop;
		private CheckBox chkThemLop;
	}
}