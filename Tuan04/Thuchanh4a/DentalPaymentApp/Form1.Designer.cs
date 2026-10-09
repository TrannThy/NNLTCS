namespace DentalPaymentApp
{
    partial class form
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
			lblTitle = new Label();
			lblName = new Label();
			txtName = new TextBox();
			chkClean = new CheckBox();
			lblCleanCost = new Label();
			chkWhitening = new CheckBox();
			lblWhiteningCost = new Label();
			chkXRay = new CheckBox();
			lblXRayCost = new Label();
			lblFilling = new Label();
			numFilling = new NumericUpDown();
			lblFillCost = new Label();
			lblTotal = new Label();
			txtTotal = new TextBox();
			btnExit = new Button();
			btnCalc = new Button();
			((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Impact", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.Location = new Point(86, 25);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(285, 36);
			lblTitle.TabIndex = 1;
			lblTitle.Text = "Dental Payment Form";
			lblTitle.Click += label1_Click;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblName.ForeColor = SystemColors.ControlText;
			lblName.Location = new Point(24, 89);
			lblName.Name = "lblName";
			lblName.Size = new Size(112, 19);
			lblName.TabIndex = 2;
			lblName.Text = "Tên khách hàng";
			// 
			// txtName
			// 
			txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtName.Location = new Point(157, 83);
			txtName.Name = "txtName";
			txtName.Size = new Size(236, 30);
			txtName.TabIndex = 3;
			// 
			// chkClean
			// 
			chkClean.AutoSize = true;
			chkClean.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			chkClean.ForeColor = SystemColors.ControlText;
			chkClean.Location = new Point(29, 148);
			chkClean.Name = "chkClean";
			chkClean.Size = new Size(83, 23);
			chkClean.TabIndex = 4;
			chkClean.Text = "Cạo vôi";
			chkClean.UseVisualStyleBackColor = true;
			// 
			// lblCleanCost
			// 
			lblCleanCost.AutoSize = true;
			lblCleanCost.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCleanCost.ForeColor = SystemColors.ControlText;
			lblCleanCost.Location = new Point(350, 152);
			lblCleanCost.Name = "lblCleanCost";
			lblCleanCost.Size = new Size(72, 19);
			lblCleanCost.TabIndex = 5;
			lblCleanCost.Text = "$100000";
			// 
			// chkWhitening
			// 
			chkWhitening.AutoSize = true;
			chkWhitening.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			chkWhitening.ForeColor = SystemColors.ControlText;
			chkWhitening.Location = new Point(29, 186);
			chkWhitening.Name = "chkWhitening";
			chkWhitening.Size = new Size(93, 23);
			chkWhitening.TabIndex = 6;
			chkWhitening.Text = "Tẩy trắng";
			chkWhitening.UseVisualStyleBackColor = true;
			// 
			// lblWhiteningCost
			// 
			lblWhiteningCost.AutoSize = true;
			lblWhiteningCost.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblWhiteningCost.ForeColor = SystemColors.ControlText;
			lblWhiteningCost.Location = new Point(350, 190);
			lblWhiteningCost.Name = "lblWhiteningCost";
			lblWhiteningCost.Size = new Size(81, 19);
			lblWhiteningCost.TabIndex = 7;
			lblWhiteningCost.Text = "$1200000";
			// 
			// chkXRay
			// 
			chkXRay.AutoSize = true;
			chkXRay.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			chkXRay.ForeColor = SystemColors.ControlText;
			chkXRay.Location = new Point(29, 225);
			chkXRay.Name = "chkXRay";
			chkXRay.Size = new Size(132, 23);
			chkXRay.TabIndex = 8;
			chkXRay.Text = "Chụp hình răng";
			chkXRay.UseVisualStyleBackColor = true;
			// 
			// lblXRayCost
			// 
			lblXRayCost.AutoSize = true;
			lblXRayCost.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblXRayCost.ForeColor = SystemColors.ControlText;
			lblXRayCost.Location = new Point(350, 225);
			lblXRayCost.Name = "lblXRayCost";
			lblXRayCost.Size = new Size(72, 19);
			lblXRayCost.TabIndex = 9;
			lblXRayCost.Text = "$200000";
			// 
			// lblFilling
			// 
			lblFilling.AutoSize = true;
			lblFilling.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblFilling.ForeColor = SystemColors.ControlText;
			lblFilling.Location = new Point(12, 263);
			lblFilling.Name = "lblFilling";
			lblFilling.Size = new Size(76, 19);
			lblFilling.TabIndex = 10;
			lblFilling.Text = "Trám răng";
			// 
			// numFilling
			// 
			numFilling.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			numFilling.Location = new Point(98, 262);
			numFilling.Name = "numFilling";
			numFilling.Size = new Size(63, 25);
			numFilling.TabIndex = 11;
			// 
			// lblFillCost
			// 
			lblFillCost.AutoSize = true;
			lblFillCost.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblFillCost.ForeColor = SystemColors.ControlText;
			lblFillCost.Location = new Point(350, 262);
			lblFillCost.Name = "lblFillCost";
			lblFillCost.Size = new Size(88, 19);
			lblFillCost.TabIndex = 12;
			lblFillCost.Text = "$80000/cái";
			// 
			// lblTotal
			// 
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTotal.ForeColor = SystemColors.ControlText;
			lblTotal.Location = new Point(200, 315);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(43, 19);
			lblTotal.TabIndex = 13;
			lblTotal.Text = "Total";
			// 
			// txtTotal
			// 
			txtTotal.Enabled = false;
			txtTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTotal.Location = new Point(249, 309);
			txtTotal.Name = "txtTotal";
			txtTotal.Size = new Size(182, 30);
			txtTotal.TabIndex = 14;
			// 
			// btnExit
			// 
			btnExit.BackColor = SystemColors.ControlLight;
			btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnExit.ForeColor = SystemColors.ControlText;
			btnExit.Location = new Point(79, 372);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 15;
			btnExit.Text = "Thoát";
			btnExit.UseVisualStyleBackColor = false;
			btnExit.Click += btnExit_Click;
			// 
			// btnCalc
			// 
			btnCalc.BackColor = SystemColors.ControlLight;
			btnCalc.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCalc.ForeColor = SystemColors.ControlText;
			btnCalc.Location = new Point(299, 372);
			btnCalc.Name = "btnCalc";
			btnCalc.Size = new Size(94, 29);
			btnCalc.TabIndex = 16;
			btnCalc.Text = "Tính tiền";
			btnCalc.UseVisualStyleBackColor = false;
			btnCalc.Click += btnCalc_Click;
			// 
			// form
			// 
			AutoScaleDimensions = new SizeF(16F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(463, 425);
			Controls.Add(btnCalc);
			Controls.Add(btnExit);
			Controls.Add(txtTotal);
			Controls.Add(lblTotal);
			Controls.Add(lblFillCost);
			Controls.Add(numFilling);
			Controls.Add(lblFilling);
			Controls.Add(lblXRayCost);
			Controls.Add(chkXRay);
			Controls.Add(lblWhiteningCost);
			Controls.Add(chkWhitening);
			Controls.Add(lblCleanCost);
			Controls.Add(chkClean);
			Controls.Add(txtName);
			Controls.Add(lblName);
			Controls.Add(lblTitle);
			Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ForeColor = SystemColors.Highlight;
			Margin = new Padding(6);
			Name = "form";
			Text = "Dental Payment Application";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTitle;
		private Label lblName;
		private TextBox txtName;
		private CheckBox chkClean;
		private Label lblCleanCost;
		private CheckBox chkWhitening;
		private Label lblWhiteningCost;
		private CheckBox chkXRay;
		private Label lblXRayCost;
		private Label lblFilling;
		private NumericUpDown numFilling;
		private Label lblFillCost;
		private Label lblTotal;
		private TextBox txtTotal;
		private Button btnExit;
		private Button btnCalc;
	}
}
