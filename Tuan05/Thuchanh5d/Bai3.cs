using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh5d
{
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnLuuFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog svg = new SaveFileDialog();
			svg.Filter = "Text files | *.txt"; // Lọc đuôi file *.txt

			if (svg.ShowDialog() == DialogResult.OK)
			{
				string filename = svg.FileName;

				// Tạo file và ghi dữ liệu từ richTextBox1 vào file
				StreamWriter sw = File.CreateText(filename);
				sw.Write(txtNoiDung.Text);
				sw.Close(); // Đóng luồng ghi

				MessageBox.Show("Lưu file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnMoFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			// Lọc loại đuôi file theo mong muốn
			openFileDialog1.Filter = "All Text File (*.txt)|*.txt|All Document (*.pdf)|*.pdf";

            // Nếu người dùng chọn OK trong cửa sổ OpenFileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
				// Đọc dữ liệu từ file txt bằng StreamReader
				StreamReader f = new StreamReader(openFileDialog1.FileName); 
                
                // Đọc toàn bộ nội dung text và gán vào richTextBox1
                txtNoiDung.Text = f.ReadToEnd(); 
                
                // Đóng luồng đọc
                f.Close();
            }
		}
	}
}
