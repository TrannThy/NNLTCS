using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh5c
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnHien_Click(object sender, EventArgs e)
		{
			string s = "Dân tộc được chọn: ";

			// Kiểm tra xem người dùng đã chọn item nào chưa (SelectedIndex >= 0)
			if (cbo_dt.SelectedIndex >= 0)
			{
				lbl_Kq.Text = s + cbo_dt.SelectedItem.ToString();
			}

			else
			{
				lbl_Kq.Text = "Bạn chưa chọn dân tộc";
			}
		}

		private void btnLoad_cbo_Click(object sender, EventArgs e)
		{
			string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khac" };

			// Xóa dữ liệu cũ (nếu có) để tránh bị lặp lại khi ấn nhiều lần
			cbo_dt.Items.Clear();

			foreach (string s in dt)
			{
				cbo_dt.Items.Add(s);
			}
		}

		private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Tránh lỗi khi gọi Clear() làm mất item được chọn gây ra SelectedItem = null
			if (cbo_dt.SelectedItem != null)
			{
				MessageBox.Show("Dân tộc được chọn: " + cbo_dt.SelectedItem.ToString(), "Kết quả");
            }
		}
	}
}
