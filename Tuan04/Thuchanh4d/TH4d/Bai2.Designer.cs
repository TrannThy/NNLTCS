namespace TH4d
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
			lblTittle = new Label();
			grpFontStyle = new GroupBox();
			chkBoldItalic = new CheckBox();
			chkItalic = new CheckBox();
			chkBold = new CheckBox();
			chkRegular = new CheckBox();
			grpColor = new GroupBox();
			rdoBlue = new RadioButton();
			rdoGreen = new RadioButton();
			rdoRed = new RadioButton();
			rdoAutoColor = new RadioButton();
			btnExit = new Button();
			grpFontStyle.SuspendLayout();
			grpColor.SuspendLayout();
			SuspendLayout();
			// 
			// lblTittle
			// 
			lblTittle.AutoSize = true;
			lblTittle.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTittle.ForeColor = Color.Red;
			lblTittle.Location = new Point(27, 9);
			lblTittle.Name = "lblTittle";
			lblTittle.Size = new Size(495, 32);
			lblTittle.TabIndex = 0;
			lblTittle.Text = "Trường đại học Công nghiệp thực phẩm";
			// 
			// grpFontStyle
			// 
			grpFontStyle.Controls.Add(chkBoldItalic);
			grpFontStyle.Controls.Add(chkItalic);
			grpFontStyle.Controls.Add(chkBold);
			grpFontStyle.Controls.Add(chkRegular);
			grpFontStyle.Location = new Point(27, 72);
			grpFontStyle.Name = "grpFontStyle";
			grpFontStyle.Size = new Size(204, 222);
			grpFontStyle.TabIndex = 1;
			grpFontStyle.TabStop = false;
			grpFontStyle.Text = "Font style";
			// 
			// chkBoldItalic
			// 
			chkBoldItalic.AutoSize = true;
			chkBoldItalic.Location = new Point(14, 172);
			chkBoldItalic.Name = "chkBoldItalic";
			chkBoldItalic.Size = new Size(130, 23);
			chkBoldItalic.TabIndex = 3;
			chkBoldItalic.Text = "Bold and Italic";
			chkBoldItalic.UseVisualStyleBackColor = true;
			chkBoldItalic.CheckedChanged += chkBoldItalic_CheckedChanged;
			// 
			// chkItalic
			// 
			chkItalic.AutoSize = true;
			chkItalic.Location = new Point(14, 123);
			chkItalic.Name = "chkItalic";
			chkItalic.Size = new Size(66, 23);
			chkItalic.TabIndex = 2;
			chkItalic.Text = "Italic";
			chkItalic.UseVisualStyleBackColor = true;
			chkItalic.CheckedChanged += chkItalic_CheckedChanged;
			// 
			// chkBold
			// 
			chkBold.AutoSize = true;
			chkBold.Location = new Point(14, 78);
			chkBold.Name = "chkBold";
			chkBold.Size = new Size(64, 23);
			chkBold.TabIndex = 1;
			chkBold.Text = "Bold";
			chkBold.UseVisualStyleBackColor = true;
			chkBold.CheckedChanged += chkBold_CheckedChanged;
			// 
			// chkRegular
			// 
			chkRegular.AutoSize = true;
			chkRegular.Location = new Point(14, 30);
			chkRegular.Name = "chkRegular";
			chkRegular.Size = new Size(84, 23);
			chkRegular.TabIndex = 0;
			chkRegular.Text = "Regular";
			chkRegular.UseVisualStyleBackColor = true;
			chkRegular.CheckedChanged += chkRegular_CheckedChanged;
			// 
			// grpColor
			// 
			grpColor.Controls.Add(rdoBlue);
			grpColor.Controls.Add(rdoGreen);
			grpColor.Controls.Add(rdoRed);
			grpColor.Controls.Add(rdoAutoColor);
			grpColor.Location = new Point(255, 72);
			grpColor.Name = "grpColor";
			grpColor.Size = new Size(250, 222);
			grpColor.TabIndex = 2;
			grpColor.TabStop = false;
			grpColor.Text = "Color";
			// 
			// rdoBlue
			// 
			rdoBlue.AutoSize = true;
			rdoBlue.Location = new Point(17, 172);
			rdoBlue.Name = "rdoBlue";
			rdoBlue.Size = new Size(62, 23);
			rdoBlue.TabIndex = 3;
			rdoBlue.TabStop = true;
			rdoBlue.Text = "Blue";
			rdoBlue.UseVisualStyleBackColor = true;
			rdoBlue.CheckedChanged += rdoBlue_CheckedChanged;
			// 
			// rdoGreen
			// 
			rdoGreen.AutoSize = true;
			rdoGreen.Location = new Point(17, 123);
			rdoGreen.Name = "rdoGreen";
			rdoGreen.Size = new Size(72, 23);
			rdoGreen.TabIndex = 2;
			rdoGreen.TabStop = true;
			rdoGreen.Text = "Green";
			rdoGreen.UseVisualStyleBackColor = true;
			rdoGreen.CheckedChanged += rdoGreen_CheckedChanged;
			// 
			// rdoRed
			// 
			rdoRed.AutoSize = true;
			rdoRed.Location = new Point(17, 78);
			rdoRed.Name = "rdoRed";
			rdoRed.Size = new Size(57, 23);
			rdoRed.TabIndex = 1;
			rdoRed.TabStop = true;
			rdoRed.Text = "Red";
			rdoRed.UseVisualStyleBackColor = true;
			rdoRed.CheckedChanged += rdoRed_CheckedChanged;
			// 
			// rdoAutoColor
			// 
			rdoAutoColor.AutoSize = true;
			rdoAutoColor.Location = new Point(17, 33);
			rdoAutoColor.Name = "rdoAutoColor";
			rdoAutoColor.Size = new Size(104, 23);
			rdoAutoColor.TabIndex = 0;
			rdoAutoColor.TabStop = true;
			rdoAutoColor.Text = "Auto color";
			rdoAutoColor.UseVisualStyleBackColor = true;
			rdoAutoColor.CheckedChanged += rdoAutoColor_CheckedChanged;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(411, 300);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 3;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// frmBai2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(551, 339);
			Controls.Add(btnExit);
			Controls.Add(grpColor);
			Controls.Add(grpFontStyle);
			Controls.Add(lblTittle);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2";
			Text = "frmFormat";
			grpFontStyle.ResumeLayout(false);
			grpFontStyle.PerformLayout();
			grpColor.ResumeLayout(false);
			grpColor.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTittle;
		private GroupBox grpFontStyle;
		private GroupBox grpColor;
		private CheckBox chkBoldItalic;
		private CheckBox chkItalic;
		private CheckBox chkBold;
		private CheckBox chkRegular;
		private RadioButton rdoBlue;
		private RadioButton rdoGreen;
		private RadioButton rdoRed;
		private RadioButton rdoAutoColor;
		private Button btnExit;
	}
}