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

namespace Thuchanh5d
{
	public partial class frmBai1_nangcao_Bai7 : Form
	{
		SqlConnection connsql;
		public frmBai1_nangcao_Bai7()
		{
			InitializeComponent();
			string chuoiketnoi = @"Data Source=TRANTHY\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True";
			connsql = new SqlConnection(chuoiketnoi);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra các trường không được để trống theo yêu cầu đề bài
				if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
					string.IsNullOrWhiteSpace(txtMaSV.Text) ||
					string.IsNullOrWhiteSpace(txtHoTen.Text) ||
					string.IsNullOrWhiteSpace(txtNgaySinh.Text))
				{
					MessageBox.Show("Mã lớp, Mã sinh viên, Họ tên và Ngày sinh không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				string insertString = "insert into SinhVien values('" + txtMaSV.Text.Trim() + "', '" + txtMaLop.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', '" + txtNgaySinh.Text.Trim() + "')";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearTextBoxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thêm thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtMaSV.Text))
				{
					MessageBox.Show("Mã sinh viên không được để trống khi sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				// Cập nhật thông tin dựa theo MaSinhVien
				string updateString = "update SinhVien set MaLop = '" + txtMaLop.Text.Trim() +
									  "', HoTen = N'" + txtHoTen.Text.Trim() +
									  "', NgaySinh = '" + txtNgaySinh.Text.Trim() +
									  "' where MaSinhVien = '" + txtMaSV.Text.Trim() + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Sửa thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearTextBoxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sửa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtMaSV.Text))
				{
					MessageBox.Show("Vui lòng nhập Mã sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					if (connsql.State == ConnectionState.Closed)
					{
						connsql.Open();
					}

					string deleteString = "delete SinhVien where MaSinhVien = '" + txtMaSV.Text.Trim() + "'";
					SqlCommand cmd = new SqlCommand(deleteString, connsql);
					cmd.ExecuteNonQuery();

					if (connsql.State == ConnectionState.Open)
					{
						connsql.Close();
					}

					MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearTextBoxes();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xóa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// Hàm phụ trợ làm sạch ô nhập
		private void ClearTextBoxes()
		{
			txtMaLop.Clear();
			txtMaSV.Clear();
			txtHoTen.Clear();
			txtNgaySinh.Clear();
			txtMaLop.Focus();
		}
	}
}
