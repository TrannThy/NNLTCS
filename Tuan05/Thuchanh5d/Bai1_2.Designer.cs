namespace Thuchanh5d
{
	partial class frmBai1_2
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
			txtTenKhoa = new TextBox();
			txtMaKhoa = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 49);
			label1.Name = "label1";
			label1.Size = new Size(70, 19);
			label1.TabIndex = 0;
			label1.Text = "Tên khoa";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(33, 87);
			label2.Name = "label2";
			label2.Size = new Size(67, 19);
			label2.TabIndex = 1;
			label2.Text = "Mã khoa";
			// 
			// txtTenKhoa
			// 
			txtTenKhoa.Location = new Point(121, 49);
			txtTenKhoa.Name = "txtTenKhoa";
			txtTenKhoa.Size = new Size(271, 27);
			txtTenKhoa.TabIndex = 2;
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Location = new Point(121, 79);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(271, 27);
			txtMaKhoa.TabIndex = 3;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(57, 131);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 4;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(177, 131);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 5;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(298, 131);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 6;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai1_2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(425, 188);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtMaKhoa);
			Controls.Add(txtTenKhoa);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1_2";
			Text = "Quản lý khoa";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtTenKhoa;
		private TextBox txtMaKhoa;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}