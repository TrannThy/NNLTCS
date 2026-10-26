using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh5d
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnthem_Click(object sender, EventArgs e)
		{
			string mssv = txtmssv.Text.Trim();
			string hoten = txthoten.Text.Trim();

			// Kiểm tra trùng Mã số sinh viên
			foreach (ListViewItem row in lstv1.Items)
			{
				if (row.Text.Equals(mssv, StringComparison.OrdinalIgnoreCase))
				{
					MessageBox.Show("Mã số sinh viên này đã tồn tại trong danh sách!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtmssv.Clear();
					txtmssv.Focus();
					return;
				}
			}
			//thêm vào ListView 
			ListViewItem item = new ListViewItem();
			item.Text = mssv; // Cột đầu tiên (MSSV)

			ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
			subitem.Text = hoten; // Cột thứ hai (Họ tên)

			item.SubItems.Add(subitem);
			lstv1.Items.Add(item);

			// Xóa trắng ô nhập liệu sau khi thêm
			txtmssv.Clear();
			txthoten.Clear();
			txtmssv.Focus();
		}

		private void btnxoa_Click(object sender, EventArgs e)
		{

			foreach (ListViewItem lvi in lstv1.SelectedItems)
			{
				lvi.Remove(); // Xóa item đang chọn
			}

			txtmssv.Clear();
			txthoten.Clear();

		}

		private void btnsua_Click(object sender, EventArgs e)
		{
			if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
			{
				ListViewItem item = lstv1.FocusedItem;
				item.SubItems[0].Text = txtmssv.Text;
				item.SubItems[1].Text = txthoten.Text;
			}
		}
	}
}
