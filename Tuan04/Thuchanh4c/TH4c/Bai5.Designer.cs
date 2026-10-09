namespace TH4c
{
	partial class frmBai5
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
			btnThoat = new Button();
			btnXoa = new Button();
			btnThucHien = new Button();
			txtKetQua = new TextBox();
			txtNhapSo = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Red;
			label1.Location = new Point(87, 9);
			label1.Name = "label1";
			label1.Size = new Size(222, 32);
			label1.TabIndex = 0;
			label1.Text = "Đọc số thành chữ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 63);
			label2.Name = "label2";
			label2.Size = new Size(199, 19);
			label2.TabIndex = 1;
			label2.Text = "Nhập dãy số: (từ 1 đến 999)";
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(291, 112);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 2;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(171, 112);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 3;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnThucHien
			// 
			btnThucHien.Location = new Point(45, 112);
			btnThucHien.Name = "btnThucHien";
			btnThucHien.Size = new Size(94, 29);
			btnThucHien.TabIndex = 4;
			btnThucHien.Text = "Thực hiện";
			btnThucHien.UseVisualStyleBackColor = true;
			btnThucHien.Click += btnThucHien_Click;
			// 
			// txtKetQua
			// 
			txtKetQua.Location = new Point(45, 147);
			txtKetQua.Name = "txtKetQua";
			txtKetQua.ReadOnly = true;
			txtKetQua.Size = new Size(345, 27);
			txtKetQua.TabIndex = 5;
			txtKetQua.TextChanged += txtKetQua_TextChanged;
			// 
			// txtNhapSo
			// 
			txtNhapSo.Location = new Point(265, 60);
			txtNhapSo.Name = "txtNhapSo";
			txtNhapSo.Size = new Size(125, 27);
			txtNhapSo.TabIndex = 6;
			txtNhapSo.TextChanged += txtNhapSo_TextChanged;
			txtNhapSo.KeyPress += txtNhapSo_KeyPress;
			// 
			// frmBai5
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(430, 197);
			Controls.Add(txtNhapSo);
			Controls.Add(txtKetQua);
			Controls.Add(btnThucHien);
			Controls.Add(btnXoa);
			Controls.Add(btnThoat);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai5";
			Text = "Đọc chữ số";
			FormClosing += frmBai5_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button btnThoat;
		private Button btnXoa;
		private Button btnThucHien;
		private TextBox txtKetQua;
		private TextBox txtNhapSo;
	}
}