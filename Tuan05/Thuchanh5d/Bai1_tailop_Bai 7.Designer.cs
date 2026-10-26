namespace Thuchanh5d
{
	partial class frmBai1_tailop_Bai7
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
			txtTenMon = new TextBox();
			txtMaMon = new TextBox();
			btnThem = new Button();
			btnXoa = new Button();
			btnSua = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 100);
			label1.Name = "label1";
			label1.Size = new Size(57, 20);
			label1.TabIndex = 0;
			label1.Text = "Tên mh";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(29, 47);
			label2.Name = "label2";
			label2.Size = new Size(55, 20);
			label2.TabIndex = 1;
			label2.Text = "Mã mh";
			// 
			// txtTenMon
			// 
			txtTenMon.Location = new Point(122, 97);
			txtTenMon.Name = "txtTenMon";
			txtTenMon.Size = new Size(264, 27);
			txtTenMon.TabIndex = 2;
			// 
			// txtMaMon
			// 
			txtMaMon.Location = new Point(122, 47);
			txtMaMon.Name = "txtMaMon";
			txtMaMon.Size = new Size(264, 27);
			txtMaMon.TabIndex = 3;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(39, 148);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 4;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(164, 148);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(94, 29);
			btnXoa.TabIndex = 5;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(292, 148);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(94, 29);
			btnSua.TabIndex = 6;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// frmBai1_tailop_Bai7
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(438, 207);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Controls.Add(txtMaMon);
			Controls.Add(txtTenMon);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmBai1_tailop_Bai7";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtTenMon;
		private TextBox txtMaMon;
		private Button btnThem;
		private Button btnXoa;
		private Button btnSua;
	}
}