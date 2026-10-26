using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Thuchanh5d
{
	public partial class frmBai1_2 : Form
	{
		// Khai báo đối tượng kết nối
		SqlConnection connsql;
		public frmBai1_2()
		{
			InitializeComponent();
			string chuoiketnoi = @"Data Source=TRANTHY\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True";

			connsql = new SqlConnection(chuoiketnoi);
		}	
		
		
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open(); // Mở kết nối[cite: 36]
				}

				// Câu lệnh SQL thêm dữ liệu[cite: 36]
				string insertString = "insert into Khoa values('" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "')";

				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery(); // Thực thi lệnh SQL[cite: 33, 36]

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close(); // Đóng kết nối[cite: 36]
				}

				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaKhoa.Clear();
				txtTenKhoa.Clear();
				txtMaKhoa.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thêm thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
				{
					if (connsql.State == ConnectionState.Closed)
					{
						connsql.Open();
					}

					// Câu lệnh SQL xóa khoa theo mã khoa[cite: 36]
					string deleteString = "delete Khoa where MaKhoa = '" + txtMaKhoa.Text.Trim() + "'";

					SqlCommand cmd = new SqlCommand(deleteString, connsql);
					cmd.ExecuteNonQuery();

					if (connsql.State == ConnectionState.Open)
					{
						connsql.Close();
					}

					MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtMaKhoa.Clear();
					txtTenKhoa.Clear();
					txtMaKhoa.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xóa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				// Câu lệnh SQL sửa tên khoa theo mã khoa[cite: 36]
				string updateString = "update Khoa set TenKhoa = N'" + txtTenKhoa.Text.Trim() + "' where MaKhoa = '" + txtMaKhoa.Text.Trim() + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaKhoa.Clear();
				txtTenKhoa.Clear();
				txtMaKhoa.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sửa thất bại! Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}


	
}
