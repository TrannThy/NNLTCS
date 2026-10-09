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
	public partial class frmBai5 : Form
	{
		public frmBai5()
		{
			InitializeComponent();
		}
		//hàm đọc số
		private string DocSoTu1Den999(int n)
		{
			string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

			int tram = n / 100;
			int chuc = (n % 100) / 10;
			int donVi = n % 10;

			string result = "";

			// Xử lý hàng trăm
			if (tram > 0)
			{
				result += chuSo[tram] + " Trăm";
			}

			// Xử lý hàng chục
			if (chuc > 0)
			{
				if (tram > 0) result += " ";
				if (chuc == 1)
				{
					result += "Mười";
				}
				else
				{
					result += chuSo[chuc] + " Mươi";
				}
			}
			else if (tram > 0 && donVi > 0)
			{
				// Ví dụ: 105 -> Một Trăm Lẻ Năm
				result += " Lẻ";
			}

			// Xử lý hàng đơn vị
			if (donVi > 0)
			{
				if (result != "") result += " ";

				if (donVi == 1 && chuc > 1)
				{
					result += "Mốt"; // Ví dụ: 21 -> Hai Mươi Mốt
				}
				else if (donVi == 5 && chuc > 0)
				{
					result += "Lăm"; // Ví dụ: 15 -> Mười Lăm, 25 -> Hai Mươi Lăm
				}
				else
				{
					result += chuSo[donVi];
				}
			}

			return result;
		}
		private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Chặn ký tự không phải số
			}
		}

		private void txtNhapSo_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtKetQua_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnThucHien_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
			{
				MessageBox.Show("Vui lòng nhập một số nguyên dương từ 1 đến 999!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNhapSo.Focus();
				return;
			}

			if (int.TryParse(txtNhapSo.Text, out int n))
			{
				// Kiểm tra phạm vi từ 1 đến 999
				if (n < 1 || n > 999)
				{
					MessageBox.Show("Giá trị nhập vào phải nằm trong khoảng từ 1 đến 999!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtNhapSo.SelectAll();
					txtNhapSo.Focus();
					return;
				}

				// Gọi hàm đọc số và hiển thị kết quả lên ô txtKetQua
				txtKetQua.Text = DocSoTu1Den999(n);
			}
			else
			{
				MessageBox.Show("Số nhập vào không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			txtNhapSo.Clear();
			txtKetQua.Clear();
			txtNhapSo.Focus();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmBai5_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?",
												  "Xác nhận thoát",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question); 

            if (result == DialogResult.No) 
            {
				e.Cancel = true; // Hủy đóng form
			}
		}
	}
}
