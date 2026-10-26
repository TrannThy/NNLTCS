namespace Thuchanh5c
{
	partial class frmTreeView
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
			groupBox1 = new GroupBox();
			trv_DS = new TreeView();
			btn_XoaPB = new Button();
			btn_ThemPB = new Button();
			txt_phongban = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label6 = new Label();
			txt_maso = new TextBox();
			txt_diachi = new TextBox();
			txt_hoten = new TextBox();
			btn_ThemNV = new Button();
			btn_Thoat = new Button();
			cbo_phongban = new ComboBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(trv_DS);
			groupBox1.Controls.Add(btn_XoaPB);
			groupBox1.Controls.Add(btn_ThemPB);
			groupBox1.Controls.Add(txt_phongban);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(1, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(312, 438);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Phòng ban";
			// 
			// trv_DS
			// 
			trv_DS.Location = new Point(6, 27);
			trv_DS.Name = "trv_DS";
			trv_DS.Size = new Size(300, 264);
			trv_DS.TabIndex = 14;
			// 
			// btn_XoaPB
			// 
			btn_XoaPB.Location = new Point(127, 374);
			btn_XoaPB.Name = "btn_XoaPB";
			btn_XoaPB.Size = new Size(157, 31);
			btn_XoaPB.TabIndex = 13;
			btn_XoaPB.Text = "Xóa phòng ban";
			btn_XoaPB.UseVisualStyleBackColor = true;
			btn_XoaPB.Click += btn_XoaPB_Click;
			// 
			// btn_ThemPB
			// 
			btn_ThemPB.Location = new Point(127, 337);
			btn_ThemPB.Name = "btn_ThemPB";
			btn_ThemPB.Size = new Size(157, 31);
			btn_ThemPB.TabIndex = 14;
			btn_ThemPB.Text = "Thêm phòng ban";
			btn_ThemPB.UseVisualStyleBackColor = true;
			btn_ThemPB.Click += btn_ThemPB_Click;
			// 
			// txt_phongban
			// 
			txt_phongban.Location = new Point(127, 297);
			txt_phongban.Name = "txt_phongban";
			txt_phongban.Size = new Size(156, 27);
			txt_phongban.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 305);
			label1.Name = "label1";
			label1.Size = new Size(86, 19);
			label1.TabIndex = 1;
			label1.Text = "Phòng ban";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(341, 39);
			label2.Name = "label2";
			label2.Size = new Size(54, 20);
			label2.TabIndex = 2;
			label2.Text = "Mã số";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(341, 81);
			label3.Name = "label3";
			label3.Size = new Size(60, 20);
			label3.TabIndex = 3;
			label3.Text = "Địa chỉ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(490, 39);
			label4.Name = "label4";
			label4.Size = new Size(58, 20);
			label4.TabIndex = 4;
			label4.Text = "Họ tên";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(341, 120);
			label6.Name = "label6";
			label6.Size = new Size(86, 20);
			label6.TabIndex = 6;
			label6.Text = "Phòng ban";
			// 
			// txt_maso
			// 
			txt_maso.Location = new Point(404, 36);
			txt_maso.Name = "txt_maso";
			txt_maso.Size = new Size(76, 28);
			txt_maso.TabIndex = 7;
			// 
			// txt_diachi
			// 
			txt_diachi.Location = new Point(412, 78);
			txt_diachi.Name = "txt_diachi";
			txt_diachi.Size = new Size(351, 28);
			txt_diachi.TabIndex = 9;
			// 
			// txt_hoten
			// 
			txt_hoten.Location = new Point(568, 36);
			txt_hoten.Name = "txt_hoten";
			txt_hoten.Size = new Size(195, 28);
			txt_hoten.TabIndex = 10;
			// 
			// btn_ThemNV
			// 
			btn_ThemNV.Location = new Point(404, 185);
			btn_ThemNV.Name = "btn_ThemNV";
			btn_ThemNV.Size = new Size(104, 31);
			btn_ThemNV.TabIndex = 11;
			btn_ThemNV.Text = "Thêm";
			btn_ThemNV.UseVisualStyleBackColor = true;
			btn_ThemNV.Click += btn_ThemNV_Click;
			// 
			// btn_Thoat
			// 
			btn_Thoat.Location = new Point(568, 185);
			btn_Thoat.Name = "btn_Thoat";
			btn_Thoat.Size = new Size(104, 31);
			btn_Thoat.TabIndex = 12;
			btn_Thoat.Text = "Thoát";
			btn_Thoat.UseVisualStyleBackColor = true;
			btn_Thoat.Click += btn_Thoat_Click;
			// 
			// cbo_phongban
			// 
			cbo_phongban.FormattingEnabled = true;
			cbo_phongban.Location = new Point(436, 117);
			cbo_phongban.Name = "cbo_phongban";
			cbo_phongban.Size = new Size(327, 28);
			cbo_phongban.TabIndex = 13;
			// 
			// frmTreeView
			// 
			AutoScaleDimensions = new SizeF(10F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(777, 451);
			Controls.Add(cbo_phongban);
			Controls.Add(btn_Thoat);
			Controls.Add(btn_ThemNV);
			Controls.Add(txt_hoten);
			Controls.Add(txt_diachi);
			Controls.Add(txt_maso);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label6);
			Controls.Add(groupBox1);
			Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmTreeView";
			Text = "Phòng ban-Nhân viên";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label6;
		private TextBox txt_phongban;
		private TextBox txt_maso;
		private TextBox txt_diachi;
		private TextBox txt_hoten;
		private Button btn_ThemNV;
		private Button btn_Thoat;
		private Button btn_XoaPB;
		private Button btn_ThemPB;
		private ComboBox cbo_phongban;
		private TreeView trv_DS;
	}
}