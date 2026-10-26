namespace Thuchanh5c
{
	public partial class frmListBox : Form
	{
		public frmListBox()
		{
			InitializeComponent();
		}

		private void btnQuaPhai_Click(object sender, EventArgs e)
		{
			if (lst_Trai.SelectedItem != null)
			{
				// chuyển giá trị chọn bên trái sang phải
				lst_Phai.Items.Add(lst_Trai.SelectedItem);
				// xóa giá trị chọn bên trái
				lst_Trai.Items.Remove(lst_Trai.SelectedItem);
			}
			else
			{
				MessageBox.Show("Vui long chon mot muc ben danh sach trai!", "Thong bao");
			}
		}

		private void btnQuaPhaiAll_Click(object sender, EventArgs e)
		{
			// chuyển giá trị items bên trái sang pahỉ
			lst_Phai.Items.AddRange(lst_Trai.Items);
			// xóa giá trị bên trái
			lst_Trai.Items.Clear();
		}

		private void btnQuaTrai_Click(object sender, EventArgs e)
		{
			if (lst_Phai.SelectedItem != null)
			{
				lst_Trai.Items.Add(lst_Phai.SelectedItem);
				lst_Phai.Items.Remove(lst_Phai.SelectedItem);
			}
			else
			{
				MessageBox.Show("Vui long chon mot muc ben danh sach phai!", "Thong bao");
			}
		}

		private void btnQuaTraiAll_Click(object sender, EventArgs e)
		{
			lst_Trai.Items.AddRange(lst_Phai.Items);
			lst_Phai.Items.Clear();
		}

		private void frmListBox_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Ban co muon thoat khong?", "Xac nhan",
							  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.No)
			{
				e.Cancel = true; // hủy lệnh đóng form
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// duyệt danh sách các ptu được chọn trong lst_Trai
			foreach (var item in lst_Trai.SelectedItems)
			{
				lst_Phai.Items.Add(item);
			}

			//xóa ccác phần tử
			for (int i = lst_Trai.SelectedItems.Count - 1; i >= 0; i--)
			{
				lst_Trai.Items.Remove(lst_Trai.SelectedItems[i]);
			}
		}
	}
}
