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
	public partial class frmBai2_nangcao_Bai7 : Form
	{
		SqlConnection connsql;
		public frmBai2_nangcao_Bai7()
		{
			InitializeComponent();
			string chuoiketnoi = @"Data Source=TRANTHY\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True";
			connsql = new SqlConnection(chuoiketnoi);
		}

		//thêm điểm
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra các trường không được để trống theo yêu cầu đề bài
				if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
					string.IsNullOrWhiteSpace(txtMaMon.Text) ||
					string.IsNullOrWhiteSpace(txtDiem.Text))
				{
					MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Kiểm tra điểm phải là kiểu số hợp lệ
				if (!float.TryParse(txtDiem.Text.Trim(), out float diemSo))
				{
					MessageBox.Show("Điểm phải được nhập vào bằng số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtDiem.Focus();
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				string insertString = "insert into Diem values('" + txtMaSV.Text.Trim() + "', '" + txtMaMon.Text.Trim() + "', " + diemSo + ")";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearTextBoxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thêm thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//xóa điểm
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMon.Text))
				{
					MessageBox.Show("Vui lòng nhập Mã sinh viên và Mã môn học cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng điểm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					if (connsql.State == ConnectionState.Closed)
					{
						connsql.Open();
					}

					string deleteString = "delete Diem where MaSinhVien = '" + txtMaSV.Text.Trim() + "' and MaMonHoc = '" + txtMaMon.Text.Trim() + "'";
					SqlCommand cmd = new SqlCommand(deleteString, connsql);
					cmd.ExecuteNonQuery();

					if (connsql.State == ConnectionState.Open)
					{
						connsql.Close();
					}

					MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearTextBoxes();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xóa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//sửa điểm
		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
				{
					MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống khi sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (!float.TryParse(txtDiem.Text.Trim(), out float diemSo))
				{
					MessageBox.Show("Điểm phải được nhập vào bằng số hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtDiem.Focus();
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				// Cập nhật điểm dựa theo MaSinhVien và MaMonHoc tương ứng
				string updateString = "update Diem set Diem = " + diemSo +
									  " where MaSinhVien = '" + txtMaSV.Text.Trim() +
									  "' and MaMonHoc = '" + txtMaMon.Text.Trim() + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearTextBoxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sửa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// Hàm phụ trợ làm sạch ô nhập
		private void ClearTextBoxes()
		{
			txtMaSV.Clear();
			txtMaMon.Clear();
			txtDiem.Clear();
			txtMaSV.Focus();
		}
	}
}
