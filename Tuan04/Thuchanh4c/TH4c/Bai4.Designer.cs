namespace TH4c
{
	partial class frmBai4
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
			lblNhapSo = new Label();
			lblDayVuaNhap = new Label();
			lblTongCacPhanTu = new Label();
			lblTongChan = new Label();
			lblTongLe = new Label();
			txtNhapSo = new TextBox();
			txtDayVuaNhap = new TextBox();
			txtTongCacPhanTu = new TextBox();
			txtTongChan = new TextBox();
			txtTongLe = new TextBox();
			btnNhap = new Button();
			btnTiepTuc = new Button();
			btnThoat = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// lblTittle
			// 
			lblTittle.AutoSize = true;
			lblTittle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTittle.ForeColor = Color.Red;
			lblTittle.Location = new Point(39, 25);
			lblTittle.Name = "lblTittle";
			lblTittle.Size = new Size(314, 32);
			lblTittle.TabIndex = 0;
			lblTittle.Text = "Nhập dãy số và tính tổng";
			// 
			// lblNhapSo
			// 
			lblNhapSo.AutoSize = true;
			lblNhapSo.Location = new Point(26, 83);
			lblNhapSo.Name = "lblNhapSo";
			lblNhapSo.Size = new Size(64, 19);
			lblNhapSo.TabIndex = 1;
			lblNhapSo.Text = "Nhập số";
			// 
			// lblDayVuaNhap
			// 
			lblDayVuaNhap.AutoSize = true;
			lblDayVuaNhap.Location = new Point(26, 124);
			lblDayVuaNhap.Name = "lblDayVuaNhap";
			lblDayVuaNhap.Size = new Size(98, 19);
			lblDayVuaNhap.TabIndex = 2;
			lblDayVuaNhap.Text = "Dãy vừa nhập";
			// 
			// lblTongCacPhanTu
			// 
			lblTongCacPhanTu.AutoSize = true;
			lblTongCacPhanTu.Location = new Point(26, 157);
			lblTongCacPhanTu.Name = "lblTongCacPhanTu";
			lblTongCacPhanTu.Size = new Size(190, 19);
			lblTongCacPhanTu.TabIndex = 3;
			lblTongCacPhanTu.Text = "Tổng các phần tử trong dãy";
			// 
			// lblTongChan
			// 
			lblTongChan.AutoSize = true;
			lblTongChan.Location = new Point(26, 194);
			lblTongChan.Name = "lblTongChan";
			lblTongChan.Size = new Size(78, 19);
			lblTongChan.TabIndex = 4;
			lblTongChan.Text = "Tổng chẵn";
			// 
			// lblTongLe
			// 
			lblTongLe.AutoSize = true;
			lblTongLe.Location = new Point(203, 194);
			lblTongLe.Name = "lblTongLe";
			lblTongLe.Size = new Size(60, 19);
			lblTongLe.TabIndex = 5;
			lblTongLe.Text = "Tổng lẻ";
			// 
			// txtNhapSo
			// 
			txtNhapSo.Location = new Point(117, 80);
			txtNhapSo.Name = "txtNhapSo";
			txtNhapSo.Size = new Size(125, 27);
			txtNhapSo.TabIndex = 6;
			// 
			// txtDayVuaNhap
			// 
			txtDayVuaNhap.Location = new Point(130, 121);
			txtDayVuaNhap.Name = "txtDayVuaNhap";
			txtDayVuaNhap.ReadOnly = true;
			txtDayVuaNhap.Size = new Size(240, 27);
			txtDayVuaNhap.TabIndex = 7;
			// 
			// txtTongCacPhanTu
			// 
			txtTongCacPhanTu.Location = new Point(245, 157);
			txtTongCacPhanTu.Name = "txtTongCacPhanTu";
			txtTongCacPhanTu.ReadOnly = true;
			txtTongCacPhanTu.Size = new Size(125, 27);
			txtTongCacPhanTu.TabIndex = 8;
			// 
			// txtTongChan
			// 
			txtTongChan.Location = new Point(118, 191);
			txtTongChan.Name = "txtTongChan";
			txtTongChan.ReadOnly = true;
			txtTongChan.Size = new Size(79, 27);
			txtTongChan.TabIndex = 9;
			// 
			// txtTongLe
			// 
			txtTongLe.Location = new Point(269, 191);
			txtTongLe.Name = "txtTongLe";
			txtTongLe.ReadOnly = true;
			txtTongLe.Size = new Size(85, 27);
			txtTongLe.TabIndex = 10;
			// 
			// btnNhap
			// 
			btnNhap.Location = new Point(260, 80);
			btnNhap.Name = "btnNhap";
			btnNhap.Size = new Size(94, 29);
			btnNhap.TabIndex = 11;
			btnNhap.Text = "Nhập";
			btnNhap.UseVisualStyleBackColor = true;
			btnNhap.Click += btnNhap_Click;
			// 
			// btnTiepTuc
			// 
			btnTiepTuc.Location = new Point(82, 239);
			btnTiepTuc.Name = "btnTiepTuc";
			btnTiepTuc.Size = new Size(94, 29);
			btnTiepTuc.TabIndex = 12;
			btnTiepTuc.Text = "Tiếp tục";
			btnTiepTuc.UseVisualStyleBackColor = true;
			btnTiepTuc.Click += btnTiepTuc_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(203, 239);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 13;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmBai4
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(395, 280);
			Controls.Add(btnThoat);
			Controls.Add(btnTiepTuc);
			Controls.Add(btnNhap);
			Controls.Add(txtTongLe);
			Controls.Add(txtTongChan);
			Controls.Add(txtTongCacPhanTu);
			Controls.Add(txtDayVuaNhap);
			Controls.Add(txtNhapSo);
			Controls.Add(lblTongLe);
			Controls.Add(lblTongChan);
			Controls.Add(lblTongCacPhanTu);
			Controls.Add(lblDayVuaNhap);
			Controls.Add(lblNhapSo);
			Controls.Add(lblTittle);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai4";
			Text = "Dãy số và tính tổng";
			FormClosing += frmBai4_FormClosing;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTittle;
		private Label lblNhapSo;
		private Label lblDayVuaNhap;
		private Label lblTongCacPhanTu;
		private Label lblTongChan;
		private Label lblTongLe;
		private TextBox txtNhapSo;
		private TextBox txtDayVuaNhap;
		private TextBox txtTongCacPhanTu;
		private TextBox txtTongChan;
		private TextBox txtTongLe;
		private Button btnNhap;
		private Button btnTiepTuc;
		private Button btnThoat;
		private ErrorProvider errorProvider1;
	}
}