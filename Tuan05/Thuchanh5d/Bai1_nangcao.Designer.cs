namespace Thuchanh5d
{
	partial class frmBai1_nangcao
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
			mnuCapNhat = new ToolStripMenuItem();
			mnuNhapMoi = new ToolStripMenuItem();
			mnuSangB = new ToolStripMenuItem();
			mnuSangA = new ToolStripMenuItem();
			mnuXoa = new ToolStripMenuItem();
			mnuKetThuc = new ToolStripMenuItem();
			lstLopA = new ListBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			lstLopB = new ListBox();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuKetThuc });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(461, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// mnuCapNhat
			// 
			mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapMoi, mnuSangB, mnuSangA, mnuXoa });
			mnuCapNhat.Name = "mnuCapNhat";
			mnuCapNhat.Size = new Size(82, 24);
			mnuCapNhat.Text = "Cập nhật";
			// 
			// mnuNhapMoi
			// 
			mnuNhapMoi.Name = "mnuNhapMoi";
			mnuNhapMoi.Size = new Size(224, 26);
			mnuNhapMoi.Text = "Nhập học viên mới";
			mnuNhapMoi.Click += mnuNhapMoi_Click;
			// 
			// mnuSangB
			// 
			mnuSangB.Name = "mnuSangB";
			mnuSangB.Size = new Size(224, 26);
			mnuSangB.Text = "Chuyển sang lớp B";
			mnuSangB.Click += mnuSangB_Click;
			// 
			// mnuSangA
			// 
			mnuSangA.Name = "mnuSangA";
			mnuSangA.Size = new Size(224, 26);
			mnuSangA.Text = "Chuyển sang lớp A";
			mnuSangA.Click += mnuSangA_Click;
			// 
			// mnuXoa
			// 
			mnuXoa.Name = "mnuXoa";
			mnuXoa.Size = new Size(224, 26);
			mnuXoa.Text = "Xóa học viên";
			mnuXoa.Click += mnuXoa_Click;
			// 
			// mnuKetThuc
			// 
			mnuKetThuc.Name = "mnuKetThuc";
			mnuKetThuc.Size = new Size(77, 24);
			mnuKetThuc.Text = "Kết thúc";
			mnuKetThuc.Click += mnuKetThuc_Click;
			// 
			// lstLopA
			// 
			lstLopA.FormattingEnabled = true;
			lstLopA.Location = new Point(6, 26);
			lstLopA.Name = "lstLopA";
			lstLopA.SelectionMode = SelectionMode.MultiSimple;
			lstLopA.Size = new Size(197, 224);
			lstLopA.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(lstLopA);
			groupBox1.Location = new Point(12, 42);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(218, 258);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Lớp A";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(lstLopB);
			groupBox2.Location = new Point(236, 42);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(201, 258);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Lớp B";
			// 
			// lstLopB
			// 
			lstLopB.FormattingEnabled = true;
			lstLopB.Location = new Point(6, 26);
			lstLopB.Name = "lstLopB";
			lstLopB.SelectionMode = SelectionMode.MultiSimple;
			lstLopB.Size = new Size(189, 224);
			lstLopB.TabIndex = 2;
			// 
			// frmBai1_nangcao
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(461, 312);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "frmBai1_nangcao";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem mnuCapNhat;
		private ToolStripMenuItem mnuNhapMoi;
		private ToolStripMenuItem mnuSangB;
		private ToolStripMenuItem mnuSangA;
		private ToolStripMenuItem mnuXoa;
		private ToolStripMenuItem mnuKetThuc;
		private ListBox lstLopA;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private ListBox lstLopB;
	}
}