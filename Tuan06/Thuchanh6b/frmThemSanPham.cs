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
	public partial class frmThemSanPham : Form
	{
		SqlConnection connsql;
		public frmThemSanPham()
		{
			InitializeComponent();
			string connectionString = "Data Source=localhost,1433; Initial Catalog=QLCuaHang; User ID=sa; Password=@Zit12456;";
			connsql = new SqlConnection(connectionString);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtTenSP.Text))
			{
				MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				// 1. Thêm sản phẩm vào bảng SANPHAM và lấy ra MaSP vừa được sinh tự động
				string querySP = "INSERT INTO SANPHAM (TenSP) OUTPUT INSERTED.MaSP VALUES (N'" + txtTenSP.Text.Trim() + "')";
				SqlCommand cmdSP = new SqlCommand(querySP, connsql);
				int maSPMoi = (int)cmdSP.ExecuteScalar();

				// 2. Thêm dòng tương ứng vào bảng TONKHO với số lượng mặc định bằng 0
				string queryTonKho = "INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan) VALUES (" + maSPMoi + ", CAST(GETDATE() AS DATE), 0, 0, 0)";
				SqlCommand cmdTonKho = new SqlCommand(queryTonKho, connsql);
				cmdTonKho.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thêm sản phẩm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtTenSP.Clear();
				txtTenSP.Focus();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
