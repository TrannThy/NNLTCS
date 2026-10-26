namespace Thuchanh5c
{
    partial class frmListBox
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
			lst_Trai = new ListBox();
			lst_Phai = new ListBox();
			btnQuaTraiAll = new Button();
			btnQuaTrai = new Button();
			btnQuaPhaiAll = new Button();
			btnQuaPhai = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// lst_Trai
			// 
			lst_Trai.FormattingEnabled = true;
			lst_Trai.Items.AddRange(new object[] { "Cốc", "Ổi", "Xoài", "Me", "Bưởi", "Cam" });
			lst_Trai.Location = new Point(12, 25);
			lst_Trai.Name = "lst_Trai";
			lst_Trai.SelectionMode = SelectionMode.MultiSimple;
			lst_Trai.Size = new Size(197, 344);
			lst_Trai.TabIndex = 0;
			// 
			// lst_Phai
			// 
			lst_Phai.FormattingEnabled = true;
			lst_Phai.Location = new Point(266, 25);
			lst_Phai.Name = "lst_Phai";
			lst_Phai.Size = new Size(193, 344);
			lst_Phai.TabIndex = 1;
			// 
			// btnQuaTraiAll
			// 
			btnQuaTraiAll.Location = new Point(210, 193);
			btnQuaTraiAll.Name = "btnQuaTraiAll";
			btnQuaTraiAll.Size = new Size(50, 50);
			btnQuaTraiAll.TabIndex = 2;
			btnQuaTraiAll.Text = "<<";
			btnQuaTraiAll.UseVisualStyleBackColor = true;
			btnQuaTraiAll.Click += btnQuaTraiAll_Click;
			// 
			// btnQuaTrai
			// 
			btnQuaTrai.Location = new Point(210, 137);
			btnQuaTrai.Name = "btnQuaTrai";
			btnQuaTrai.Size = new Size(50, 50);
			btnQuaTrai.TabIndex = 3;
			btnQuaTrai.Text = "<";
			btnQuaTrai.UseVisualStyleBackColor = true;
			btnQuaTrai.Click += btnQuaTrai_Click;
			// 
			// btnQuaPhaiAll
			// 
			btnQuaPhaiAll.Location = new Point(210, 81);
			btnQuaPhaiAll.Name = "btnQuaPhaiAll";
			btnQuaPhaiAll.Size = new Size(50, 50);
			btnQuaPhaiAll.TabIndex = 4;
			btnQuaPhaiAll.Text = ">>";
			btnQuaPhaiAll.UseVisualStyleBackColor = true;
			btnQuaPhaiAll.Click += btnQuaPhaiAll_Click;
			// 
			// btnQuaPhai
			// 
			btnQuaPhai.Location = new Point(210, 25);
			btnQuaPhai.Name = "btnQuaPhai";
			btnQuaPhai.Size = new Size(50, 50);
			btnQuaPhai.TabIndex = 5;
			btnQuaPhai.Text = ">";
			btnQuaPhai.UseVisualStyleBackColor = true;
			btnQuaPhai.Click += btnQuaPhai_Click;
			// 
			// button1
			// 
			button1.Location = new Point(210, 249);
			button1.Name = "button1";
			button1.Size = new Size(50, 50);
			button1.TabIndex = 6;
			button1.Text = "Tùy ý";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// frmListBox
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(471, 384);
			Controls.Add(button1);
			Controls.Add(btnQuaPhai);
			Controls.Add(btnQuaPhaiAll);
			Controls.Add(btnQuaTrai);
			Controls.Add(btnQuaTraiAll);
			Controls.Add(lst_Phai);
			Controls.Add(lst_Trai);
			Name = "frmListBox";
			Text = "Sử dụng listbox";
			FormClosing += frmListBox_FormClosing;
			ResumeLayout(false);
		}

		#endregion

		private ListBox lst_Trai;
		private ListBox lst_Phai;
		private Button btnQuaTraiAll;
		private Button btnQuaTrai;
		private Button btnQuaPhaiAll;
		private Button btnQuaPhai;
		private Button button1;
	}
}
