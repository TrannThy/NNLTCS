namespace TH4d
{
    partial class lblCongTruNhanChia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			lblA = new Label();
			lblB = new Label();
			lblKetQua = new Label();
			txtA = new TextBox();
			txtB = new TextBox();
			txtKetQua = new TextBox();
			rbtnCong = new RadioButton();
			rbtnTru = new RadioButton();
			rbtnNhan = new RadioButton();
			rbtnChia = new RadioButton();
			btnTinh = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// lblA
			// 
			lblA.AutoSize = true;
			lblA.Location = new Point(33, 32);
			lblA.Name = "lblA";
			lblA.Size = new Size(30, 19);
			lblA.TabIndex = 0;
			lblA.Text = "a =";
			// 
			// lblB
			// 
			lblB.AutoSize = true;
			lblB.Location = new Point(216, 35);
			lblB.Name = "lblB";
			lblB.Size = new Size(31, 19);
			lblB.TabIndex = 1;
			lblB.Text = "b =";
			// 
			// lblKetQua
			// 
			lblKetQua.AutoSize = true;
			lblKetQua.Location = new Point(33, 86);
			lblKetQua.Name = "lblKetQua";
			lblKetQua.Size = new Size(61, 19);
			lblKetQua.TabIndex = 2;
			lblKetQua.Text = "Kết quả";
			// 
			// txtA
			// 
			txtA.Location = new Point(69, 32);
			txtA.Name = "txtA";
			txtA.Size = new Size(106, 27);
			txtA.TabIndex = 3;
			txtA.KeyPress += txtA_KeyPress;
			// 
			// txtB
			// 
			txtB.Location = new Point(253, 32);
			txtB.Name = "txtB";
			txtB.Size = new Size(93, 27);
			txtB.TabIndex = 4;
			txtB.KeyPress += txtB_KeyPress;
			// 
			// txtKetQua
			// 
			txtKetQua.Location = new Point(122, 83);
			txtKetQua.Name = "txtKetQua";
			txtKetQua.Size = new Size(224, 27);
			txtKetQua.TabIndex = 5;
			// 
			// rbtnCong
			// 
			rbtnCong.AutoSize = true;
			rbtnCong.Location = new Point(54, 188);
			rbtnCong.Name = "rbtnCong";
			rbtnCong.Size = new Size(40, 23);
			rbtnCong.TabIndex = 6;
			rbtnCong.TabStop = true;
			rbtnCong.Text = "+";
			rbtnCong.UseVisualStyleBackColor = true;
			// 
			// rbtnTru
			// 
			rbtnTru.AutoSize = true;
			rbtnTru.Location = new Point(139, 188);
			rbtnTru.Name = "rbtnTru";
			rbtnTru.Size = new Size(36, 23);
			rbtnTru.TabIndex = 7;
			rbtnTru.TabStop = true;
			rbtnTru.Text = "-";
			rbtnTru.UseVisualStyleBackColor = true;
			// 
			// rbtnNhan
			// 
			rbtnNhan.AutoSize = true;
			rbtnNhan.Location = new Point(217, 188);
			rbtnNhan.Name = "rbtnNhan";
			rbtnNhan.Size = new Size(38, 23);
			rbtnNhan.TabIndex = 8;
			rbtnNhan.TabStop = true;
			rbtnNhan.Text = "x";
			rbtnNhan.UseVisualStyleBackColor = true;
			// 
			// rbtnChia
			// 
			rbtnChia.AutoSize = true;
			rbtnChia.Location = new Point(311, 188);
			rbtnChia.Name = "rbtnChia";
			rbtnChia.Size = new Size(35, 23);
			rbtnChia.TabIndex = 9;
			rbtnChia.TabStop = true;
			rbtnChia.Text = "/";
			rbtnChia.UseVisualStyleBackColor = true;
			// 
			// btnTinh
			// 
			btnTinh.Location = new Point(153, 135);
			btnTinh.Name = "btnTinh";
			btnTinh.Size = new Size(94, 29);
			btnTinh.TabIndex = 10;
			btnTinh.Text = "Tính";
			btnTinh.UseVisualStyleBackColor = true;
			btnTinh.Click += btnTinh_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// lblCongTruNhanChia
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(376, 233);
			Controls.Add(btnTinh);
			Controls.Add(rbtnChia);
			Controls.Add(rbtnNhan);
			Controls.Add(rbtnTru);
			Controls.Add(rbtnCong);
			Controls.Add(txtKetQua);
			Controls.Add(txtB);
			Controls.Add(txtA);
			Controls.Add(lblKetQua);
			Controls.Add(lblB);
			Controls.Add(lblA);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "lblCongTruNhanChia";
			Text = "Cộng trừ nhân chia radio";
			FormClosing += lblCongTruNhanChia_FormClosing;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblA;
		private Label lblB;
		private Label lblKetQua;
		private TextBox txtA;
		private TextBox txtB;
		private TextBox txtKetQua;
		private RadioButton rbtnCong;
		private RadioButton rbtnTru;
		private RadioButton rbtnNhan;
		private RadioButton rbtnChia;
		private Button btnTinh;
		private ErrorProvider errorProvider1;
	}
}
