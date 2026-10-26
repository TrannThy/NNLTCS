namespace Thuchanh5d
{
	partial class frmBai3
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
			txtNoiDung = new TextBox();
			saveFileDialog1 = new SaveFileDialog();
			btnLuuFile = new Button();
			btnMoFile = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 9);
			label1.Name = "label1";
			label1.Size = new Size(111, 19);
			label1.TabIndex = 0;
			label1.Text = "Nhập đoạn text";
			// 
			// txtNoiDung
			// 
			txtNoiDung.Location = new Point(14, 30);
			txtNoiDung.Multiline = true;
			txtNoiDung.Name = "txtNoiDung";
			txtNoiDung.Size = new Size(491, 203);
			txtNoiDung.TabIndex = 1;
			// 
			// btnLuuFile
			// 
			btnLuuFile.Location = new Point(387, 238);
			btnLuuFile.Name = "btnLuuFile";
			btnLuuFile.Size = new Size(106, 28);
			btnLuuFile.TabIndex = 2;
			btnLuuFile.Text = "lưu file";
			btnLuuFile.UseVisualStyleBackColor = true;
			btnLuuFile.Click += btnLuuFile_Click;
			// 
			// btnMoFile
			// 
			btnMoFile.Location = new Point(287, 237);
			btnMoFile.Name = "btnMoFile";
			btnMoFile.Size = new Size(94, 29);
			btnMoFile.TabIndex = 3;
			btnMoFile.Text = "Mở file";
			btnMoFile.UseVisualStyleBackColor = true;
			btnMoFile.Click += btnMoFile_Click;
			// 
			// frmBai3
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(519, 267);
			Controls.Add(btnMoFile);
			Controls.Add(btnLuuFile);
			Controls.Add(txtNoiDung);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai3";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtNoiDung;
		private SaveFileDialog saveFileDialog1;
		private Button btnLuuFile;
		private Button btnMoFile;
	}
}