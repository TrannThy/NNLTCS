namespace Thuchanh6b
{
    partial class frmBai1_2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			txtMaKhoa = new TextBox();
			txtTenKhoa = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 31);
			label1.Name = "label1";
			label1.Size = new Size(66, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã khoa";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 73);
			label2.Name = "label2";
			label2.Size = new Size(68, 20);
			label2.TabIndex = 1;
			label2.Text = "Tên khoa";
			// 
			// txtMaKhoa
			// 
			txtMaKhoa.Location = new Point(102, 31);
			txtMaKhoa.Name = "txtMaKhoa";
			txtMaKhoa.Size = new Size(265, 27);
			txtMaKhoa.TabIndex = 2;
			// 
			// txtTenKhoa
			// 
			txtTenKhoa.Location = new Point(102, 70);
			txtTenKhoa.Name = "txtTenKhoa";
			txtTenKhoa.Size = new Size(265, 27);
			txtTenKhoa.TabIndex = 3;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(35, 140);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 4;
			btnThem.Text = "Them";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(149, 140);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 5;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(273, 140);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 6;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai1_2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(397, 196);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtTenKhoa);
			Controls.Add(txtMaKhoa);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai1_2";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtMaKhoa;
		private TextBox txtTenKhoa;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}
