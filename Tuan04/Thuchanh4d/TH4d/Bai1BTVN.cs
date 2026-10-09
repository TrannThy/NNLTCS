using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4d
{
	public partial class frmBai1BTVN : Form
	{
		// Biến toàn cục tích lũy thống kê
		private int tongSoLuotKhach = 0;
		private double tongTienThuDuoc = 0;
		public frmBai1BTVN()
		{
			InitializeComponent();
		}
		private void KiemTraThongTinNhap()
		{
			bool coHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
			bool coDiaChi = !string.IsNullOrWhiteSpace(txtDiaChi.Text);
			bool coSoNgayO = !string.IsNullOrWhiteSpace(txtSoNgay.Text) &&
							 int.TryParse(txtSoNgay.Text, out int n) && n > 0;

			bool coLoaiPhong = rdoPhongDon.Checked || rdoPhongDoi.Checked || rdoPhongBa.Checked;

			// Khi nhập đầy đủ thông tin thì btnThanhToan có tác dụng
			btnThanhToan.Enabled = coHoTen && coDiaChi && coSoNgayO && coLoaiPhong;
		}


		//các sự kiện
		private void frmBai1BTVN_Load(object sender, EventArgs e)
		{
			// Con trỏ văn bản đặt vào ô tên khách hàng
			txtHoTen.Focus();


		}

		private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Chặn các ký tự không phải là số
			}
		}

		private void txtHoTen_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void txtDiaChi_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void txtSoNgay_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoPhongDon_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoPhongDoi_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}

		private void rdoPhongBa_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}

		private void chkTivi_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}

		private void chkInternet_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}

		private void chkMayNuocNong_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}

		private void chkKaraoke_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}

		private void chkAnSang_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();

		}
		//thanh toán
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			int soNgayO = int.Parse(txtSoNgay.Text);
			double giaPhongNgay = 0;

			// 1. Giá Loại phòng (theo ngày)
			if (rdoPhongDon.Checked) giaPhongNgay = 300000;

			else if (rdoPhongDoi.Checked) giaPhongNgay = 350000;

			else if (rdoPhongBa.Checked) giaPhongNgay = 400000;

			double tienPhong = giaPhongNgay * soNgayO;

			// 2. Giá Tiện nghi (mỗi loại cộng thêm 10.000đ - tính theo lượt ở)
			double tienTienNghi = 0;
			if (chkTivi.Checked) tienTienNghi += 10000;
			if (chkInternet.Checked) tienTienNghi += 10000;
			if (chkMayNuocNong.Checked) tienTienNghi += 10000;

			// 3. Giá Dịch vụ
			double tienDichVu = 0;
			if (chkKaraoke.Checked) tienDichVu += 50000; // Karaoke: 50.000đ
			if (chkAnSang.Checked) tienDichVu += 15000 * soNgayO; // Ăn sáng: 15.000đ/1 ngày

			// Tổng Thành Tiền
			double thanhTien = tienPhong + tienTienNghi + tienDichVu;

			// Hiển thị lên ô Thành tiền
			txtThanhTien.Text = $"{thanhTien:N0} VNĐ";

			// Lưu lại thông tin tích lũy
			tongSoLuotKhach += 1;
			tongTienThuDuoc += thanhTien;

			// btnNhapMoi và btnTongKet sáng lên
			btnNhapMoi.Enabled = true;
			btnTongKet.Enabled = true;
			btnThanhToan.Enabled = false; // Mờ nút thanh toán để tránh bấm trùng
		}

		private void btnNhapMoi_Click(object sender, EventArgs e)
		{
			// Reset các ô nhập
			txtHoTen.Clear();
			txtDiaChi.Clear();
			txtSoNgay.Clear();
			txtThanhTien.Clear();

			// Reset RadioButtons
			rdoPhongDon.Checked = false;
			rdoPhongDoi.Checked = false;
			rdoPhongBa.Checked = false;

			// Reset CheckBoxes
			chkTivi.Checked = false;
			chkInternet.Checked = false;
			chkMayNuocNong.Checked = false;
			chkKaraoke.Checked = false;
			chkAnSang.Checked = false;

			// Trạng thái mờ ban đầu
			btnThanhToan.Enabled = false;
			btnNhapMoi.Enabled = false;

			txtHoTen.Focus();
		}

		private void btnTongKet_Click(object sender, EventArgs e)
		{
			// Ghi thông tin tổng số khách và tổng tiền vào ô tương ứng
			txtSoLuotNguoi.Text = tongSoLuotKhach.ToString();
			txtTongSoTien.Text = $"{tongTienThuDuoc:N0} VNĐ";

			// Khởi tạo lại giá trị tổng = 0
			tongSoLuotKhach = 0;
			tongTienThuDuoc = 0;

			// btnTongKet bị mờ
			btnTongKet.Enabled = false;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmBai1BTVN_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?",
												  "Xác nhận thoát",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question);


			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
	}
}
