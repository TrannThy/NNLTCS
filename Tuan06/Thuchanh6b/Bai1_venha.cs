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
	public partial class frmBai1_venha : Form
	{
		SqlConnection connsql;
		string connectionString = "Data Source=localhost,1433; Initial Catalog=QLCuaHang; User ID=sa; Password=@Zit12456;Connect Timeout=30;";
		public frmBai1_venha()
		{
			InitializeComponent();
			connsql = new SqlConnection(connectionString);
			// 1. Khi vừa mở form, làm mờ các ô nhập liệu và nút theo đúng yêu cầu
			SetKhoaControls(false);
			LoadComboBoxSanPham();
		}
		// Hàm bật/tắt trạng thái mở/mờ của các control nhập liệu
		void SetKhoaControls(bool trangThai)
		{
			txtMaHD.Enabled = false; // Mã hóa đơn luôn tự động sinh nên chỉ để hiển thị
			cmbMaSP.Enabled = trangThai;
			txtSoLuong.Enabled = trangThai;
			btnThem.Enabled = trangThai;
			btnHuy.Enabled = trangThai;
			btnThanhToan.Enabled = trangThai;
		}

		// Nạp danh sách mã sản phẩm lên ComboBox
		void LoadComboBoxSanPham()
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				SqlDataAdapter da = new SqlDataAdapter("SELECT MaSP, TenSP FROM SANPHAM", connsql);
				DataTable dt = new DataTable();
				da.Fill(dt);

				cmbMaSP.DataSource = dt;
				cmbMaSP.DisplayMember = "MaSP"; // Hiển thị mã sản phẩm
				cmbMaSP.ValueMember = "MaSP";

				if (connsql.State == ConnectionState.Open) connsql.Close();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
			}
		}

		private void thêmSảnPhẩmMớiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmThemSanPham frm = new frmThemSanPham(); // Mở form phụ thêm sản phẩm
			frm.ShowDialog();
		}

		private void tạoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();
					// Câu lệnh SQL tự động tạo tồn kho cho ngày mới dựa theo ngày trước đó
					string query = @"
                        INSERT INTO TONKHO (MaSP, NgayTon, SLDau, SLNhap, SLBan)
                        SELECT MaSP, CAST(GETDATE() AS DATE), (SLDau + SLNhap - SLBan), 0, 0
                        FROM TONKHO
                        WHERE NgayTon = DATEADD(day, -1, CAST(GETDATE() AS DATE))
                        AND NOT EXISTS (SELECT 1 FROM TONKHO WHERE NgayTon = CAST(GETDATE() AS DATE) AND TONKHO.MaSP = MaSP);
                    ";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Đã tạo tồn kho thành công cho ngày mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// --- 2. SỰ KIỆN NÚT "TẠO HÓA ĐƠN MỚI"
		private void btnTaoHoaDomMoi_Click(object sender, EventArgs e)
		{
			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				// Thêm hóa đơn mới với ngày hiện tại và tình trạng thanh toán = 0 (chưa thanh toán), lấy MaHD tự động tăng
				string queryHD = "INSERT INTO HOADON (NgayTao, TinhTrangThanhToan) OUTPUT INSERTED.MaHD VALUES (CAST(GETDATE() AS DATE), N'0')";
				SqlCommand cmdHD = new SqlCommand(queryHD, connsql);
				int maHDMoi = (int)cmdHD.ExecuteScalar();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				// Ghi mã hóa đơn vừa tạo vào textbox mã hóa đơn và bật sáng các control
				txtMaHD.Text = maHDMoi.ToString();
				SetKhoaControls(true);

				MessageBox.Show("Đã tạo hóa đơn mới thành công! Mã hóa đơn: " + maHDMoi, "Thông báo");
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi tạo hóa đơn: " + ex.Message);
			}
		}
		// --- 3. SỰ KIỆN NÚT "THÊM" (Thêm chi tiết hóa đơn và trừ tồn kho)
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaHD.Text) || cmbMaSP.SelectedValue == null || string.IsNullOrWhiteSpace(txtSoLuong.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin số lượng và sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int soLuongBan;
			if (!int.TryParse(txtSoLuong.Text.Trim(), out soLuongBan) || soLuongBan <= 0)
			{
				MessageBox.Show("Số lượng bán phải là số nguyên lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int maHD = int.Parse(txtMaHD.Text.Trim());
			int maSP = int.Parse(cmbMaSP.SelectedValue.ToString());

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();

				// Kiểm tra số lượng tồn trong kho của sản phẩm trong ngày hiện tại
				string queryCheckTon = "SELECT (SLDau + SLNhap - SLBan) AS SLTon FROM TONKHO WHERE MaSP = " + maSP + " AND NgayTon = CAST(GETDATE() AS DATE)";
				SqlCommand cmdCheck = new SqlCommand(queryCheckTon, connsql);
				object result = cmdCheck.ExecuteScalar();

				if (result == null)
				{
					MessageBox.Show("Sản phẩm này chưa được khởi tạo tồn kho cho ngày hôm nay! Vui lòng tạo tồn kho trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					connsql.Close();
					return;
				}

				int slTon = (int)result;

				// Yêu cầu: Số lượng bán phải nhỏ hơn hoặc bằng số lượng tồn kho
				if (soLuongBan > slTon)
				{
					MessageBox.Show("Số lượng bán vượt quá số lượng tồn kho hiện tại! (Tồn kho: " + slTon + ")", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					connsql.Close();
					return;
				}

				// Thêm dòng tin mới vào bảng CHITIET_HOADON
				string queryCTHD = "INSERT INTO CHITIET_HOADON (MaHD, MaSP, SoLuong) VALUES (" + maHD + ", " + maSP + ", " + soLuongBan + ")";
				SqlCommand cmdCTHD = new SqlCommand(queryCTHD, connsql);
				cmdCTHD.ExecuteNonQuery();

				// Cập nhật lại tổng số lượng bán trong bảng TONKHO (Tổng SLBan = Tổng SLBan cũ + số lượng bán mới)
				string queryUpdateTonKho = "UPDATE TONKHO SET SLBan = SLBan + " + soLuongBan + " WHERE MaSP = " + maSP + " AND NgayTon = CAST(GETDATE() AS DATE)";
				SqlCommand cmdUpdate = new SqlCommand(queryUpdateTonKho, connsql);
				cmdUpdate.ExecuteNonQuery();

				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thêm chi tiết hóa đơn thành công và đã cập nhật tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtSoLuong.Clear();
				txtSoLuong.Focus();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Thất bại! Lỗi (Có thể bị trùng khóa chính chi tiết hóa đơn): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			txtSoLuong.Clear();
			SetKhoaControls(false);
		}
		// --- 5. NÚT THANH TOÁN ---
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaHD.Text)) return;

			try
			{
				if (connsql.State == ConnectionState.Closed) connsql.Open();
				// Cập nhật trạng thái hóa đơn thành đã thanh toán (ví dụ: TinhTrangThanhToan = 1)
				string queryPay = "UPDATE HOADON SET TinhTrangThanhToan = N'1' WHERE MaHD = " + txtMaHD.Text.Trim();
				SqlCommand cmdPay = new SqlCommand(queryPay, connsql);
				cmdPay.ExecuteNonQuery();
				if (connsql.State == ConnectionState.Open) connsql.Close();

				MessageBox.Show("Thanh toán hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				SetKhoaControls(false);
				txtMaHD.Clear();
			}
			catch (Exception ex)
			{
				if (connsql.State == ConnectionState.Open) connsql.Close();
				MessageBox.Show("Lỗi thanh toán: " + ex.Message);
			}
		}

	}
}
