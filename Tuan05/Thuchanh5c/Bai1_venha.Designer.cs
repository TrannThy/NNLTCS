namespace Thuchanh5c
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			txtNghiaViet = new TextBox();
			lstTuAnh = new ListBox();
			cboTuAnh = new ComboBox();
			tabPage2 = new TabPage();
			txtNghiaAnh = new TextBox();
			lstTuViet = new ListBox();
			cboTuViet = new ComboBox();
			btnThoat = new Button();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(402, 426);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(txtNghiaViet);
			tabPage1.Controls.Add(lstTuAnh);
			tabPage1.Controls.Add(cboTuAnh);
			tabPage1.Location = new Point(4, 29);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(394, 393);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Anh - Việt";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// txtNghiaViet
			// 
			txtNghiaViet.Location = new Point(199, 40);
			txtNghiaViet.Multiline = true;
			txtNghiaViet.Name = "txtNghiaViet";
			txtNghiaViet.Size = new Size(180, 324);
			txtNghiaViet.TabIndex = 2;
			// 
			// lstTuAnh
			// 
			lstTuAnh.FormattingEnabled = true;
			lstTuAnh.Location = new Point(6, 40);
			lstTuAnh.Name = "lstTuAnh";
			lstTuAnh.Size = new Size(187, 324);
			lstTuAnh.TabIndex = 1;
			lstTuAnh.SelectedIndexChanged += lstTuAnh_SelectedIndexChanged;
			lstTuAnh.DoubleClick += lstTuAnh_DoubleClick;
			// 
			// cboTuAnh
			// 
			cboTuAnh.FormattingEnabled = true;
			cboTuAnh.Location = new Point(6, 6);
			cboTuAnh.Name = "cboTuAnh";
			cboTuAnh.Size = new Size(151, 28);
			cboTuAnh.TabIndex = 0;
			cboTuAnh.TextUpdate += cboTuAnh_TextUpdate;
			cboTuAnh.KeyDown += cboTuAnh_KeyDown;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(txtNghiaAnh);
			tabPage2.Controls.Add(lstTuViet);
			tabPage2.Controls.Add(cboTuViet);
			tabPage2.Location = new Point(4, 29);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(394, 393);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Việt - Anh";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtNghiaAnh
			// 
			txtNghiaAnh.Location = new Point(213, 40);
			txtNghiaAnh.Multiline = true;
			txtNghiaAnh.Name = "txtNghiaAnh";
			txtNghiaAnh.Size = new Size(175, 344);
			txtNghiaAnh.TabIndex = 2;
			// 
			// lstTuViet
			// 
			lstTuViet.FormattingEnabled = true;
			lstTuViet.Location = new Point(7, 40);
			lstTuViet.Name = "lstTuViet";
			lstTuViet.Size = new Size(200, 344);
			lstTuViet.TabIndex = 1;
			lstTuViet.SelectedIndexChanged += lstTuViet_SelectedIndexChanged;
			lstTuViet.DoubleClick += lstTuViet_DoubleClick;
			// 
			// cboTuViet
			// 
			cboTuViet.FormattingEnabled = true;
			cboTuViet.Location = new Point(6, 6);
			cboTuViet.Name = "cboTuViet";
			cboTuViet.Size = new Size(151, 28);
			cboTuViet.TabIndex = 0;
			cboTuViet.TextUpdate += cboTuViet_TextUpdate;
			cboTuViet.KeyDown += cboTuViet_KeyDown;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(301, 440);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "&Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmBai1_venha
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(426, 475);
			Controls.Add(btnThoat);
			Controls.Add(tabControl1);
			Name = "frmBai1_venha";
			Text = "Từ điển Anh - Việt, Việt  - Anh";
			Load += Bai1_venha_Load;
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private ListBox lstTuAnh;
		private ComboBox cboTuAnh;
		private TabPage tabPage2;
		private TextBox txtNghiaViet;
		private Button btnThoat;
		private TextBox txtNghiaAnh;
		private ListBox lstTuViet;
		private ComboBox cboTuViet;
	}
}