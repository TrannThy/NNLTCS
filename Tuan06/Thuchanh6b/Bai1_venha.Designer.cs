namespace Thuchanh6b
{
	partial class frmBai1_venha
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
			menuStrip1 = new MenuStrip();
			hệThốngToolStripMenuItem = new ToolStripMenuItem();
			tạoTồnKhoToolStripMenuItem = new ToolStripMenuItem();
			sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
			thêmSảnPhẩmMớiToolStripMenuItem = new ToolStripMenuItem();
			bánHàngToolStripMenuItem = new ToolStripMenuItem();
			btnTaoHoaDomMoi = new Button();
			groupBox1 = new GroupBox();
			btnHuy = new Button();
			btnThem = new Button();
			cmbMaSP = new ComboBox();
			txtSoLuong = new TextBox();
			txtMaHD = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnThanhToan = new Button();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, sảnPhẩmToolStripMenuItem, bánHàngToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(524, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoTồnKhoToolStripMenuItem });
			hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			hệThốngToolStripMenuItem.Size = new Size(85, 24);
			hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// tạoTồnKhoToolStripMenuItem
			// 
			tạoTồnKhoToolStripMenuItem.Name = "tạoTồnKhoToolStripMenuItem";
			tạoTồnKhoToolStripMenuItem.Size = new Size(171, 26);
			tạoTồnKhoToolStripMenuItem.Text = "Tạo tồn kho";
			tạoTồnKhoToolStripMenuItem.Click += tạoTồnKhoToolStripMenuItem_Click;
			// 
			// sảnPhẩmToolStripMenuItem
			// 
			sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmSảnPhẩmMớiToolStripMenuItem });
			sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
			sảnPhẩmToolStripMenuItem.Size = new Size(89, 24);
			sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
			// 
			// thêmSảnPhẩmMớiToolStripMenuItem
			// 
			thêmSảnPhẩmMớiToolStripMenuItem.Name = "thêmSảnPhẩmMớiToolStripMenuItem";
			thêmSảnPhẩmMớiToolStripMenuItem.Size = new Size(227, 26);
			thêmSảnPhẩmMớiToolStripMenuItem.Text = "Thêm sản phẩm mới";
			thêmSảnPhẩmMớiToolStripMenuItem.Click += thêmSảnPhẩmMớiToolStripMenuItem_Click;
			// 
			// bánHàngToolStripMenuItem
			// 
			bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
			bánHàngToolStripMenuItem.Size = new Size(85, 24);
			bánHàngToolStripMenuItem.Text = "Bán hàng";
			// 
			// btnTaoHoaDomMoi
			// 
			btnTaoHoaDomMoi.Location = new Point(328, 43);
			btnTaoHoaDomMoi.Name = "btnTaoHoaDomMoi";
			btnTaoHoaDomMoi.Size = new Size(158, 29);
			btnTaoHoaDomMoi.TabIndex = 1;
			btnTaoHoaDomMoi.Text = "Tạo hóa đơn mới";
			btnTaoHoaDomMoi.UseVisualStyleBackColor = true;
			btnTaoHoaDomMoi.Click += btnTaoHoaDomMoi_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnHuy);
			groupBox1.Controls.Add(btnThem);
			groupBox1.Controls.Add(cmbMaSP);
			groupBox1.Controls.Add(txtSoLuong);
			groupBox1.Controls.Add(txtMaHD);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(55, 95);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(431, 224);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Chi tiết hóa đơn";
			// 
			// btnHuy
			// 
			btnHuy.Location = new Point(331, 189);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(94, 29);
			btnHuy.TabIndex = 7;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(231, 189);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 6;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// cmbMaSP
			// 
			cmbMaSP.FormattingEnabled = true;
			cmbMaSP.Location = new Point(130, 87);
			cmbMaSP.Name = "cmbMaSP";
			cmbMaSP.Size = new Size(265, 28);
			cmbMaSP.TabIndex = 5;
			// 
			// txtSoLuong
			// 
			txtSoLuong.Location = new Point(130, 137);
			txtSoLuong.Name = "txtSoLuong";
			txtSoLuong.Size = new Size(265, 27);
			txtSoLuong.TabIndex = 4;
			// 
			// txtMaHD
			// 
			txtMaHD.Location = new Point(130, 40);
			txtMaHD.Name = "txtMaHD";
			txtMaHD.Size = new Size(265, 27);
			txtMaHD.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(26, 137);
			label3.Name = "label3";
			label3.Size = new Size(69, 20);
			label3.TabIndex = 2;
			label3.Text = "Số lượng";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(26, 87);
			label2.Name = "label2";
			label2.Size = new Size(98, 20);
			label2.TabIndex = 1;
			label2.Text = "Mã sản phẩm";
			label2.TextAlign = ContentAlignment.TopRight;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 40);
			label1.Name = "label1";
			label1.Size = new Size(89, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã hóa đơn";
			// 
			// btnThanhToan
			// 
			btnThanhToan.Location = new Point(392, 338);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(94, 29);
			btnThanhToan.TabIndex = 6;
			btnThanhToan.Text = "Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = true;
			btnThanhToan.Click += btnThanhToan_Click;
			// 
			// frmBai1_venha
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(524, 390);
			Controls.Add(btnThanhToan);
			Controls.Add(groupBox1);
			Controls.Add(btnTaoHoaDomMoi);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "frmBai1_venha";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem hệThốngToolStripMenuItem;
		private ToolStripMenuItem tạoTồnKhoToolStripMenuItem;
		private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
		private ToolStripMenuItem thêmSảnPhẩmMớiToolStripMenuItem;
		private ToolStripMenuItem bánHàngToolStripMenuItem;
		private Button btnTaoHoaDomMoi;
		private GroupBox groupBox1;
		private ComboBox cmbMaSP;
		private TextBox txtSoLuong;
		private TextBox txtMaHD;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnThanhToan;
		private Button btnHuy;
		private Button btnThem;
	}
}