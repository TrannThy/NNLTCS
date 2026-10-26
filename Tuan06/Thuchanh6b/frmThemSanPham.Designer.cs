namespace Thuchanh6b
{
	partial class frmThemSanPham
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
			txtTenSP = new TextBox();
			btnThem = new Button();
			btnThoat = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(39, 54);
			label1.Name = "label1";
			label1.Size = new Size(100, 20);
			label1.TabIndex = 0;
			label1.Text = "Tên sản phẩm";
			// 
			// txtTenSP
			// 
			txtTenSP.Location = new Point(155, 51);
			txtTenSP.Name = "txtTenSP";
			txtTenSP.Size = new Size(319, 27);
			txtTenSP.TabIndex = 1;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(99, 134);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(94, 29);
			btnThem.TabIndex = 2;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(325, 134);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmThemSanPham
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(516, 190);
			Controls.Add(btnThoat);
			Controls.Add(btnThem);
			Controls.Add(txtTenSP);
			Controls.Add(label1);
			Name = "frmThemSanPham";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtTenSP;
		private Button btnThem;
		private Button btnThoat;
	}
}