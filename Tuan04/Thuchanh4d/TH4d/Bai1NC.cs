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
	public partial class frmBai1NC : Form
	{
		// Biến toàn cục tích lũy doanh thu
		private int tongSoKhachHang = 0;
		private double tongTienThanhToan = 0;

		// Biến lưu tiền của khách hiện tại
		private double tienKhachHienTai = 0;
		private int soKhachHienTai = 0;
		public frmBai1NC()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			// Đặt con trỏ văn bản vào ô tên khách hàng
			txtTenKhach.Focus();

		}
		private void KiemTraThongTinNhap()
		{
			bool coTen = !string.IsNullOrWhiteSpace(txtTenKhach.Text);
			bool coSoKhach = !string.IsNullOrWhiteSpace(txtSoKhach.Text);

			bool coNuoc = rdoCafeDen.Checked || rdoCafeDa.Checked || rdoCafeSua.Checked ||
						  rdoCafeSuaDa.Checked || rdoCafeKem.Checked;

			bool coThucAn = chkBanhMyTrung.Checked || chkBanhMyCa.Checked ||
							chkMyTomTrung.Checked || chkMyXaoBo.Checked || chkMyCay.Checked;

			// Bật nút Tính tiền khi đã nhập Tên, Số khách, chọn Nước uống HOẶC Thức ăn
			btnTinhTien.Enabled = coTen && coSoKhach && (coNuoc || coThucAn);
		}
		//các sự kiện
		private void txtTenKhach_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void txtSoKhach_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Chặn các ký tự không phải số
			}
		}

		private void txtSoKhach_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void chkSinhVien_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoCafeDen_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoCafeSua_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoCafeSuaDa_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoCafeDa_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void rdoCafeKem_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void chkBanhMyTrung_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void chkBanhMyCa_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void chkMyTomTrung_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void chkMyXaoBo_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void chkMyCay_CheckedChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			double tongTien = 0;

			// Tính tiền nước uống
			if (rdoCafeDen.Checked) tongTien += 20000;

			else if (rdoCafeDa.Checked) tongTien += 25000;

			else if (rdoCafeSua.Checked) tongTien += 25000;

			else if (rdoCafeSuaDa.Checked) tongTien += 30000;

			else if (rdoCafeKem.Checked) tongTien += 35000;

			// Tính tiền thức ăn
			if (chkBanhMyTrung.Checked) tongTien += 15000;
			if (chkBanhMyCa.Checked) tongTien += 15000;
			if (chkMyTomTrung.Checked) tongTien += 20000;
			if (chkMyXaoBo.Checked) tongTien += 30000;
			if (chkMyCay.Checked) tongTien += 50000;

			// Giảm giá 20% nếu là Sinh viên
			if (chkSinhVien.Checked)
			{
				tongTien = tongTien * 0.8;
			}

			// Lưu thông tin tạm
			tienKhachHienTai = tongTien;
			int.TryParse(txtSoKhach.Text, out soKhachHienTai);

			// Hiển thị lên MessageBox
			MessageBox.Show($"Khách hàng: {txtTenKhach.Text}\nSố tiền phải thanh toán: {tienKhachHienTai:N0} VNĐ",
							"Thông báo tính tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Sau khi tính tiền: btnNhapLai và btnThanhToan sáng lên
			btnNhapLai.Enabled = true;
			btnThanhToan.Enabled = true;
		}
		
		private void btnNhapLai_Click(object sender, EventArgs e)
		{
			// Xóa dữ liệu các ô nhập
			txtTenKhach.Clear();
			txtSoKhach.Clear();
			chkSinhVien.Checked = false;

			// Bỏ chọn nước uống
			rdoCafeDen.Checked = false;
			rdoCafeDa.Checked = false;
			rdoCafeSua.Checked = false;
			rdoCafeSuaDa.Checked = false;
			rdoCafeKem.Checked = false;

			// Bỏ chọn thức ăn
			chkBanhMyTrung.Checked = false;
			chkBanhMyCa.Checked = false;
			chkMyTomTrung.Checked = false;
			chkMyXaoBo.Checked = false;
			chkMyCay.Checked = false;

			// Quay về trạng thái mờ ban đầu
			btnTinhTien.Enabled = false;
			btnNhapLai.Enabled = false;
			btnThanhToan.Enabled = false;

			txtTenKhach.Focus();
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			// Cộng dồn tổng số khách và tổng tiền
			tongSoKhachHang += soKhachHienTai;
			tongTienThanhToan += tienKhachHienTai;

			// Hiển thị lên label/textbox tổng
			txtTongKhachHang.Text = tongSoKhachHang.ToString();
			txtTongTien.Text = $"{tongTienThanhToan:N0} VNĐ";

			// Reset thông tin để sẵn sàng cho nhóm khách mới
			btnNhapLai_Click(sender, e);

			// btnThanhToan bị mờ đi
			btnThanhToan.Enabled = false;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmBai1NC_FormClosing(object sender, FormClosingEventArgs e)
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
