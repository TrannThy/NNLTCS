namespace Thuchanh6b
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			cmbMaLop = new ComboBox();
			txtMaSV = new TextBox();
			txtHoTen = new TextBox();
			txtNgaySinh = new MaskedTextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 18);
			label1.Name = "label1";
			label1.Size = new Size(34, 20);
			label1.TabIndex = 0;
			label1.Text = "Lớp";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 51);
			label2.Name = "label2";
			label2.Size = new Size(47, 20);
			label2.TabIndex = 1;
			label2.Text = "Mã sv";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(16, 85);
			label3.Name = "label3";
			label3.Size = new Size(54, 20);
			label3.TabIndex = 2;
			label3.Text = "Họ tên";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(16, 116);
			label4.Name = "label4";
			label4.Size = new Size(74, 20);
			label4.TabIndex = 3;
			label4.Text = "Ngày sinh";
			// 
			// cmbMaLop
			// 
			cmbMaLop.FormattingEnabled = true;
			cmbMaLop.Location = new Point(94, 18);
			cmbMaLop.Name = "cmbMaLop";
			cmbMaLop.Size = new Size(278, 28);
			cmbMaLop.TabIndex = 4;
			// 
			// txtMaSV
			// 
			txtMaSV.Location = new Point(94, 51);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(278, 27);
			txtMaSV.TabIndex = 5;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(94, 82);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(278, 27);
			txtHoTen.TabIndex = 6;
			// 
			// txtNgaySinh
			// 
			txtNgaySinh.Location = new Point(94, 115);
			txtNgaySinh.Mask = "00/00/0000";
			txtNgaySinh.Name = "txtNgaySinh";
			txtNgaySinh.Size = new Size(278, 27);
			txtNgaySinh.TabIndex = 7;
			txtNgaySinh.ValidatingType = typeof(DateTime);
			// 
			// btnThem
			// 
			btnThem.Location = new Point(39, 155);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 8;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(160, 155);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 9;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(278, 155);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 10;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai1_tailop
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(406, 196);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtNgaySinh);
			Controls.Add(txtHoTen);
			Controls.Add(txtMaSV);
			Controls.Add(cmbMaLop);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai1_tailop";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox cmbMaLop;
		private TextBox txtMaSV;
		private TextBox txtHoTen;
		private MaskedTextBox txtNgaySinh;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}