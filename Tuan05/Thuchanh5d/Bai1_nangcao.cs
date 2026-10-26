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
	public partial class frmBai1_nangcao : Form
	{
		public frmBai1_nangcao()
		{
			InitializeComponent();
		}
		public void ThemHocVienLopA(string hoTen)
		{
			lstLopA.Items.Add(hoTen);
		}

		public void ThemHocVienLopB(string hoTen)
		{
			lstLopB.Items.Add(hoTen);
		}

		private void mnuNhapMoi_Click(object sender, EventArgs e)
		{
			// Truyền 'this' (Form chính hiện tại) sang Form phụ
			frmNhapHocVien frm = new frmNhapHocVien(this);
			frm.ShowDialog(); // Hiển thị dưới dạng cửa sổ Modal
		}

		private void mnuSangB_Click(object sender, EventArgs e)
		{
			if (lstLopA.SelectedItems.Count == 0)
			{
				MessageBox.Show("Bạn phải chọn học viên trong Lớp A trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
			{
				var item = lstLopA.SelectedItems[i];
				lstLopB.Items.Add(item);
				lstLopA.Items.Remove(item);
			}
		}

		private void mnuSangA_Click(object sender, EventArgs e)
		{
			if (lstLopB.SelectedItems.Count == 0)
			{
				MessageBox.Show("Bạn phải chọn học viên trong Lớp B trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
			{
				var item = lstLopB.SelectedItems[i];
				lstLopA.Items.Add(item);
				lstLopB.Items.Remove(item);
			}
		}

		private void mnuXoa_Click(object sender, EventArgs e)
		{
			if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
			{
				MessageBox.Show("Bạn phải chọn học viên cần xóa trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa các học viên đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
				{
					lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
				}

				for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
				{
					lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
				}
			}
		}

		private void mnuKetThuc_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có muốn dừng chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
