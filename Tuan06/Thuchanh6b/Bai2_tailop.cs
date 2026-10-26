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
	public partial class frmBai2_tailop : Form
	{
		SqlConnection connsql;
		public frmBai2_tailop()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);

			// Đổ dữ liệu lên 2 ComboBox khi mở form
			LoadComboBoxSinhVien();
			LoadComboBoxMonHoc();
		}
		// --- ĐỔ DỮ LIỆU LÊN COMBOBOX SINH VIÊN ---
		void LoadComboBoxSinhVien()
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				SqlDataAdapter da = new SqlDataAdapter("select MaSinhVien, HoTen from SinhVien", connsql);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmbSinhVien.DataSource = dt;
				cmbSinhVien.DisplayMember = "MaSinhVien"; // Hiển thị mã sinh viên
				cmbSinhVien.ValueMember = "MaSinhVien";

				if (connsql.State == ConnectionState.Open) connsql.Close();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi tải sinh viên: " + ex.Message);
			}
		}

		// --- ĐỔ DỮ LIỆU LÊN COMBOBOX MÔN HỌC ---
		void LoadComboBoxMonHoc()
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				SqlDataAdapter da = new SqlDataAdapter("select MaMonHoc, TenMonHoc from MonHoc", connsql);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmbMonHoc.DataSource = dt;
				cmbMonHoc.DisplayMember = "MaMonHoc"; // Hiển thị mã môn học
				cmbMonHoc.ValueMember = "MaMonHoc";

				if (connsql.State == ConnectionState.Open) connsql.Close();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi tải môn học: " + ex.Message);
			}
		}

		// --- KIỂM TRA TRÙNG KHÓA CHÍNH TRONG BẢNG DIỂM ---
		bool KT_TrungDiem(string maSV, string maMH)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				string query = "select count(*) from Diem where MaSinhVien = '" + maSV + "' and MaMonHoc = '" + maMH + "'";
				SqlCommand cmd = new SqlCommand(query, connsql);
				int count = (int)cmd.ExecuteScalar();
				if (connsql.State == ConnectionState.Open) connsql.Close();

				if (count >= 1) return true; // Đã tồn tại (bị trùng)
				return false;
			}
			catch (Exception)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				return false;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			// Yêu cầu: Tất cả thông tin phải được nhập, điểm từ 0 đến 10
			if (cmbSinhVien.SelectedValue == null || cmbMonHoc.SelectedValue == null || string.IsNullOrWhiteSpace(txtDiem.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			float diem;
			if (!float.TryParse(txtDiem.Text.Trim(), out diem) || diem < 0 || diem > 10)
			{
				MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string maSV = cmbSinhVien.SelectedValue.ToString();
			string maMH = cmbMonHoc.SelectedValue.ToString();

			// Kiểm tra không được trùng khóa chính trong bảng Điểm
			if (KT_TrungDiem(maSV, maMH))
			{
				MessageBox.Show("Sinh viên này đã có điểm môn học này rồi (Trùng khóa chính)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				string insertString = "insert into Diem(MaSinhVien, MaMonHoc, Diem) values('" + maSV + "', '" + maMH + "', " + diem + ")";
				SqlCommand cmd = new SqlCommand(insertString, connsql);
				cmd.ExecuteNonQuery();
				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (cmbSinhVien.SelectedValue == null || cmbMonHoc.SelectedValue == null || string.IsNullOrWhiteSpace(txtDiem.Text))
			{
				MessageBox.Show("Vui lòng chọn Sinh viên, Môn học và nhập điểm mới cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			float diem;
			if (!float.TryParse(txtDiem.Text.Trim(), out diem) || diem < 0 || diem > 10)
			{
				MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string maSV = cmbSinhVien.SelectedValue.ToString();
			string maMH = cmbMonHoc.SelectedValue.ToString();

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				string updateString = "update Diem set Diem = " + diem + " where MaSinhVien = '" + maSV + "' and MaMonHoc = '" + maMH + "'";
				SqlCommand cmd = new SqlCommand(updateString, connsql);
				cmd.ExecuteNonQuery();
				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Sửa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (cmbSinhVien.SelectedValue == null || cmbMonHoc.SelectedValue == null)
			{
				MessageBox.Show("Vui lòng chọn Sinh viên và Môn học cần xóa điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string maSV = cmbSinhVien.SelectedValue.ToString();
			string maMH = cmbMonHoc.SelectedValue.ToString();

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				string deleteString = "delete from Diem where MaSinhVien = '" + maSV + "' and MaMonHoc = '" + maMH + "'";
				SqlCommand cmd = new SqlCommand(deleteString, connsql);
				cmd.ExecuteNonQuery();
				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
