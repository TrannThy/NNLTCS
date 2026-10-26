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

namespace Thuchanh6b
{
	public partial class frmBai1_tailop : Form
	{
		SqlConnection connsql;
		public frmBai1_tailop()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
			// Gọi hàm load dữ liệu lên ComboBox ngay khi mở Form
			LoadComboBoxLop();
		}

		void LoadComboBoxLop()
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string query = "select MaLop from Lop";
				SqlCommand cmd = new SqlCommand(query, connsql);
				SqlDataReader rdr = cmd.ExecuteReader();

				DataTable dt = new DataTable();
				dt.Load(rdr);

				cmbMaLop.DataSource = dt;
				cmbMaLop.DisplayMember = "MaLop"; // Hiển thị mã lớp
				cmbMaLop.ValueMember = "MaLop";

				if (connsql.State == ConnectionState.Open) connsql.Close();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
			}
		}
		// --- 2. HÀM KIỂM TRA TRÙNG MÃ SINH VIÊN ---
		bool KT_MaSV(string masv)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string query = "select count(*) from SinhVien where MaSinhVien = '" + masv + "'";
				SqlCommand cmd = new SqlCommand(query, connsql);
				int count = (int)cmd.ExecuteScalar();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				if (count >= 1) return false; // Đã tồn tại (bị trùng)
				return true; // Không trùng
			}
			catch (Exception)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				return false;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kiểm tra không được để trống
			if (cmbMaLop.SelectedValue == null ||
				string.IsNullOrWhiteSpace(txtMaSV.Text) ||
				string.IsNullOrWhiteSpace(txtHoTen.Text) ||
				string.IsNullOrWhiteSpace(txtNgaySinh.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ tất cả các thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				// Kiểm tra tuổi >= 17 (tính theo năm sinh)
				// Giả sử định dạng ngày sinh người dùng nhập chứa năm ở cuối hoặc chuyển đổi được sang DateTime
				DateTime ngaysinh;
				if (!DateTime.TryParse(txtNgaySinh.Text.Trim(), out ngaysinh))
				{
					MessageBox.Show("Định dạng ngày sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int tuoi = DateTime.Now.Year - ngaysinh.Year;
				if (tuoi < 17)
				{
					MessageBox.Show("Sinh viên phải từ 17 tuổi trở lên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Kiểm tra trùng mã sinh viên
				if (KT_MaSV(txtMaSV.Text.Trim()) == false)
				{
					MessageBox.Show("Mã sinh viên bị trùng! Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string maLop = cmbMaLop.SelectedValue.ToString();
				string insertString = "insert into SinhVien(MaSinhVien, HoTen, NgaySinh, MaLop) values('" + txtMaSV.Text.Trim() + "', N'" + txtHoTen.Text.Trim() + "', '" + ngaysinh.ToString("yyyy-MM-dd") + "', '" + maLop + "')";

				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaSV.Text))
			{
				MessageBox.Show("Vui lòng nhập Mã sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string deleteString = "delete from SinhVien where MaSinhVien = '" + txtMaSV.Text.Trim() + "'";
				SqlCommand cmd = new SqlCommand(deleteString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi (có thể do vướng khóa ngoại): " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaSV.Text))
			{
				MessageBox.Show("Vui lòng nhập Mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string maLop = cmbMaLop.SelectedValue.ToString();
				string updateString = "update SinhVien set HoTen = N'" + txtHoTen.Text.Trim() + "', MaLop = '" + maLop + "'";

				if (!string.IsNullOrWhiteSpace(txtNgaySinh.Text))
				{
					DateTime ngaysinh;
					if (DateTime.TryParse(txtNgaySinh.Text.Trim(), out ngaysinh))
					{
						updateString += ", NgaySinh = '" + ngaysinh.ToString("yyyy-MM-dd") + "'";
					}
				}

				updateString += " where MaSinhVien = '" + txtMaSV.Text.Trim() + "'";

				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
