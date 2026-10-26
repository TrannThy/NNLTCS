using System.Data;
using System.Data.SqlClient;

namespace Thuchanh6b
{
	public partial class frmBai1_2 : Form
	{
		SqlConnection connsql;
		public frmBai1_2()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
		}

		// Hàm ki?m tra trùng mã khoa
		bool KT_MaKhoa(string ma)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed)
				{
					connsql.Open();
				}

				string selectString = "select count(*) from Khoa where MaKhoa = '" + ma + "'";
				SqlCommand cmd = new SqlCommand(selectString, connsql);
				int count = (int)cmd.ExecuteScalar();

				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}

				if (count >= 1)
				{
					return false; // ?ã t?n t?i (b? trùng)
				}
				return true; // Không trùng
			}
			catch (Exception)
			{
				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}
				return false;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (KT_MaKhoa(txtMaKhoa.Text.Trim()) == true)
				{
					if (connsql.State == ConnectionState.Closed)
					{
						connsql.Open();
					}

					string insertString = "insert into Khoa values('" + txtMaKhoa.Text.Trim() + "', N'" + txtTenKhoa.Text.Trim() + "')";
					SqlCommand cmd = new SqlCommand(insertString, connsql);
					cmd.ExecuteNonQuery();

					if (connsql.State == ConnectionState.Open)
					{
						connsql.Close();
					}

					MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Trùng mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}
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

				string deleteString = "delete Khoa where MaKhoa = '" + txtMaKhoa.Text.Trim() + "'";

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
				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}
				MessageBox.Show("Th?t b?i! L?i: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				string updateString = "update Khoa set TenKhoa = N'" + txtTenKhoa.Text.Trim() + "' where MaKhoa = '" + txtMaKhoa.Text.Trim() + "'";

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
				if (connsql.State == ConnectionState.Open)
				{
					connsql.Close();
				}
				MessageBox.Show("Th?t b?i! L?i: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
