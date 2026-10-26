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
	public partial class frmBai1_nangcao : Form
	{
		SqlConnection connsql;
		public frmBai1_nangcao()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLSinhVien; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
			// Cấu hình các cột cho ListView khi form vừa khởi động
			SetupListView();
		}
		// --- CẤU HÌNH CỘT CHO LISTVIEW ---
		void SetupListView()
		{
			listView1.View = View.Details;
			listView1.FullRowSelect = true;
			listView1.GridLines = true;

			listView1.Columns.Clear();
			listView1.Columns.Add("STT", 60, HorizontalAlignment.Center);
			listView1.Columns.Add("Mã lớp", 120, HorizontalAlignment.Left);
			listView1.Columns.Add("Tên lớp", 250, HorizontalAlignment.Left);
			listView1.Columns.Add("Mã khoa", 100, HorizontalAlignment.Center);
		}
		private void btnHienThi_Click(object sender, EventArgs e)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				string query = "select * from Lop";
				SqlCommand cmd = new SqlCommand(query, connsql);
				SqlDataReader rdr = cmd.ExecuteReader();

				// Xóa dữ liệu cũ trên ListView trước khi nạp mới
				listView1.Items.Clear();

				int stt = 1;
				while (rdr.Read())
				{
					string maLop = rdr["MaLop"].ToString();
					string tenLop = rdr["TenLop"].ToString();
					string maKhoa = rdr["MaKhoa"].ToString();

					// Đưa dữ liệu vào dòng của ListView
					ListViewItem item = new ListViewItem(stt.ToString());
					item.SubItems.Add(maLop);
					item.SubItems.Add(tenLop);
					item.SubItems.Add(maKhoa);

					listView1.Items.Add(item);
					stt++;
				}

				rdr.Close();
				if (connsql.State == ConnectionState.Open) connsql.Close();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
