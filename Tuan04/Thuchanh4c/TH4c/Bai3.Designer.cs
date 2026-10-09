namespace TH4c
{
	partial class frmBai3
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
			lblA = new Label();
			lblB = new Label();
			txtA = new TextBox();
			txtB = new TextBox();
			lblUCLN = new Label();
			lblBCNN = new Label();
			txtUCLN = new TextBox();
			txtBCNN = new TextBox();
			btnThucHien = new Button();
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
			lblTittle.Location = new Point(12, 24);
			lblTittle.Name = "lblTittle";
			lblTittle.Size = new Size(362, 32);
			lblTittle.TabIndex = 0;
			lblTittle.Text = "Ước số chung  - Bội số chung";
			// 
			// lblA
			// 
			lblA.AutoSize = true;
			lblA.Location = new Point(24, 93);
			lblA.Name = "lblA";
			lblA.Size = new Size(80, 19);
			lblA.TabIndex = 1;
			lblA.Text = "Nhập số a:";
			// 
			// lblB
			// 
			lblB.AutoSize = true;
			lblB.Location = new Point(24, 139);
			lblB.Name = "lblB";
			lblB.Size = new Size(81, 19);
			lblB.TabIndex = 2;
			lblB.Text = "Nhập số b:";
			// 
			// txtA
			// 
			txtA.Location = new Point(110, 90);
			txtA.Name = "txtA";
			txtA.Size = new Size(214, 27);
			txtA.TabIndex = 3;
			// 
			// txtB
			// 
			txtB.Location = new Point(111, 136);
			txtB.Name = "txtB";
			txtB.Size = new Size(213, 27);
			txtB.TabIndex = 4;
			// 
			// lblUCLN
			// 
			lblUCLN.AutoSize = true;
			lblUCLN.Location = new Point(24, 189);
			lblUCLN.Name = "lblUCLN";
			lblUCLN.Size = new Size(146, 19);
			lblUCLN.TabIndex = 5;
			lblUCLN.Text = "Ước chung lớn nhất:";
			// 
			// lblBCNN
			// 
			lblBCNN.AutoSize = true;
			lblBCNN.Location = new Point(24, 235);
			lblBCNN.Name = "lblBCNN";
			lblBCNN.Size = new Size(149, 19);
			lblBCNN.TabIndex = 6;
			lblBCNN.Text = "Ước chung nhỏ nhất:";
			// 
			// txtUCLN
			// 
			txtUCLN.Location = new Point(201, 188);
			txtUCLN.Name = "txtUCLN";
			txtUCLN.ReadOnly = true;
			txtUCLN.Size = new Size(123, 27);
			txtUCLN.TabIndex = 7;
			// 
			// txtBCNN
			// 
			txtBCNN.Location = new Point(201, 232);
			txtBCNN.Name = "txtBCNN";
			txtBCNN.ReadOnly = true;
			txtBCNN.Size = new Size(123, 27);
			txtBCNN.TabIndex = 8;
			// 
			// btnThucHien
			// 
			btnThucHien.Location = new Point(31, 309);
			btnThucHien.Name = "btnThucHien";
			btnThucHien.Size = new Size(94, 29);
			btnThucHien.TabIndex = 9;
			btnThucHien.Text = "Thực hiện";
			btnThucHien.UseVisualStyleBackColor = true;
			btnThucHien.Click += btnThucHien_Click;
			// 
			// btnTiepTuc
			// 
			btnTiepTuc.Location = new Point(148, 309);
			btnTiepTuc.Name = "btnTiepTuc";
			btnTiepTuc.Size = new Size(94, 29);
			btnTiepTuc.TabIndex = 10;
			btnTiepTuc.Text = "Tiếp tục";
			btnTiepTuc.UseVisualStyleBackColor = true;
			btnTiepTuc.Click += btnTiepTuc_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(265, 309);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 11;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmBai3
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(386, 386);
			Controls.Add(btnThoat);
			Controls.Add(btnTiepTuc);
			Controls.Add(btnThucHien);
			Controls.Add(txtBCNN);
			Controls.Add(txtUCLN);
			Controls.Add(lblBCNN);
			Controls.Add(lblUCLN);
			Controls.Add(txtB);
			Controls.Add(txtA);
			Controls.Add(lblB);
			Controls.Add(lblA);
			Controls.Add(lblTittle);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai3";
			Text = "Ước số - Bội số";
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTittle;
		private Label lblA;
		private Label lblB;
		private TextBox txtA;
		private TextBox txtB;
		private Label lblUCLN;
		private Label lblBCNN;
		private TextBox txtUCLN;
		private TextBox txtBCNN;
		private Button btnThucHien;
		private Button btnTiepTuc;
		private Button btnThoat;
		private ErrorProvider errorProvider1;
	}
}