using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;
namespace Thuchanh6a
{
	public partial class Bai1_2 : Form

	{
		SqlConnection connsql;
		public Bai1_2()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				// Ki?m tra k?t n?i tr??c khi m?
				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				// Xác ??nh chu?i truy v?n Insert
				string insertString = "insert into Khoa values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";

				// Khai báo SqlCommand
				SqlCommand cmd = new SqlCommand(insertString, connsql);

				
				cmd.ExecuteNonQuery();

				// Ki?m tra k?t n?i tr??c khi ?óng
				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Th?t b?i: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				// Xác ??nh chu?i truy v?n Update[cite: 5]
				string updateString = "update Khoa set TenKhoa = N'" + txtTenKhoa.Text + "' where MaKhoa = '" + txtMaKhoa.Text + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("S?a thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Th?t b?i: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				// Xác ??nh chu?i truy v?n Delete[cite: 5]
				string deleteString = "delete Khoa where MaKhoa = '" + txtMaKhoa.Text + "'";

				SqlCommand cmd = new SqlCommand(deleteString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Th?t b?i: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
