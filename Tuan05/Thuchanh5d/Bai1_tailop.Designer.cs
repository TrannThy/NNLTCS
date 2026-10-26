namespace Thuchanh5d
{
	partial class frmBai1_tailop
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtMaSV = new TextBox();
			txtHoTen = new TextBox();
			rdoNam = new RadioButton();
			rdoNu = new RadioButton();
			chkAnh = new CheckBox();
			chkPhap = new CheckBox();
			chkHoa = new CheckBox();
			cboDanToc = new ComboBox();
			lstvSinhVien = new ListView();
			HoTen = new ColumnHeader();
			Mssv = new ColumnHeader();
			GioiTinh = new ColumnHeader();
			NgoaiNgu = new ColumnHeader();
			DanToc = new ColumnHeader();
			contextMenuStrip1 = new ContextMenuStrip(components);
			xóaToolStripMenuItem = new ToolStripMenuItem();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(50, 236);
			label1.Name = "label1";
			label1.Size = new Size(61, 20);
			label1.TabIndex = 0;
			label1.Text = "Dân tộc";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(50, 188);
			label2.Name = "label2";
			label2.Size = new Size(80, 20);
			label2.TabIndex = 1;
			label2.Text = "Ngoại ngữ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(50, 138);
			label3.Name = "label3";
			label3.Size = new Size(65, 20);
			label3.TabIndex = 2;
			label3.Text = "Giới tính";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(50, 95);
			label4.Name = "label4";
			label4.Size = new Size(91, 20);
			label4.TabIndex = 3;
			label4.Text = "Mã sinh viên";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(50, 54);
			label5.Name = "label5";
			label5.Size = new Size(73, 20);
			label5.TabIndex = 4;
			label5.Text = "Họ và tên";
			// 
			// txtMaSV
			// 
			txtMaSV.Location = new Point(146, 95);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(326, 27);
			txtMaSV.TabIndex = 5;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(146, 54);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(326, 27);
			txtHoTen.TabIndex = 6;
			// 
			// rdoNam
			// 
			rdoNam.AutoSize = true;
			rdoNam.Location = new Point(146, 138);
			rdoNam.Name = "rdoNam";
			rdoNam.Size = new Size(62, 24);
			rdoNam.TabIndex = 7;
			rdoNam.TabStop = true;
			rdoNam.Text = "Nam";
			rdoNam.UseVisualStyleBackColor = true;
			// 
			// rdoNu
			// 
			rdoNu.AutoSize = true;
			rdoNu.Location = new Point(355, 138);
			rdoNu.Name = "rdoNu";
			rdoNu.Size = new Size(50, 24);
			rdoNu.TabIndex = 8;
			rdoNu.TabStop = true;
			rdoNu.Text = "Nữ";
			rdoNu.UseVisualStyleBackColor = true;
			// 
			// chkAnh
			// 
			chkAnh.AutoSize = true;
			chkAnh.Location = new Point(146, 184);
			chkAnh.Name = "chkAnh";
			chkAnh.Size = new Size(57, 24);
			chkAnh.TabIndex = 9;
			chkAnh.Text = "Anh";
			chkAnh.UseVisualStyleBackColor = true;
			// 
			// chkPhap
			// 
			chkPhap.AutoSize = true;
			chkPhap.Location = new Point(264, 184);
			chkPhap.Name = "chkPhap";
			chkPhap.Size = new Size(64, 24);
			chkPhap.TabIndex = 10;
			chkPhap.Text = "Pháp";
			chkPhap.UseVisualStyleBackColor = true;
			// 
			// chkHoa
			// 
			chkHoa.AutoSize = true;
			chkHoa.Location = new Point(380, 184);
			chkHoa.Name = "chkHoa";
			chkHoa.Size = new Size(59, 24);
			chkHoa.TabIndex = 11;
			chkHoa.Text = "Hoa";
			chkHoa.UseVisualStyleBackColor = true;
			// 
			// cboDanToc
			// 
			cboDanToc.FormattingEnabled = true;
			cboDanToc.Location = new Point(146, 233);
			cboDanToc.Name = "cboDanToc";
			cboDanToc.Size = new Size(326, 28);
			cboDanToc.TabIndex = 12;
			// 
			// lstvSinhVien
			// 
			lstvSinhVien.Columns.AddRange(new ColumnHeader[] { HoTen, Mssv, GioiTinh, NgoaiNgu, DanToc });
			lstvSinhVien.ContextMenuStrip = contextMenuStrip1;
			lstvSinhVien.FullRowSelect = true;
			lstvSinhVien.GridLines = true;
			lstvSinhVien.Location = new Point(50, 276);
			lstvSinhVien.Name = "lstvSinhVien";
			lstvSinhVien.Size = new Size(422, 121);
			lstvSinhVien.TabIndex = 13;
			lstvSinhVien.UseCompatibleStateImageBehavior = false;
			lstvSinhVien.View = View.Details;
			lstvSinhVien.SelectedIndexChanged += lstvSinhVien_SelectedIndexChanged;
			// 
			// HoTen
			// 
			HoTen.Text = "Họ tên";
			HoTen.Width = 100;
			// 
			// Mssv
			// 
			Mssv.Text = "Mã sinh viên";
			Mssv.Width = 70;
			// 
			// GioiTinh
			// 
			GioiTinh.Text = "Giới tính";
			// 
			// NgoaiNgu
			// 
			NgoaiNgu.Text = "Ngoại ngữ";
			// 
			// DanToc
			// 
			DanToc.Text = "Dân tộc";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(211, 56);
			// 
			// xóaToolStripMenuItem
			// 
			xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
			xóaToolStripMenuItem.Size = new Size(210, 24);
			xóaToolStripMenuItem.Text = "Xóa";
			xóaToolStripMenuItem.Click += xóaToolStripMenuItem_Click;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(63, 409);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 14;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(210, 409);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 15;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(355, 409);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 16;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai1_tailop
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(511, 450);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(lstvSinhVien);
			Controls.Add(cboDanToc);
			Controls.Add(chkHoa);
			Controls.Add(chkPhap);
			Controls.Add(chkAnh);
			Controls.Add(rdoNu);
			Controls.Add(rdoNam);
			Controls.Add(txtHoTen);
			Controls.Add(txtMaSV);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai1_tailop";
			Text = "frmBai1_tailop";
			FormClosing += frmBai1_tailop_FormClosing;
			Load += frmBai1_tailop_Load;
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtMaSV;
		private TextBox txtHoTen;
		private RadioButton rdoNam;
		private RadioButton rdoNu;
		private CheckBox chkAnh;
		private CheckBox chkPhap;
		private CheckBox chkHoa;
		private ComboBox cboDanToc;
		private ListView lstvSinhVien;
		private ColumnHeader HoTen;
		private ColumnHeader Mssv;
		private ColumnHeader GioiTinh;
		private ColumnHeader NgoaiNgu;
		private ColumnHeader DanToc;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem xóaToolStripMenuItem;
	}
}