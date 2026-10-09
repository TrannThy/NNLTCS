namespace TH4c
{
    partial class frmBai1
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
			lbla = new Label();
			lblb = new Label();
			txta = new TextBox();
			txtb = new TextBox();
			lblKetQua = new Label();
			txtKetQua = new TextBox();
			btnSum = new Button();
			btnMinus = new Button();
			btnMultiply = new Button();
			btnDivide = new Button();
			errorProvider1 = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// lbla
			// 
			lbla.AutoSize = true;
			lbla.Location = new Point(23, 19);
			lbla.Name = "lbla";
			lbla.Size = new Size(30, 19);
			lbla.TabIndex = 0;
			lbla.Text = "a =";
			// 
			// lblb
			// 
			lblb.AutoSize = true;
			lblb.Location = new Point(199, 19);
			lblb.Name = "lblb";
			lblb.Size = new Size(31, 19);
			lblb.TabIndex = 1;
			lblb.Text = "b =";
			// 
			// txta
			// 
			txta.Location = new Point(59, 16);
			txta.Name = "txta";
			txta.Size = new Size(125, 27);
			txta.TabIndex = 2;
			// 
			// txtb
			// 
			txtb.Location = new Point(236, 16);
			txtb.Name = "txtb";
			txtb.Size = new Size(125, 27);
			txtb.TabIndex = 3;
			// 
			// lblKetQua
			// 
			lblKetQua.AutoSize = true;
			lblKetQua.Location = new Point(23, 64);
			lblKetQua.Name = "lblKetQua";
			lblKetQua.Size = new Size(61, 19);
			lblKetQua.TabIndex = 4;
			lblKetQua.Text = "Kết quả";
			// 
			// txtKetQua
			// 
			txtKetQua.Location = new Point(90, 61);
			txtKetQua.Name = "txtKetQua";
			txtKetQua.ReadOnly = true;
			txtKetQua.Size = new Size(271, 27);
			txtKetQua.TabIndex = 5;
			// 
			// btnSum
			// 
			btnSum.Location = new Point(39, 99);
			btnSum.Name = "btnSum";
			btnSum.Size = new Size(45, 30);
			btnSum.TabIndex = 6;
			btnSum.Text = "+";
			btnSum.UseVisualStyleBackColor = true;
			btnSum.Click += btnSum_Click;
			// 
			// btnMinus
			// 
			btnMinus.Location = new Point(123, 99);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new Size(45, 30);
			btnMinus.TabIndex = 7;
			btnMinus.Text = "-";
			btnMinus.UseVisualStyleBackColor = true;
			btnMinus.Click += btnMinus_Click;
			// 
			// btnMultiply
			// 
			btnMultiply.Location = new Point(213, 99);
			btnMultiply.Name = "btnMultiply";
			btnMultiply.Size = new Size(45, 30);
			btnMultiply.TabIndex = 8;
			btnMultiply.Text = "x";
			btnMultiply.UseVisualStyleBackColor = true;
			btnMultiply.Click += btnMultiply_Click;
			// 
			// btnDivide
			// 
			btnDivide.Location = new Point(297, 99);
			btnDivide.Name = "btnDivide";
			btnDivide.Size = new Size(45, 30);
			btnDivide.TabIndex = 9;
			btnDivide.Text = "/";
			btnDivide.UseVisualStyleBackColor = true;
			btnDivide.Click += btnDivide_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// frmBai1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(387, 139);
			Controls.Add(btnDivide);
			Controls.Add(btnMultiply);
			Controls.Add(btnMinus);
			Controls.Add(btnSum);
			Controls.Add(txtKetQua);
			Controls.Add(lblKetQua);
			Controls.Add(txtb);
			Controls.Add(txta);
			Controls.Add(lblb);
			Controls.Add(lbla);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1";
			Text = "Cộng trừ nhân chia";
			FormClosing += frmBai1_FormClosing;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbla;
		private Label lblb;
		private TextBox txta;
		private TextBox txtb;
		private Label lblKetQua;
		private TextBox txtKetQua;
		private Button btnSum;
		private Button btnMinus;
		private Button btnMultiply;
		private Button btnDivide;
		private ErrorProvider errorProvider1;
	}
}
