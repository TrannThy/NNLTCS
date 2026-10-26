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
	public partial class frmBai1_tailop_Bai7 : Form
	{
		SqlConnection connsql;
		public frmBai1_tailop_Bai7()
		{
			InitializeComponent();

			string chuoiketnoi = @"Data Source=TRANTHY\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True";
			connsql = new SqlConnection(chuoiketnoi);
		}


		//nút thêm
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra rỗng theo yêu cầu đề bài
				if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text))
				{
					MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed) 
				{
					connsql.Open();
				}

				string insertString = "insert into MonHoc values('" + txtMaMon.Text.Trim() + "', N'" + txtTenMon.Text.Trim() + "')";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaMon.Clear();
				txtTenMon.Clear();
				txtMaMon.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thêm thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//nút sửa
		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text))
				{
					MessageBox.Show("Mã môn học và Tên môn học không được để trống khi sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				string updateString = "update MonHoc set TenMonHoc = N'" + txtTenMon.Text.Trim() + "' where MaMonHoc = '" + txtMaMon.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Sửa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaMon.Clear();
				txtTenMon.Clear();
				txtMaMon.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sửa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//nút xóa
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtMaMon.Text))
				{
					MessageBox.Show("Vui lòng nhập Mã môn học cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					if (connsql.State == ConnectionState.Closed)
					{
						connsql.Open();
					}

					string deleteString = "delete MonHoc where MaMonHoc = '" + txtMaMon.Text.Trim() + "'";
					SqlCommand cmd = new SqlCommand(deleteString, connsql);
					cmd.ExecuteNonQuery();

					if (connsql.State == ConnectionState.Open)
					{
						connsql.Close();
					}

					MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtMaMon.Clear();
					txtTenMon.Clear();
					txtMaMon.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xóa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
