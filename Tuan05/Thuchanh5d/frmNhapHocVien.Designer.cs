namespace Thuchanh5d
{
	partial class frmNhapHocVien
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
			txtHoTen = new TextBox();
			btnCapNhat = new Button();
			btnTroVe = new Button();
			cboLop = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(25, 24);
			label1.Name = "label1";
			label1.Size = new Size(73, 20);
			label1.TabIndex = 0;
			label1.Text = "Họ và tên";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(25, 73);
			label2.Name = "label2";
			label2.Size = new Size(34, 20);
			label2.TabIndex = 1;
			label2.Text = "Lớp";
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(104, 24);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(204, 27);
			txtHoTen.TabIndex = 2;
			// 
			// btnCapNhat
			// 
			btnCapNhat.Location = new Point(104, 160);
			btnCapNhat.Name = "btnCapNhat";
			btnCapNhat.Size = new Size(94, 29);
			btnCapNhat.TabIndex = 3;
			btnCapNhat.Text = "Cập nhật";
			btnCapNhat.UseVisualStyleBackColor = true;
			btnCapNhat.Click += btnCapNhat_Click;
			// 
			// btnTroVe
			// 
			btnTroVe.Location = new Point(233, 160);
			btnTroVe.Name = "btnTroVe";
			btnTroVe.Size = new Size(94, 29);
			btnTroVe.TabIndex = 4;
			btnTroVe.Text = "Trở về";
			btnTroVe.UseVisualStyleBackColor = true;
			btnTroVe.Click += btnTroVe_Click;
			// 
			// cboLop
			// 
			cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
			cboLop.FormattingEnabled = true;
			cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
			cboLop.Location = new Point(104, 73);
			cboLop.Name = "cboLop";
			cboLop.Size = new Size(204, 28);
			cboLop.TabIndex = 5;
			// 
			// frmNhapHocVien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(376, 216);
			Controls.Add(cboLop);
			Controls.Add(btnTroVe);
			Controls.Add(btnCapNhat);
			Controls.Add(txtHoTen);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "frmNhapHocVien";
			Text = "Form1";
			Load += frmNhapHocVien_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtHoTen;
		private Button btnCapNhat;
		private Button btnTroVe;
		private ComboBox cboLop;
	}
}