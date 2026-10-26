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
	public partial class frmBai1_BTVN : Form
	{
		SqlConnection connsql;
		public frmBai1_BTVN()
		{
			string chuoiketnoi = @"Data Source=TRANTHY\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True";
			connsql = new SqlConnection(chuoiketnoi);
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra các trường không được để trống theo yêu cầu đề bài
				if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
					string.IsNullOrWhiteSpace(txtMaLop.Text) ||
					string.IsNullOrWhiteSpace(txtTenLop.Text))
				{
					MessageBox.Show("Mã khoa, Mã lớp và Tên lớp không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				string insertString = "insert into Lop values('" + txtMaLop.Text.Trim() + "', '" + txtMaKhoa.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "')";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				if (string.IsNullOrWhiteSpace(txtMaLop.Text))
				{
					MessageBox.Show("Mã lớp không được để trống khi sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				// Cập nhật thông tin lớp dựa theo MaLop[cite: 14]
				string updateString = "update Lop set MaKhoa = '" + txtMaKhoa.Text.Trim() +
									  "', TenLop = N'" + txtTenLop.Text.Trim() +
									  "' where MaLop = '" + txtMaLop.Text.Trim() + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Sửa thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				if (string.IsNullOrWhiteSpace(txtMaLop.Text))
				{
					MessageBox.Show("Vui lòng nhập Mã lớp cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					if (connsql.State == ConnectionState.Closed)
					{
						connsql.Open();
					}

					string deleteString = "delete Lop where MaLop = '" + txtMaLop.Text.Trim() + "'";
					SqlCommand cmd = new SqlCommand(deleteString, connsql);
					cmd.ExecuteNonQuery();

					if (connsql.State == ConnectionState.Open)
					{
						connsql.Close();
					}

					MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			txtMaKhoa.Clear();
			txtMaLop.Clear();
			txtTenLop.Clear();
			txtMaKhoa.Focus();
		}
	}
}
