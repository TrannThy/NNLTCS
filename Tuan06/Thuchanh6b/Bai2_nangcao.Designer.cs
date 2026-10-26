namespace Thuchanh6b
{
	partial class frmBai2_nangcao
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
			cmbMonHoc = new ComboBox();
			btnLoc = new Button();
			listView1 = new ListView();
			label2 = new Label();
			txtTongDiem = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34, 28);
			label1.Name = "label1";
			label1.Size = new Size(67, 20);
			label1.TabIndex = 0;
			label1.Text = "Môn học";
			// 
			// cmbMonHoc
			// 
			cmbMonHoc.FormattingEnabled = true;
			cmbMonHoc.Location = new Point(115, 28);
			cmbMonHoc.Name = "cmbMonHoc";
			cmbMonHoc.Size = new Size(482, 28);
			cmbMonHoc.TabIndex = 1;
			// 
			// btnLoc
			// 
			btnLoc.Location = new Point(665, 28);
			btnLoc.Name = "btnLoc";
			btnLoc.Size = new Size(94, 29);
			btnLoc.TabIndex = 2;
			btnLoc.Text = "Lọc dữ liệu";
			btnLoc.UseVisualStyleBackColor = true;
			btnLoc.Click += btnLoc_Click;
			// 
			// listView1
			// 
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.Location = new Point(12, 75);
			listView1.Name = "listView1";
			listView1.Size = new Size(768, 302);
			listView1.TabIndex = 3;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(363, 402);
			label2.Name = "label2";
			label2.Size = new Size(81, 20);
			label2.TabIndex = 4;
			label2.Text = "Tổng điểm";
			// 
			// txtTongDiem
			// 
			txtTongDiem.Location = new Point(463, 402);
			txtTongDiem.Name = "txtTongDiem";
			txtTongDiem.Size = new Size(151, 27);
			txtTongDiem.TabIndex = 5;
			// 
			// frmBai2_nangcao
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtTongDiem);
			Controls.Add(label2);
			Controls.Add(listView1);
			Controls.Add(btnLoc);
			Controls.Add(cmbMonHoc);
			Controls.Add(label1);
			Name = "frmBai2_nangcao";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox cmbMonHoc;
		private Button btnLoc;
		private ListView listView1;
		private Label label2;
		private TextBox txtTongDiem;
	}
}