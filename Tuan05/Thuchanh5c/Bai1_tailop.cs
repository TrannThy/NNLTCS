using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Thuchanh5c
{
	public partial class frmBai1_tailop : Form
	{
		public frmBai1_tailop()
		{
			InitializeComponent();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			// Kiểm tra dữ liệu nhập vào có phải số nguyên dương hay không
			if (!int.TryParse(txtNhapSo.Text.Trim(), out int n) || n <= 0)
			{
				MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtNhapSo.Clear();
				txtNhapSo.Focus();
				return;
			}

			// Kiểm tra xem số vừa nhập đã tồn tại trong ComboBox chưa
			if (cboSo.Items.Contains(n))
			{
				MessageBox.Show("Số này đã tồn tại trong ComboBox!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				cboSo.Items.Add(n); // Thêm vào combobox
			}

			// Xóa dữ liệu trong textbox và đặt lại con trỏ (focus)
			txtNhapSo.Clear();
			txtNhapSo.Focus();
		}
		//sự kiện cboSo
		private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
		{
			lstUocSo.Items.Clear();

			if (cboSo.SelectedItem != null)
			{
				int n = Convert.ToInt32(cboSo.SelectedItem);

				// Tìm và thêm các ước số của n vào ListBox
				for (int i = 1; i <= n; i++)
				{
					if (n % i == 0)
					{
						lstUocSo.Items.Add(i);
					}
				}
			}
		}

		//sự kiện nút tính tổng ước
		private void btnTongUoc_Click(object sender, EventArgs e)
		{
			if (lstUocSo.Items.Count == 0)
			{
				MessageBox.Show("Chưa có danh sách ước số để tính!", "Thông báo");
				return;
			}

			int tong = 0;
			foreach (var item in lstUocSo.Items)
			{
				tong += Convert.ToInt32(item);
			}

			MessageBox.Show($"Tổng các ước số là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		//sự kiện nút đếm số lượng chẵn
		private void btnSoLuongChan_Click(object sender, EventArgs e)
		{
			if (lstUocSo.Items.Count == 0)
			{
				MessageBox.Show("Chưa có danh sách ước số để tính!", "Thông báo");
				return;
			}

			int dem = 0;
			foreach (var item in lstUocSo.Items)
			{
				int val = Convert.ToInt32(item);
				if (val % 2 == 0)
				{
					dem++;
				}
			}

			MessageBox.Show($"Số lượng các ước số chẵn là: {dem}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		// Hàm phụ trợ kiểm tra số nguyên tố
		private bool LaSoNguyenTo(int x)
		{
			if (x < 2) return false;
			for (int i = 2; i <= Math.Sqrt(x); i++)
			{
				if (x % i == 0) return false;
			}
			return true;
		}

		private void btnSoLuongNguyenTo_Click(object sender, EventArgs e)
		{
			if (lstUocSo.Items.Count == 0)
			{
				MessageBox.Show("Chưa có danh sách ước số để tính!", "Thông báo");
				return;
			}

			int dem = 0;
			foreach (var item in lstUocSo.Items)
			{
				int val = Convert.ToInt32(item);
				if (LaSoNguyenTo(val))
				{
					dem++;
				}
			}
			MessageBox.Show($"Số lượng các ước số nguyên tố là: {dem}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		//nút thoát
		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận",
							  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
