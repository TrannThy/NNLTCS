namespace Thuchanh5c
{
	partial class frmBai2
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
			btnLoad_cbo = new Button();
			btnHien = new Button();
			label1 = new Label();
			cbo_dt = new ComboBox();
			lbl_Kq = new Label();
			SuspendLayout();
			// 
			// btnLoad_cbo
			// 
			btnLoad_cbo.Location = new Point(36, 29);
			btnLoad_cbo.Name = "btnLoad_cbo";
			btnLoad_cbo.Size = new Size(208, 29);
			btnLoad_cbo.TabIndex = 0;
			btnLoad_cbo.Text = "Load Dữ liệu combobox";
			btnLoad_cbo.UseVisualStyleBackColor = true;
			btnLoad_cbo.Click += btnLoad_cbo_Click;
			// 
			// btnHien
			// 
			btnHien.Location = new Point(108, 152);
			btnHien.Name = "btnHien";
			btnHien.Size = new Size(94, 29);
			btnHien.TabIndex = 1;
			btnHien.Text = "Hiện";
			btnHien.UseVisualStyleBackColor = true;
			btnHien.Click += btnHien_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(36, 67);
			label1.Name = "label1";
			label1.Size = new Size(61, 20);
			label1.TabIndex = 2;
			label1.Text = "Dân tộc";
			// 
			// cbo_dt
			// 
			cbo_dt.FormattingEnabled = true;
			cbo_dt.Location = new Point(103, 64);
			cbo_dt.Name = "cbo_dt";
			cbo_dt.Size = new Size(151, 28);
			cbo_dt.TabIndex = 3;
			cbo_dt.SelectedIndexChanged += cbo_dt_SelectedIndexChanged;
			// 
			// lbl_Kq
			// 
			lbl_Kq.AutoSize = true;
			lbl_Kq.ForeColor = Color.Red;
			lbl_Kq.Location = new Point(103, 109);
			lbl_Kq.Name = "lbl_Kq";
			lbl_Kq.Size = new Size(60, 20);
			lbl_Kq.TabIndex = 4;
			lbl_Kq.Text = "Kết quả";
			// 
			// frmBai2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(333, 216);
			Controls.Add(lbl_Kq);
			Controls.Add(cbo_dt);
			Controls.Add(label1);
			Controls.Add(btnHien);
			Controls.Add(btnLoad_cbo);
			Name = "frmBai2";
			Text = "cbo_DanToc";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnLoad_cbo;
		private Button btnHien;
		private Label label1;
		private ComboBox cbo_dt;
		private Label lbl_Kq;
	}
}