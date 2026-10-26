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
	public partial class frmNhapHocVien : Form
	{
		// Khai báo biến lưu tham chiếu của Form chính
		private frmBai1_nangcao formChinh;
		public frmNhapHocVien(frmBai1_nangcao mainForm)
		{
			InitializeComponent();
			formChinh = mainForm;
		}

		private void frmNhapHocVien_Load(object sender, EventArgs e)
		{
			// Nếu trên giao diện chưa thêm thì code sẽ tự thêm vào lúc mở Form
			if (cboLop.Items.Count == 0)
			{
				cboLop.Items.Add("Lớp A");
				cboLop.Items.Add("Lớp B");
			}

			// Tự động chọn sẵn "Lớp A" mặc định
			cboLop.SelectedIndex = 0;
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string hoTen = txtHoTen.Text.Trim();

			// 1. Kiểm tra rỗng Họ và Tên
			if (string.IsNullOrEmpty(hoTen))
			{
				MessageBox.Show("Vui lòng nhập họ và tên học viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtHoTen.Focus(); // Đặt con trỏ chuột vào ô nhập liệu
				return;
			}

			// 2. Kiểm tra an toàn: Người dùng đã chọn Lớp trong ComboBox chưa
			if (cboLop.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn Lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Lấy tên lớp an toàn
			string lopChon = cboLop.SelectedItem.ToString();

			// Đẩy dữ liệu sang Form chính
			if (lopChon == "Lớp A")
			{
				formChinh.ThemHocVienLopA(hoTen);
			}
			else if (lopChon == "Lớp B")
			{
				formChinh.ThemHocVienLopB(hoTen);
			}

			MessageBox.Show("Thêm học viên thành công!", "Thông báo");
			txtHoTen.Clear();
			txtHoTen.Focus();
		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
