namespace Thuchanh5d
{
	partial class frmBai1_venha
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			btnBatDau = new Button();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(152, 50);
			label1.Name = "label1";
			label1.Size = new Size(51, 19);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// btnBatDau
			// 
			btnBatDau.Location = new Point(131, 114);
			btnBatDau.Name = "btnBatDau";
			btnBatDau.Size = new Size(94, 29);
			btnBatDau.TabIndex = 1;
			btnBatDau.Text = "Bắt đầu";
			btnBatDau.UseVisualStyleBackColor = true;
			btnBatDau.Click += btnBatDau_Click;
			// 
			// timer1
			// 
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// frmBai1_venha
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(367, 168);
			Controls.Add(btnBatDau);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai1_venha";
			Text = "Form1";
			Load += frmBai1_venha_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnBatDau;
		private System.Windows.Forms.Timer timer1;
	}
}