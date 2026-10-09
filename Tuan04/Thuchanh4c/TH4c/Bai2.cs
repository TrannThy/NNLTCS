using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4c
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}


		// Kiểm tra định dạng email
		private bool EmailHopLe(string email)
		{
			return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
		}
		private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
				errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập!");
			else
				errorProvider1.SetError(txtTenDangNhap, "");
		}

		//sự kiện
		private void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
				errorProvider1.SetError(txtEmail, "Vui lòng nhập email!");
			else if (!EmailHopLe(txtEmail.Text))
				errorProvider1.SetError(txtEmail, "Email không đúng định dạng!");
			else
				errorProvider1.SetError(txtEmail, "");
		}

		private void txtMatKhau_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
				errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
			else
				errorProvider1.SetError(txtMatKhau, "");
		}
		
		private void btnDangKy_Click(object sender, EventArgs e)
		{
			bool isValid = true;
			// 1. Kiểm tra Tên đăng nhập (*)
			if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
			{
				errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập Tên đăng nhập!");
				isValid = false;
			}
			else
			{
				errorProvider1.SetError(txtTenDangNhap, "");
			}
			// 2. Kiểm tra Email (*)
			string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				errorProvider1.SetError(txtEmail, "Vui lòng nhập Địa chỉ email!");
				isValid = false;
			}
			else if (!Regex.IsMatch(txtEmail.Text.Trim(), emailPattern))
			{
				errorProvider1.SetError(txtEmail, "Định dạng email không hợp lệ!");
				isValid = false;
			}
			else
			{
				errorProvider1.SetError(txtEmail, "");
			}

			// 3. Kiểm tra Mật khẩu (*)
			if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
			{
				errorProvider1.SetError(txtMatKhau, "Vui lòng nhập Mật khẩu!");
				isValid = false;
			}
			else
			{
				errorProvider1.SetError(txtMatKhau, "");
			}

			// 4. Kiểm tra Xác nhận mật khẩu
			if (txtXacNhanMK.Text != txtMatKhau.Text)
			{
				errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
				isValid = false;
			}
			else
			{
				errorProvider1.SetError(txtXacNhanMK, "");
			}

			// Nếu tất cả hợp lệ, hiển thị MessageBox thông tin
			if (isValid)
			{
				string thôngTin = $"ĐĂNG KÝ THÀNH CÔNG!\n\n" +
								 $"Tên đăng nhập: {txtTenDangNhap.Text}\n" +
								 $"Email: {txtEmail.Text}\n" +
								 $"Mật khẩu: {txtMatKhau.Text}";

				MessageBox.Show(thôngTin, "Thông báo đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Vui lòng điền đầy đủ và chính xác các thông tin bắt buộc!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		
		//sự kiện
		private void txtXacNhanMK_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnDangKy_Click(sender, e); // Gọi sự kiện click của nút Đăng ký
			}
		}

		private void frmBai2_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi Form Đăng ký?",
												 "Xác nhận thoát",
												 MessageBoxButtons.YesNo,
												 MessageBoxIcon.Question,
												 MessageBoxDefaultButton.Button2);

			if (result == DialogResult.No)
			{
				e.Cancel = true; // Hủy thao tác đóng Form
			}
		}
	}
}
