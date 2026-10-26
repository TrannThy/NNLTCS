using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Thuchanh5c
{
	public partial class frmBai1_nangcao : Form
	{
		public frmBai1_nangcao()
		{
			InitializeComponent();
		}

		private void btnNgauNhien_Click(object sender, EventArgs e)
		{
			string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
			string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
			string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

			Random rand = new Random();
			lstDanhSach.Items.Clear();

			for (int i = 0; i < 50; i++)
			{
				string ho = HO[rand.Next(HO.Length)];
				string tenLot = TENLOT[rand.Next(TENLOT.Length)];
				string ten = TEN[rand.Next(TEN.Length)];

				string hoVaTen = $"{ho} {tenLot} {ten}";
				lstDanhSach.Items.Add(hoVaTen);
			}
		}

		private void btnXoaChon_Click(object sender, EventArgs e)
		{
			// Duyệt ngược từ dưới lên để xóa các phần tử đang chọn tránh lệch index
			for (int i = lstDanhSach.SelectedItems.Count - 1; i >= 0; i--)
			{
				lstDanhSach.Items.Remove(lstDanhSach.SelectedItems[i]);
			}
		}

		private void btnXoaSon_Click(object sender, EventArgs e)
		{
			for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
			{
				string itemText = lstDanhSach.Items[i].ToString();
				// Tách chuỗi để lấy từ cuối cùng (tên)
				string[] parts = itemText.Split(' ');
				string ten = parts[parts.Length - 1];

				if (ten.Equals("Sơn", StringComparison.OrdinalIgnoreCase))
				{
					lstDanhSach.Items.RemoveAt(i);
				}
			}
		}

		private void btnXoaLe_Click(object sender, EventArgs e)
		{
			for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
			{
				string itemText = lstDanhSach.Items[i].ToString();
				// Lấy từ đầu tiên (họ)
				string ho = itemText.Split(' ')[0];

				if (ho.Equals("Lê", StringComparison.OrdinalIgnoreCase))
				{
					lstDanhSach.Items.RemoveAt(i);
				}
			}
		}

		private void btnThanhHoa_Click(object sender, EventArgs e)
		{

			//}
			int[] viTri = lstDanhSach.SelectedIndices
						   .Cast<int>()
						   .ToArray();

			foreach (int idx in viTri)
			{
				string ten = lstDanhSach.Items[idx].ToString();
				string tenMoi = ten.ToUpper();

				lstDanhSach.Items.RemoveAt(idx);
				lstDanhSach.Items.Insert(idx, tenMoi);
			}

		}
		

		private void btnThanhThuong_Click(object sender, EventArgs e)
		{
			int[] viTri = lstDanhSach.SelectedIndices
						  .Cast<int>()
						  .ToArray();

			foreach (int idx in viTri)
			{
				string ten = lstDanhSach.Items[idx].ToString();
				string tenMoi = ten.ToLower();

				lstDanhSach.Items.RemoveAt(idx);
				lstDanhSach.Items.Insert(idx, tenMoi);
			}
		}

		private void btnVietHoaDauMoiTu_Click(object sender, EventArgs e)
		{
			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

			int[] viTri = lstDanhSach.SelectedIndices
									.Cast<int>()
									.ToArray();

			foreach (int idx in viTri)
			{
				string ten = lstDanhSach.Items[idx].ToString().ToLower();
				string tenMoi = textInfo.ToTitleCase(ten);

				lstDanhSach.Items.RemoveAt(idx);
				lstDanhSach.Items.Insert(idx, tenMoi);
			}
		}

		private void btnXoaTatCa_Click(object sender, EventArgs e)
		{
			lstDanhSach.Items.Clear();
		}

		private void lstDanhSach_DoubleClick(object sender, EventArgs e)
		{
			if (lstDanhSach.SelectedItem != null)
			{
				int idx = lstDanhSach.SelectedIndex;
				string itemCu = lstDanhSach.SelectedItem.ToString();

				// Hiển thị InputBox cho phép nhập tên mới 
				string itemMoi = Interaction.InputBox("Nhập tên mới thay thế:", "Sửa thông tin", itemCu, -1, -1);

				if (!string.IsNullOrWhiteSpace(itemMoi))
				{
					lstDanhSach.Items[idx] = itemMoi;
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một dòng để chỉnh sửa!", "Thông báo");
			}
		}
	}
}
