using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4c
{
	public partial class frmBai3 : Form
	{
		public frmBai3()
		{
			InitializeComponent();
		}

		// Thuật toán Euclid
		private long TinhUCLN(long a, long b)
		{
			while (b != 0)
			{
				long t = a % b;
				a = b;
				b = t;
			}
			return a;
		}

		//tinh BCNN
		private long TinhBCNN(long a, long b, long ucln)
		{
			if (a == 0 || b == 0) return 0;
			return Math.Abs(a * b) / ucln;
		}
		//sự kiện
		private void btnThucHien_Click(object sender, EventArgs e)
		{
			bool isValid = true;
			long a = 0, b = 0;

			// 1. Kiểm tra ô nhập a
			if (string.IsNullOrWhiteSpace(txtA.Text))
			{
				errorProvider1.SetError(txtA, "Vui lòng nhập số a!");
				isValid = false;
			}
			else if (!long.TryParse(txtA.Text.Trim(), out a) || a <= 0)
			{
				errorProvider1.SetError(txtA, "Vui lòng nhập số nguyên dương!");
				isValid = false;
			}
			else
			{
				errorProvider1.SetError(txtA, "");
			}

			// 2. Kiểm tra ô nhập b
			if (string.IsNullOrWhiteSpace(txtB.Text))
			{
				errorProvider1.SetError(txtB, "Vui lòng nhập số b!");
				isValid = false;
			}
			else if (!long.TryParse(txtB.Text.Trim(), out b) || b <= 0)
			{
				errorProvider1.SetError(txtB, "Vui lòng nhập số nguyên dương!");
				isValid = false;
			}
			else
			{
				errorProvider1.SetError(txtB, "");
			}

			// 3. Nếu dữ liệu không hợp lệ -> Báo lỗi và dừng
			if (!isValid)
			{
				MessageBox.Show("Dữ liệu nhập vào không hợp lệ! Vui lòng kiểm tra lại.", "Lỗi nhập liệu",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 4. Tính toán và hiển thị kết quả
			long ucln = TinhUCLN(a, b);
			long bcnn = TinhBCNN(a, b, ucln);

			txtUCLN.Text = ucln.ToString();
			txtBCNN.Text = bcnn.ToString();
		}

		private void btnTiepTuc_Click(object sender, EventArgs e)
		{
			txtA.Clear();
			txtB.Clear();
			txtUCLN.Clear();
			txtBCNN.Clear();

			errorProvider1.Clear(); // Xóa các thông báo lỗi nếu có
			txtA.Focus();           // Đưa con trỏ chuột về ô a
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
