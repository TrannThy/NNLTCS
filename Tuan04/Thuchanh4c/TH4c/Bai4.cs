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
	public partial class frmBai4 : Form
	{
		// Danh sách lưu trữ các số nguyên đã nhập
		private List<int> daySo = new List<int>();
		public frmBai4()
		{
			InitializeComponent();
		}

		private void TinhVaHienThiTong()
		{
			int tongTatCa = 0;
			int tongChan = 0;
			int tongLe = 0;

			foreach (int x in daySo)
			{
				tongTatCa += x;
				if (x % 2 == 0)
				{
					tongChan += x;
				}
				else
				{
					tongLe += x;
				}
			}

			// Gán kết quả lên các TextBox
			txtTongCacPhanTu.Text = tongTatCa.ToString();
			txtTongChan.Text = tongChan.ToString();
			txtTongLe.Text = tongLe.ToString();
		}
		private void btnNhap_Click(object sender, EventArgs e)
		{
			// Kiểm tra dữ liệu đầu vào
			if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
			{
				errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một số nguyên!");
				return;
			}

			if (!int.TryParse(txtNhapSo.Text.Trim(), out int n))
			{
				errorProvider1.SetError(txtNhapSo, "Giá trị nhập vào phải là số nguyên!");
				return;
			}

			// Nếu hợp lệ thì xóa báo lỗi
			errorProvider1.SetError(txtNhapSo, "");

			// Thêm số vào danh sách
			daySo.Add(n);

			// Cập nhật hiển thị dãy số vừa nhập
			txtDayVuaNhap.Text = string.Join("  ", daySo);

			// Tự động tính toán các tổng và hiển thị ra các TextBox tương ứng
			TinhVaHienThiTong();

			// Xóa trắng ô nhập và đưa con trỏ chuột quay lại ô nhập
			txtNhapSo.Clear();
			txtNhapSo.Focus();
		}

		private void btnTiepTuc_Click(object sender, EventArgs e)
		{
			daySo.Clear(); // Xóa sạch dữ liệu trong danh sách

			txtNhapSo.Clear();
			txtDayVuaNhap.Clear();
			txtTongCacPhanTu.Clear();
			txtTongChan.Clear();
			txtTongLe.Clear();

			errorProvider1.Clear(); // Xóa lỗi ErrorProvider nếu có
			txtNhapSo.Focus();      // Đưa con trỏ về ô Nhập số
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmBai4_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Xác nhận thoát",
											MessageBoxButtons.YesNo,
											MessageBoxIcon.Question,
											MessageBoxDefaultButton.Button2);

			if (r == DialogResult.No)
			{
				e.Cancel = true; // Hủy thao tác đóng Form
			}
		}
	}

}
