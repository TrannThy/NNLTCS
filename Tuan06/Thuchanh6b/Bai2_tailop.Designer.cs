namespace Thuchanh6b
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
			txtDiem = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			cmbSinhVien = new ComboBox();
			cmbMonHoc = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(68, 20);
			label1.TabIndex = 0;
			label1.Text = "Sinh viên";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 52);
			label2.Name = "label2";
			label2.Size = new Size(67, 20);
			label2.TabIndex = 1;
			label2.Text = "Môn học";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 90);
			label3.Name = "label3";
			label3.Size = new Size(45, 20);
			label3.TabIndex = 2;
			label3.Text = "Điểm";
			// 
			// txtDiem
			// 
			txtDiem.Location = new Point(94, 87);
			txtDiem.Name = "txtDiem";
			txtDiem.Size = new Size(259, 27);
			txtDiem.TabIndex = 5;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(23, 138);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 6;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(135, 138);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 7;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(259, 138);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 8;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// cmbSinhVien
			// 
			cmbSinhVien.FormattingEnabled = true;
			cmbSinhVien.Location = new Point(94, 6);
			cmbSinhVien.Name = "cmbSinhVien";
			cmbSinhVien.Size = new Size(259, 28);
			cmbSinhVien.TabIndex = 9;
			// 
			// cmbMonHoc
			// 
			cmbMonHoc.FormattingEnabled = true;
			cmbMonHoc.Location = new Point(94, 49);
			cmbMonHoc.Name = "cmbMonHoc";
			cmbMonHoc.Size = new Size(259, 28);
			cmbMonHoc.TabIndex = 10;
			// 
			// frmBai2_tailop
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(385, 179);
			Controls.Add(cmbMonHoc);
			Controls.Add(cmbSinhVien);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtDiem);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai2_tailop";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtDiem;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
		private ComboBox cmbSinhVien;
		private ComboBox cmbMonHoc;
	}
}