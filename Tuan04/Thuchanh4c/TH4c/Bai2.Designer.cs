namespace TH4c
{
	partial class frmBai2
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
			components = new System.ComponentModel.Container();
			lblTittle = new Label();
			lblTenDangNhap = new Label();
			lblEmail = new Label();
			lblMatKhau = new Label();
			lblXacNhanMK = new Label();
			txtTenDangNhap = new TextBox();
			txtMatKhau = new TextBox();
			txtEmail = new TextBox();
			txtXacNhanMK = new TextBox();
			btnDangKy = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// lblTittle
			// 
			lblTittle.AutoSize = true;
			lblTittle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTittle.ForeColor = Color.Blue;
			lblTittle.Location = new Point(151, 9);
			lblTittle.Name = "lblTittle";
			lblTittle.Size = new Size(234, 32);
			lblTittle.TabIndex = 0;
			lblTittle.Text = "Đăng ký tài khoản";
			// 
			// lblTenDangNhap
			// 
			lblTenDangNhap.AutoSize = true;
			lblTenDangNhap.Location = new Point(12, 71);
			lblTenDangNhap.Name = "lblTenDangNhap";
			lblTenDangNhap.Size = new Size(105, 19);
			lblTenDangNhap.TabIndex = 1;
			lblTenDangNhap.Text = "Tên đăng nhập";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(12, 109);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(100, 19);
			lblEmail.TabIndex = 2;
			lblEmail.Text = "Địa chỉ email";
			// 
			// lblMatKhau
			// 
			lblMatKhau.AutoSize = true;
			lblMatKhau.Location = new Point(12, 146);
			lblMatKhau.Name = "lblMatKhau";
			lblMatKhau.Size = new Size(71, 19);
			lblMatKhau.TabIndex = 3;
			lblMatKhau.Text = "Mật khẩu";
			// 
			// lblXacNhanMK
			// 
			lblXacNhanMK.AutoSize = true;
			lblXacNhanMK.Location = new Point(12, 181);
			lblXacNhanMK.Name = "lblXacNhanMK";
			lblXacNhanMK.Size = new Size(135, 19);
			lblXacNhanMK.TabIndex = 4;
			lblXacNhanMK.Text = "Xác nhận mật khẩu";
			// 
			// txtTenDangNhap
			// 
			txtTenDangNhap.Location = new Point(160, 63);
			txtTenDangNhap.Name = "txtTenDangNhap";
			txtTenDangNhap.Size = new Size(265, 27);
			txtTenDangNhap.TabIndex = 5;
			txtTenDangNhap.Validating += txtTenDangNhap_Validating;
			// 
			// txtMatKhau
			// 
			txtMatKhau.Location = new Point(160, 138);
			txtMatKhau.Name = "txtMatKhau";
			txtMatKhau.Size = new Size(265, 27);
			txtMatKhau.TabIndex = 6;
			txtMatKhau.Validating += txtMatKhau_Validating;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(160, 101);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(265, 27);
			txtEmail.TabIndex = 7;
			txtEmail.Validating += txtEmail_Validating;
			// 
			// txtXacNhanMK
			// 
			txtXacNhanMK.Location = new Point(160, 173);
			txtXacNhanMK.Name = "txtXacNhanMK";
			txtXacNhanMK.Size = new Size(265, 27);
			txtXacNhanMK.TabIndex = 8;
			txtXacNhanMK.KeyDown += txtXacNhanMK_KeyDown;
			// 
			// btnDangKy
			// 
			btnDangKy.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnDangKy.ForeColor = Color.Blue;
			btnDangKy.Location = new Point(210, 218);
			btnDangKy.Name = "btnDangKy";
			btnDangKy.Size = new Size(94, 29);
			btnDangKy.TabIndex = 9;
			btnDangKy.Text = "Đăng ký";
			btnDangKy.UseVisualStyleBackColor = true;
			btnDangKy.Click += btnDangKy_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmBai2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(530, 269);
			Controls.Add(btnDangKy);
			Controls.Add(txtXacNhanMK);
			Controls.Add(txtEmail);
			Controls.Add(txtMatKhau);
			Controls.Add(txtTenDangNhap);
			Controls.Add(lblXacNhanMK);
			Controls.Add(lblMatKhau);
			Controls.Add(lblEmail);
			Controls.Add(lblTenDangNhap);
			Controls.Add(lblTittle);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2";
			Text = "Đăng ký tài khoản";
			FormClosing += frmBai2_FormClosing;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTittle;
		private Label lblTenDangNhap;
		private Label lblEmail;
		private Label lblMatKhau;
		private Label lblXacNhanMK;
		private TextBox txtTenDangNhap;
		private TextBox txtMatKhau;
		private TextBox txtEmail;
		private TextBox txtXacNhanMK;
		private Button btnDangKy;
		private ErrorProvider errorProvider1;
	}
}