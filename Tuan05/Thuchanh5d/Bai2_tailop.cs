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
	public partial class frmBai2_tailop : Form
	{
		// Biến đánh dấu trạng thái đang ở chế độ Thêm mới hay bình thường
		private bool đangThem = false;
		public frmBai2_tailop()
		{
			InitializeComponent();
		}

		private void TrangThaiBanDau()
		{
			// Các textbox trống và bị khóa (chỉ mở khi nhấn Thêm)
			KhoaMoTextBox(false);
			XoaTrangTextBox();
			btnThem.Text = "Thêm"; 
            btnThem.Enabled = true;
			btnLuu.Enabled = false; 
            btnXoa.Enabled = false; 
		}

		private void frmBai2_tailop_Load(object sender, EventArgs e)
		{
			TrangThaiBanDau();
		}
		private void KhoaMoTextBox(bool trangThai)
		{
			txtSoTaiKhoan.Enabled = trangThai;
			txtTenKhachHang.Enabled = trangThai;
			txtDiaChi.Enabled = trangThai;
			txtSoTien.Enabled = trangThai;
		}

		private void XoaTrangTextBox()
		{
			txtSoTaiKhoan.Clear();
			txtTenKhachHang.Clear();
			txtDiaChi.Clear();
			txtSoTien.Clear();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (btnThem.Text == "Thêm")
			{
				đangThem = true;
				btnThem.Text = "Hủy";
				btnLuu.Enabled = true;
				btnXoa.Enabled = false;

				KhoaMoTextBox(true);
				XoaTrangTextBox();
				txtSoTaiKhoan.Focus();
			}
			else
			{
				TrangThaiBanDau();
				đangThem = false;
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string stk = txtSoTaiKhoan.Text.Trim();
			string ten = txtTenKhachHang.Text.Trim();
			string diachi = txtDiaChi.Text.Trim();
			string sotienStr = txtSoTien.Text.Trim();

			if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sotienStr))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!decimal.TryParse(sotienStr, out decimal sotien))
			{
				MessageBox.Show("Số tiền phải là định dạng số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtSoTien.Focus();
				return;
			}

			// Kiểm tra trùng số tài khoản
			foreach (ListViewItem item in lstvTaiKhoan.Items)
			{
				if (item.SubItems[1].Text.Equals(stk))
				{
					MessageBox.Show("Số tài khoản này đã tồn tại!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtSoTaiKhoan.Focus();
					return;
				}
			}

			int sttMoi = lstvTaiKhoan.Items.Count + 1;

			// Thêm vào ListView
			ListViewItem lvi = new ListViewItem(sttMoi.ToString()); // Cột 0: STT
			lvi.SubItems.Add(stk);                                  // Cột 1: Số tài khoản
			lvi.SubItems.Add(ten);                                  // Cột 2: Tên khách hàng
			lvi.SubItems.Add(diachi);                               // Cột 3: Địa chỉ
			lvi.SubItems.Add(sotien.ToString("N0"));                // Cột 4: Số tiền (có định dạng dấu phẩy)

			lstvTaiKhoan.Items.Add(lvi);

			TinhTongTien();
			TrangThaiBanDau();
			đangThem = false;
		}

		// 7. Hàm tính Tổng tiền và hiển thị
		private void TinhTongTien()
		{
			decimal tong = 0;
			foreach (ListViewItem item in lstvTaiKhoan.Items)
			{
				if (decimal.TryParse(item.SubItems[4].Text.Replace(",", ""), out decimal tien))
				{
					tong += tien;
				}
			}
			txtTongTien.Text = tong.ToString("N0");
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lstvTaiKhoan.SelectedItems.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					foreach (ListViewItem item in lstvTaiKhoan.SelectedItems)
					{
						item.Remove();
					}

					CapNhatLaiSTT();
					TinhTongTien();
					TrangThaiBanDau();
				}
			}
		}
		// 6. Hàm hỗ trợ cập nhật lại STT tự động sau khi xóa
		private void CapNhatLaiSTT()
		{
			for (int i = 0; i < lstvTaiKhoan.Items.Count; i++)
			{
				lstvTaiKhoan.Items[i].Text = (i + 1).ToString();
			}
		}

		private void lstvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstvTaiKhoan.SelectedItems.Count > 0)
			{
				ListViewItem item = lstvTaiKhoan.SelectedItems[0];
				txtSoTaiKhoan.Text = item.SubItems[1].Text;
				txtTenKhachHang.Text = item.SubItems[2].Text;
				txtDiaChi.Text = item.SubItems[3].Text;
				txtSoTien.Text = item.SubItems[4].Text.Replace(",", ""); // Bỏ dấu phẩy để lấy số thuần túy

				KhoaMoTextBox(false); // Chọn dòng trên bảng thì không cho sửa trực tiếp ô text trừ khi ấn thêm
				btnXoa.Enabled = true; // Kích hoạt nút Xóa khi có chọn mẫu tin
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
