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
	public partial class frmBai3_venha : Form
	{
		public frmBai3_venha()
		{
			InitializeComponent();
		}

		private void frmBai3_venha_Load(object sender, EventArgs e)
		{
			trvDanhBa.Nodes.Clear();

			// Vòng lặp tạo các node gốc từ 'A' đến 'Z'
			for (char c = 'A'; c <= 'Z'; c++)
			{
				trvDanhBa.Nodes.Add(c.ToString(), c.ToString());
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string firstName = txtFirstName.Text.Trim();
			string lastName = txtLastName.Text.Trim();

			if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ First Name và Last Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Theo mẫu trong hình: hiển thị dạng "Last Name, First Name" (hoặc ngược lại tùy quy ước)
			string tenDanhBa = $"{lastName}, {firstName}";

			// Lấy ký tự đầu tiên của Last Name để xác định node cha (A-Z)
			char kyTuDau = char.ToUpper(lastName[0]);

			// Kiểm tra xem ký tự đầu có nằm trong khoảng từ 'A' đến 'Z' không
			if (kyTuDau >= 'A' && kyTuDau <= 'Z')
			{
				// Tìm node cha tương ứng (ví dụ: "B")
				TreeNode parentNode = trvDanhBa.Nodes[kyTuDau.ToString()];

				if (parentNode != null)
				{
					// Thêm tên vào node con của chữ cái đó
					parentNode.Nodes.Add(tenDanhBa);
					parentNode.Expand(); // Mở rộng node ra để nhìn thấy

					MessageBox.Show("Thêm vào danh bạ thành công!", "Thông báo");

					// Xóa trắng ô nhập liệu và đưa con trỏ về First Name
					txtFirstName.Clear();
					txtLastName.Clear();
					txtFirstName.Focus();
				}
			}
			else
			{
				MessageBox.Show("Ký tự đầu tiên của Last Name phải là chữ cái tiếng Anh (A-Z)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Xác nhận",
							  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
