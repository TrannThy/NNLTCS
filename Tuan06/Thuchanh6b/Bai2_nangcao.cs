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
	public partial class frmBai2_nangcao : Form
	{
		SqlConnection connsql;
		public frmBai2_nangcao()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
			// Cấu hình cột cho ListView
			SetupListView();

			// Load ComboBox Môn học và nạp toàn bộ dữ liệu khi khởi động form
			LoadComboBoxMonHoc();
			LoadDataToListView("SELECT sv.HoTen, sv.NgaySinh, mh.TenMonHoc, d.Diem FROM Diem d JOIN SinhVien sv ON d.MaSinhVien = sv.MaSinhVien JOIN MonHoc mh ON d.MaMonHoc = mh.MaMonHoc");
		}

		// --- CẤU HÌNH CỘT CHO LISTVIEW ---
		void SetupListView()
		{
			listView1.View = View.Details;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;

			listView1.Columns.Clear();
			listView1.Columns.Add("STT", 50, HorizontalAlignment.Center);
			listView1.Columns.Add("Tên SV", 160, HorizontalAlignment.Left);
			listView1.Columns.Add("Ngày sinh", 140, HorizontalAlignment.Left);
			listView1.Columns.Add("Tên môn học", 160, HorizontalAlignment.Left);
			listView1.Columns.Add("Điểm", 80, HorizontalAlignment.Center);
		}

		// --- LOAD COMBOBOX MÔN HỌC (Có thêm khoảng trắng ở đầu) ---
		void LoadComboBoxMonHoc()
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string query = "SELECT MaMonHoc, TenMonHoc FROM MonHoc";
				SqlCommand cmd = new SqlCommand(query, connsql);
				SqlDataReader rdr = cmd.ExecuteReader();

				DataTable dt = new DataTable();
				dt.Load(rdr);

				// Thêm một dòng trống đầu tiên để biểu thị "tất cả môn học" theo yêu cầu
				DataRow row = dt.NewRow();
				row["MaMonHoc"] = "";
				row["TenMonHoc"] = "--- Tất cả môn học ---";
				dt.Rows.InsertAt(row, 0);

				cmbMonHoc.DataSource = dt;
				cmbMonHoc.DisplayMember = "MaMonHoc"; // Hiển thị mã môn học lên combobox
				cmbMonHoc.ValueMember = "MaMonHoc";

				if (connsql.State == ConnectionState.Open) connsql.Close();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi tải ComboBox: " + ex.Message);
			}
		}

		// --- HÀM ĐỔ DỮ LIỆU VÀ TÍNH TỔNG ĐIỂM LÊN LISTVIEW ---
		void LoadDataToListView(string query)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				SqlCommand cmd = new SqlCommand(query, connsql);
				SqlDataReader rdr = cmd.ExecuteReader();

				listView1.Items.Clear();
				int stt = 1;
				double tongDiem = 0; // Biến tính tổng điểm

				while (rdr.Read())
				{
					string tenSV = rdr["HoTen"].ToString();

					// Định dạng hiển thị ngày sinh
					DateTime ngaySinh = Convert.ToDateTime(rdr["NgaySinh"]);
					string strNgaySinh = ngaySinh.ToString("dd/MM/yyyy HH:mm:ss");

					string tenMonHoc = rdr["TenMonHoc"].ToString();
					double diem = Convert.ToDouble(rdr["Diem"]);

					ListViewItem item = new ListViewItem(stt.ToString());
					item.SubItems.Add(tenSV);
					item.SubItems.Add(strNgaySinh);
					item.SubItems.Add(tenMonHoc);
					item.SubItems.Add(diem.ToString());

					listView1.Items.Add(item);
					stt++;

					tongDiem += diem; // Cộng dồn tổng điểm
				}

				rdr.Close();
				if (connsql.State == ConnectionState.Open) connsql.Close();

				// Gán tổng điểm vào TextBox theo yêu cầu
				txtTongDiem.Text = tongDiem.ToString();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
			}
		}

		private void btnLoc_Click(object sender, EventArgs e)
		{
			string maMon = cmbMonHoc.SelectedValue?.ToString();

			string query = "SELECT sv.HoTen, sv.NgaySinh, mh.TenMonHoc, d.Diem FROM Diem d JOIN SinhVien sv ON d.MaSinhVien = sv.MaSinhVien JOIN MonHoc mh ON d.MaMonHoc = mh.MaMonHoc";

			// Nếu chọn một mã môn cụ thể (khác khoảng trắng/chuỗi rỗng), thêm điều kiện WHERE
			if (!string.IsNullOrEmpty(maMon))
			{
				query += " WHERE d.MaMonHoc = '" + maMon + "'";
			}

			// Gọi lại hàm load dữ liệu với câu truy vấn đã lọc
			LoadDataToListView(query);
		}
	}
}
