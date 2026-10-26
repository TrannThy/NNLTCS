namespace Thuchanh5d
{
	partial class frmBai1_BTVN
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
			txtMaKhoa = new TextBox();
			txtMaLop = new TextBox();
			txtTenLop = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 9);
			label1.Name = "label1";
			label1.Size = new Size(66, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã khoa";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(31, 55);
			label2.Name = "label2";
			label2.Size = new Size(56, 20);
			label2.TabIndex = 1;
			label2.Text = "Mã lớp";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 104);
			label3.Name = "label3";
			label3.Size = new Size(58, 20);
			label3.TabIndex = 2;
			label3.Text = "Tên lớp";
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Location = new Point(123, 12);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(300, 27);
			txtMaKhoa.TabIndex = 3;
			// 
			// txtMaLop
			// 
			txtMaLop.Location = new Point(123, 55);
			txtMaLop.Name = "txtMaLop";
			txtMaLop.Size = new Size(300, 27);
			txtMaLop.TabIndex = 4;
			// 
			// txtTenLop
			// 
			txtTenLop.Location = new Point(123, 104);
			txtTenLop.Name = "txtTenLop";
			txtTenLop.Size = new Size(300, 27);
			txtTenLop.TabIndex = 5;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(48, 164);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 6;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(185, 164);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 7;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(329, 164);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 8;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai1_BTVN
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(446, 205);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtTenLop);
			Controls.Add(txtMaLop);
			Controls.Add(txtMaKhoa);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai1_BTVN";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtMaKhoa;
		private TextBox txtMaLop;
		private TextBox txtTenLop;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}