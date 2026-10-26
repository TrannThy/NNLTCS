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
	public partial class frmBai1_tailop : Form
	{
		public frmBai1_tailop()
		{
			InitializeComponent();
		}

		private void frmBai1_tailop_Load(object sender, EventArgs e)
		{
			string[] dsDanToc = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" };
			cboDanToc.Items.AddRange(dsDanToc);
			if (cboDanToc.Items.Count > 0)
			{
				cboDanToc.SelectedIndex = 0; // Chọn sẵn mục đầu tiên
			}
		}

		// Hàm phụ trợ: Lấy chuỗi ngoại ngữ đã chọn từ các CheckBox
		private string LayNgoaiNgu()
		{
			string nn = "";
			if (chkAnh.Checked) nn += "Anh ";
			if (chkPhap.Checked) nn += "Pháp ";
			if (chkHoa.Checked) nn += "Hoa ";
			return nn.Trim();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string hoTen = txtHoTen.Text.Trim();
			string maSV = txtMaSV.Text.Trim();

			if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(maSV))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra trùng Mã sinh viên
			foreach (ListViewItem item in lstvSinhVien.Items)
			{
				if (item.SubItems[1].Text.Equals(maSV, StringComparison.OrdinalIgnoreCase))
				{
					MessageBox.Show("Mã sinh viên này đã tồn tại trong danh sách!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtMaSV.Focus();
					return;
				}
			}

			string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
			string ngoaiNgu = LayNgoaiNgu();
			string danToc = cboDanToc.Text;

			// Thêm vào ListView
			ListViewItem lvi = new ListViewItem(hoTen); // Cột 1: Họ tên
			lvi.SubItems.Add(maSV);                      // Cột 2: Mã sinh viên
			lvi.SubItems.Add(gioiTinh);                  // Cột 3: Giới tính
			lvi.SubItems.Add(ngoaiNgu);                  // Cột 4: Ngoại ngữ
			lvi.SubItems.Add(danToc);                    // Cột 5: Dân tộc

			lstvSinhVien.Items.Add(lvi);
			XoaTrangForm();
		}
		// Hàm hỗ trợ xóa trắng các ô nhập liệu và mở khóa Mã SV
		private void XoaTrangForm()
		{
			txtHoTen.Clear();
			txtMaSV.Clear();
			txtMaSV.Enabled = true;
			rdoNam.Checked = true;
			rdoNu.Checked = false;
			chkAnh.Checked = false;
			chkPhap.Checked = false;
			chkHoa.Checked = false;
			if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;
			txtHoTen.Focus();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lstvSinhVien.SelectedItems.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn sinh viên cần xóa trên danh sách!", "Thông báo");
				return;
			}

			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				foreach (ListViewItem item in lstvSinhVien.SelectedItems)
				{
					item.Remove();
				}
				XoaTrangForm();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (lstvSinhVien.SelectedItems.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn dòng sinh viên cần sửa trên bảng!", "Thông báo");
				return;
			}

			ListViewItem item = lstvSinhVien.SelectedItems[0];

			string hoTenMoi = txtHoTen.Text.Trim();
			if (string.IsNullOrEmpty(hoTenMoi))
			{
				MessageBox.Show("Họ tên không được để trống!", "Thông báo");
				return;
			}

			// Cập nhật các thông tin khác (Giữ nguyên Mã sinh viên ở SubItems[1])
			item.SubItems[0].Text = hoTenMoi;
			// item.SubItems[1].Text giữ nguyên, không cho sửa Mã SV theo yêu cầu
			item.SubItems[2].Text = rdoNam.Checked ? "Nam" : "Nữ";
			item.SubItems[3].Text = LayNgoaiNgu();
			item.SubItems[4].Text = cboDanToc.Text;

			MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
			XoaTrangForm();
		}

		private void lstvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstvSinhVien.SelectedItems.Count > 0)
			{
				ListViewItem item = lstvSinhVien.SelectedItems[0];
				txtHoTen.Text = item.SubItems[0].Text;
				txtMaSV.Text = item.SubItems[1].Text;
				txtMaSV.Enabled = false; // Khóa ô Mã SV lại không cho sửa trực tiếp

				if (item.SubItems[2].Text == "Nam") rdoNam.Checked = true;
				else rdoNu.Checked = true;

				string nn = item.SubItems[3].Text;
				chkAnh.Checked = nn.Contains("Anh");
				chkPhap.Checked = nn.Contains(" Pháp");
				chkHoa.Checked = nn.Contains("Hoa");

				cboDanToc.Text = item.SubItems[4].Text;
			}
		}



		private void frmBai1_tailop_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận đóng Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.No)
			{
				e.Cancel = true; // Hủy lệnh đóng form
			}
		}

		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnXoa_Click(sender, e);
		}
	}
}
