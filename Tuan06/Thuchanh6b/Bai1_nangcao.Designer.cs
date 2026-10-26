namespace Thuchanh6b
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
			btnHienThi = new Button();
			listView1 = new ListView();
			btnThoat = new Button();
			SuspendLayout();
			// 
			// btnHienThi
			// 
			btnHienThi.Location = new Point(24, 12);
			btnHienThi.Name = "btnHienThi";
			btnHienThi.Size = new Size(161, 29);
			btnHienThi.TabIndex = 0;
			btnHienThi.Text = "Hiển thị dữ liệu";
			btnHienThi.UseVisualStyleBackColor = true;
			btnHienThi.Click += btnHienThi_Click;
			// 
			// listView1
			// 
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 75);
			listView1.Name = "listView1";
			listView1.Size = new Size(776, 325);
			listView1.TabIndex = 1;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(660, 409);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(94, 29);
			btnThoat.TabIndex = 2;
			btnThoat.Text = "Thoat";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmBai1_nangcao
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnThoat);
			Controls.Add(listView1);
			Controls.Add(btnHienThi);
			Name = "frmBai1_nangcao";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnHienThi;
		private ListView listView1;
		private Button btnThoat;
	}
}