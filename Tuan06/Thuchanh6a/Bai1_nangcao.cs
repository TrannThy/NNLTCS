using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh6a
{
	public partial class Bai1_nangcao : Form
	{
		SqlConnection connsql;
		public Bai1_nangcao()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Yêu cầu: Mã lớp, Mã sv, Tên sv, Ngày sinh không được để trống
			if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
				string.IsNullOrWhiteSpace(txtMaSV.Text) ||
				string.IsNullOrWhiteSpace(txtHoTen.Text) ||
				string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
				txtNgaySinh.Text.Contains("_")) // Kiểm tra định dạng _/_/__
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Mã lớp, Mã SV, Họ tên, Ngày sinh)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string insertString = "insert into SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop) values('" + txtMaSV.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', '" + txtNgaySinh.Text.Trim() + "', '" + txtMaLop.Text.Trim() + "')";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// Yêu cầu: Mã sinh viên, Họ tên không được để trống
			if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
			{
				MessageBox.Show("Vui lòng nhập Mã sinh viên và Họ tên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				// Xóa theo cả Mã SV và Họ tên để khớp đúng yêu cầu đề bài
				string deleteString = "delete from SinhVien where MaSinhVien = '" + txtMaSV.Text.Trim() + "' and HoTen = N'" + txtHoTen.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(deleteString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Yêu cầu: Mã sinh viên không được để trống, các trường khác nếu nhập sẽ sửa đổi tương ứng
			if (string.IsNullOrWhiteSpace(txtMaSV.Text))
			{
				MessageBox.Show("Mã sinh viên không được để trống khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				// Tạo câu lệnh Update linh hoạt dựa trên các ô có nhập dữ liệu
				string updateString = "update SinhVien set ";
				bool hasUpdate = false;

				if (!string.IsNullOrWhiteSpace(txtHoTen.Text))
				{
					updateString += "HoTen = N'" + txtHoTen.Text.Trim() + "'";
					hasUpdate = true;
				}
				if (!string.IsNullOrWhiteSpace(txtNgaySinh.Text) && !txtNgaySinh.Text.Contains("_"))
				{
					if (hasUpdate) updateString += ", ";
					updateString += "NgaySinh = '" + txtNgaySinh.Text.Trim() + "'";
					hasUpdate = true;
				}
				if (!string.IsNullOrWhiteSpace(txtMaLop.Text))
				{
					if (hasUpdate) updateString += ", ";
					updateString += "MaLop = '" + txtMaLop.Text.Trim() + "'";
					hasUpdate = true;
				}

				if (!hasUpdate)
				{
					MessageBox.Show("Vui lòng nhập ít nhất một trường cần thay đổi thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				updateString += " where MaSinhVien = '" + txtMaSV.Text.Trim() + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
