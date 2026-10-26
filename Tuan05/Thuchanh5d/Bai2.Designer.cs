namespace Thuchanh5d
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
			btnthem = new Button();
			btnxoa = new Button();
			btnsua = new Button();
			label1 = new Label();
			label2 = new Label();
			txthoten = new TextBox();
			txtmssv = new TextBox();
			lstv1 = new ListView();
			Mssv = new ColumnHeader();
			Hoten = new ColumnHeader();
			SuspendLayout();
			// 
			// btnthem
			// 
			btnthem.Location = new Point(14, 11);
			btnthem.Name = "btnthem";
			btnthem.Size = new Size(106, 28);
			btnthem.TabIndex = 0;
			btnthem.Text = "Thêm";
			btnthem.UseVisualStyleBackColor = true;
			btnthem.Click += btnthem_Click;
			// 
			// btnxoa
			// 
			btnxoa.Location = new Point(127, 11);
			btnxoa.Name = "btnxoa";
			btnxoa.Size = new Size(106, 28);
			btnxoa.TabIndex = 1;
			btnxoa.Text = "Xóa";
			btnxoa.UseVisualStyleBackColor = true;
			btnxoa.Click += btnxoa_Click;
			// 
			// btnsua
			// 
			btnsua.Location = new Point(240, 11);
			btnsua.Name = "btnsua";
			btnsua.Size = new Size(106, 28);
			btnsua.TabIndex = 2;
			btnsua.Text = "Sửa";
			btnsua.UseVisualStyleBackColor = true;
			btnsua.Click += btnsua_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(37, 60);
			label1.Name = "label1";
			label1.Size = new Size(55, 19);
			label1.TabIndex = 3;
			label1.Text = "Mã SV";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(37, 103);
			label2.Name = "label2";
			label2.Size = new Size(55, 19);
			label2.TabIndex = 4;
			label2.Text = "Họ tên";
			// 
			// txthoten
			// 
			txthoten.Location = new Point(98, 103);
			txthoten.Name = "txthoten";
			txthoten.Size = new Size(350, 27);
			txthoten.TabIndex = 5;
			// 
			// txtmssv
			// 
			txtmssv.Location = new Point(98, 60);
			txtmssv.Name = "txtmssv";
			txtmssv.Size = new Size(350, 27);
			txtmssv.TabIndex = 6;
			// 
			// lstv1
			// 
			lstv1.Columns.AddRange(new ColumnHeader[] { Mssv, Hoten });
			lstv1.FullRowSelect = true;
			lstv1.GridLines = true;
			lstv1.Location = new Point(12, 153);
			lstv1.Name = "lstv1";
			lstv1.Size = new Size(449, 212);
			lstv1.TabIndex = 7;
			lstv1.UseCompatibleStateImageBehavior = false;
			lstv1.View = View.Details;
			// 
			// Mssv
			// 
			Mssv.Text = "Mã số SV";
			Mssv.Width = 100;
			// 
			// Hoten
			// 
			Hoten.Text = "Họ tên";
			Hoten.Width = 150;
			// 
			// frmBai2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(473, 367);
			Controls.Add(lstv1);
			Controls.Add(txtmssv);
			Controls.Add(txthoten);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnsua);
			Controls.Add(btnxoa);
			Controls.Add(btnthem);
			Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "frmBai2";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnthem;
		private Button btnxoa;
		private Button btnsua;
		private Label label1;
		private Label label2;
		private TextBox txthoten;
		private TextBox txtmssv;
		private ListView lstv1;
		private ColumnHeader Mssv;
		private ColumnHeader Hoten;
	}
}