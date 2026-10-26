namespace Thuchanh5d
{
	partial class frmBai2_nangcao_Bai7
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
			label3 = new Label();
			txtMaSV = new TextBox();
			txtMaMon = new TextBox();
			txtDiem = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 26);
			label1.Name = "label1";
			label1.Size = new Size(47, 20);
			label1.TabIndex = 0;
			label1.Text = "Mã sv";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 68);
			label2.Name = "label2";
			label2.Size = new Size(55, 20);
			label2.TabIndex = 1;
			label2.Text = "Mã mh";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 109);
			label3.Name = "label3";
			label3.Size = new Size(45, 20);
			label3.TabIndex = 2;
			label3.Text = "Điểm";
			// 
			// txtMaSV
			// 
			txtMaSV.Location = new Point(100, 26);
			txtMaSV.Name = "txtMaSV";
			txtMaSV.Size = new Size(344, 27);
			txtMaSV.TabIndex = 3;
			// 
			// txtMaMon
			// 
			txtMaMon.Location = new Point(100, 65);
			txtMaMon.Name = "txtMaMon";
			txtMaMon.Size = new Size(344, 27);
			txtMaMon.TabIndex = 4;
			// 
			// txtDiem
			// 
			txtDiem.Location = new Point(100, 106);
			txtDiem.Name = "txtDiem";
			txtDiem.Size = new Size(344, 27);
			txtDiem.TabIndex = 5;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(42, 178);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 6;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(193, 178);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 7;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(350, 178);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 8;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai2_nangcao_Bai7
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(471, 238);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtDiem);
			Controls.Add(txtMaMon);
			Controls.Add(txtMaSV);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai2_nangcao_Bai7";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtMaSV;
		private TextBox txtMaMon;
		private TextBox txtDiem;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}