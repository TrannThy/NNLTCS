namespace Thuchanh5c
{
	partial class frmBai3_venha
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
			trvDanhBa = new TreeView();
			groupBox1 = new GroupBox();
			txtFirstName = new TextBox();
			btnAdd = new Button();
			txtLastName = new TextBox();
			label2 = new Label();
			label1 = new Label();
			btnExit = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// trvDanhBa
			// 
			trvDanhBa.Location = new Point(0, 0);
			trvDanhBa.Name = "trvDanhBa";
			trvDanhBa.Size = new Size(273, 429);
			trvDanhBa.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtFirstName);
			groupBox1.Controls.Add(btnAdd);
			groupBox1.Controls.Add(txtLastName);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(296, 11);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(316, 146);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(96, 22);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(213, 27);
			txtFirstName.TabIndex = 3;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(195, 86);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(94, 29);
			btnAdd.TabIndex = 2;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(96, 53);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(213, 27);
			txtLastName.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 56);
			label2.Name = "label2";
			label2.Size = new Size(78, 19);
			label2.TabIndex = 1;
			label2.Text = "Last name";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 22);
			label1.Name = "label1";
			label1.Size = new Size(81, 19);
			label1.TabIndex = 0;
			label1.Text = "First name";
			// 
			// btnExit
			// 
			btnExit.Location = new Point(520, 163);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 3;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// frmBai3_venha
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(626, 428);
			Controls.Add(btnExit);
			Controls.Add(groupBox1);
			Controls.Add(trvDanhBa);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai3_venha";
			Text = "frmBTVN2";
			Load += frmBai3_venha_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TreeView trvDanhBa;
		private GroupBox groupBox1;
		private TextBox txtFirstName;
		private Button btnAdd;
		private TextBox txtLastName;
		private Label label2;
		private Label label1;
		private Button btnExit;
	}
}