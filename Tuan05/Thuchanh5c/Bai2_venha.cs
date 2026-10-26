using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh5c
{
	public partial class frmBai2_venha : Form
	{
		public frmBai2_venha()
		{
			InitializeComponent();
		}

		private void btnNhap_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtNhapSo.Text.Trim(), out int n))
			{
				lstDanhSach.Items.Add(n);
				txtNhapSo.Clear();
				txtNhapSo.Focus();
			}
			else
			{
				MessageBox.Show("Vui lòng nhập vào một số nguyên hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtNhapSo.Clear();
				txtNhapSo.Focus();
			}
		}

		private void btnTong_Click(object sender, EventArgs e)
		{
			if (lstDanhSach.Items.Count == 0)
			{
				MessageBox.Show("Danh sách Listbox đang trống!", "Thông báo");
				return;
			}

			int tong = 0;
			foreach (var item in lstDanhSach.Items)
			{
				tong += Convert.ToInt32(item);
			}

			MessageBox.Show($"Tổng các phần tử trong Listbox là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnXoaDauCuoi_Click(object sender, EventArgs e)
		{
			if (lstDanhSach.Items.Count == 0)
			{
				MessageBox.Show("Danh sách đang trống!", "Thông báo");
				return;
			}

			// Xóa phần tử đầu tiên
			lstDanhSach.Items.RemoveAt(0);

			// Nếu vẫn còn phần tử thì xóa tiếp phần tử cuối cùng
			if (lstDanhSach.Items.Count > 0)
			{
				lstDanhSach.Items.RemoveAt(lstDanhSach.Items.Count - 1);
			}

			MessageBox.Show("Đã xóa thành công phần tử đầu và cuối!", "Thông báo");
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			if (lstDanhSach.SelectedItems.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn ít nhất một phần tử cần xóa!", "Thông báo");
				return;
			}

			// Duyệt ngược từ dưới lên để xóa các phần tử đang chọn tránh bị lệch index
			for (int i = lstDanhSach.SelectedItems.Count - 1; i >= 0; i--)
			{
				lstDanhSach.Items.Remove(lstDanhSach.SelectedItems[i]);
			}
		}

		private void btnTang2_Click(object sender, EventArgs e)
		{
			if (lstDanhSach.Items.Count == 0)
			{
				MessageBox.Show("Danh sách đang trống!", "Thông báo");
				return;
			}

			for (int i = 0; i < lstDanhSach.Items.Count; i++)
			{
				int val = Convert.ToInt32(lstDanhSach.Items[i]);
				lstDanhSach.Items[i] = val + 2; // Tăng lên 2 và gán ngược lại
			}
		}

		private void btnBinhPhuong_Click(object sender, EventArgs e)
		{
			if (lstDanhSach.Items.Count == 0)
			{
				MessageBox.Show("Danh sách đang trống!", "Thông báo");
				return;
			}

			for (int i = 0; i < lstDanhSach.Items.Count; i++)
			{
				int val = Convert.ToInt32(lstDanhSach.Items[i]);
				lstDanhSach.Items[i] = val * val; // Bình phương giá trị
			}
		}

		private void btnChonChan_Click(object sender, EventArgs e)
		{
			// Bỏ chọn toàn bộ trước khi chọn mới
			lstDanhSach.ClearSelected();

			for (int i = 0; i < lstDanhSach.Items.Count; i++)
			{
				int val = Convert.ToInt32(lstDanhSach.Items[i]);
				if (val % 2 == 0)
				{
					lstDanhSach.SetSelected(i, true); // Đánh dấu chọn dòng số chẵn
				}
			}
		}

		private void btnChonLe_Click(object sender, EventArgs e)
		{
			// Bỏ chọn toàn bộ trước khi chọn mới
			lstDanhSach.ClearSelected();

			for (int i = 0; i < lstDanhSach.Items.Count; i++)
			{
				int val = Convert.ToInt32(lstDanhSach.Items[i]);
				if (val % 2 != 0)
				{
					lstDanhSach.SetSelected(i, true); // Đánh dấu chọn dòng số lẻ
				}
			}
		}

		private void btnKetThuc_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn kết thúc chương trình không?", "Xác nhận",
							  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
