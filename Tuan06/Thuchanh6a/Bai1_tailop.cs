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
	public partial class Bai1_tailop : Form
	{
		SqlConnection connsql;
		public Bai1_tailop()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kiểm tra không được để trống theo yêu cầu đề bài
			if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
			{
				MessageBox.Show("Mã môn học và Tên môn học không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string insertString = "insert into MonHoc values('" + txtMaMH.Text.Trim() + "', N'" + txtTenMH.Text.Trim() + "')";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaMH.Text))
			{
				MessageBox.Show("Vui lòng nhập Mã môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string deleteString = "delete MonHoc where MaMonHoc = '" + txtMaMH.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(deleteString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaMH.Text))
			{
				MessageBox.Show("Vui lòng nhập Mã môn học cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string updateString = "update MonHoc set TenMonHoc = N'" + txtTenMH.Text.Trim() + "' where MaMonHoc = '" + txtMaMH.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Sửa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}

