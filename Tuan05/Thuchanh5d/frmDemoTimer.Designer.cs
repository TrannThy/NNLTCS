namespace Thuchanh5d
{
    partial class frmDemoTimer
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
			label1 = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(153, 98);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(60, 23);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// frmDemoTimer
			// 
			AutoScaleDimensions = new SizeF(12F, 23F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(509, 234);
			Controls.Add(label1);
			Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ForeColor = Color.Red;
			Margin = new Padding(4, 4, 4, 4);
			Name = "frmDemoTimer";
			Text = "Demo Timer";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private System.Windows.Forms.Timer timer1;
	}
}
