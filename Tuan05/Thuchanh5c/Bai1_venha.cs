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
	public partial class frmBai1_venha : Form
	{
		// Khai báo 2 Dictionary lưu trữ dữ liệu từ điển Anh - Việt và Việt - Anh
		private Dictionary<string, string> tuDienAnhViet;
		private Dictionary<string, string> tuDienVietAnh;
		public frmBai1_venha()
		{
			InitializeComponent();
		}

		private void Bai1_venha_Load(object sender, EventArgs e)
		{
			// Khởi tạo dữ liệu mẫu cho từ điển Anh - Việt
			tuDienAnhViet = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
			{
				{ "student", "Sinh viên, học sinh" },

				{ "teacher", "Giáo viên, giảng viên" },

				{ "worker", "Công nhân, người lao động" },

				{ "hat", "Cái mũ" },

				{ "head", "Cái đầu" },

				{ "mouse", "Con chuột" },

				{ "cat", "Con mèo" },

				{ "dog", "Con chó" },

				{ "snake", "Con rắn" },

				{ "lamb", "Con cừu con" },

				{ "loan", "Khoảnvay, cho vay" },

				{ "frog", "Con ếch" },

				{ "sheep", "Con cừu" }
			};
			// 2. Dữ liệu Từ điển VIỆT - ANH
			tuDienVietAnh = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
			{
				{ "Cái đầu", "head" },
				{ "Cái mũ", "hat" },
				{ "Con chó", "dog" },
				{ "Con chuột", "mouse" },
				{ "Con cừu", "sheep" },
				{ "Con ếch", "frog" },
				{ "Con mèo", "cat" },
				{ "Con rắn", "snake" },
				{ "Công nhân", "worker" },
				{ "Giáo viên", "teacher" },
				{ "Học sinh", "student" },
				{ "Sinh viên", "student" }
			};
			// Nạp dữ liệu ban đầu lên cả 2 Tab
			LoadDuLieuAnhViet();
			LoadDuLieuVietAnh();
		}
		//Nạp dữ liệu từ điển Anh - Việt
		private void LoadDuLieuAnhViet()
		{
			lstTuAnh.Items.Clear();
			cboTuAnh.Items.Clear();
			foreach (var pair in tuDienAnhViet)
			{
				lstTuAnh.Items.Add(pair.Key);
				cboTuAnh.Items.Add(pair.Key);
			}
		}
		//Nạp dữ liệu từ điển Việt - Anh
		private void LoadDuLieuVietAnh()
		{
			lstTuViet.Items.Clear();
			cboTuViet.Items.Clear();
			foreach (var pair in tuDienVietAnh)
			{
				lstTuViet.Items.Add(pair.Key);
				cboTuViet.Items.Add(pair.Key);
			}
		}
		// Xử lý sự kiện gõ tìm kiếm tự động
		private void cboTuAnh_TextUpdate(object sender, EventArgs e)
		{
			string tuCanTim = cboTuAnh.Text;
			int index = cboTuAnh.FindString(tuCanTim); // Tìm kiếm từ khớp gần nhất
			if (index != -1)
			{
				cboTuAnh.SelectedIndex = index;
				cboTuAnh.SelectionStart = tuCanTim.Length;
				cboTuAnh.SelectionLength = cboTuAnh.Text.Length - tuCanTim.Length;
			}
		}
		//Xử lý sự kiện nhấn phím trên ComboBox Anh - Việt
		private void cboTuAnh_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				HienThiNghiaAnhViet();
			}
		}
		//Xử lý sự kiện nhấp đúp chuột vào một từ trong ListBox Anh - Việt để tra nghĩa
		private void lstTuAnh_DoubleClick(object sender, EventArgs e)
		{
			if (lstTuAnh.SelectedItem != null)
			{
				string tuChon = lstTuAnh.SelectedItem.ToString();
				cboTuAnh.Text = tuChon;
				HienThiNghiaAnhViet();
			}
		}
		//Xử lý sự kiện thay đổi lựa chọn trong ListBox Anh - Việt để hiển thị ngay nghĩa
		private void lstTuAnh_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstTuAnh.SelectedItem != null)
			{
				string tu = lstTuAnh.SelectedItem.ToString();
				cboTuAnh.Text = tu;
				if (tuDienAnhViet.ContainsKey(tu))
				{
					txtNghiaViet.Text = tuDienAnhViet[tu];
				}
			}
		}
		//Hàm tra cứu và hiển thị nghĩa tiếng Việt của từ tiếng Anh lên TextBox kết quả
		private void HienThiNghiaAnhViet()
		{
			string tu = cboTuAnh.Text.Trim();
			if (tuDienAnhViet.ContainsKey(tu))
			{
				txtNghiaViet.Text = tuDienAnhViet[tu];
				lstTuAnh.SelectedItem = tu;
			}
			else
			{
				txtNghiaViet.Text = "Không tìm thấy từ này!";
			}
		}

		//nút thoát
		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình từ điển không?", "Xác nhận",
							  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dr == DialogResult.Yes)
			{
				this.Close();
			}
		}







		//Xử lý sự kiện gõ tìm kiếm tự động trên ComboBox Việt - Anh
		private void cboTuViet_TextUpdate(object sender, EventArgs e) 
		{
			string tuCanTim = cboTuViet.Text;
			int index = cboTuViet.FindString(tuCanTim);
			if (index != -1)
			{
				cboTuViet.SelectedIndex = index;
				cboTuViet.SelectionStart = tuCanTim.Length;
				cboTuViet.SelectionLength = cboTuViet.Text.Length - tuCanTim.Length;
			}
		}

		// Hàm hiển thị nghĩa Tiếng Anh sang TextBox bên phải
		private void HienThiNghiaVietAnh()
		{
			string tu = cboTuViet.Text.Trim();
			if (tuDienVietAnh.ContainsKey(tu))
			{
				txtNghiaAnh.Text = tuDienVietAnh[tu];
				lstTuViet.SelectedItem = tu;
			}
			else
			{
				txtNghiaAnh.Text = "Không tìm thấy từ này!";
			}
		}
		//Xử lý sự kiện nhấn phím trên ComboBox Việt - Anh
		private void cboTuViet_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				HienThiNghiaVietAnh();
			}
		}
		//Xử lý sự kiện nhấp đúp chuột vào một từ trong ListBox Việt - Anh để tra nghĩa
		private void lstTuViet_DoubleClick(object sender, EventArgs e)
		{
			if (lstTuViet.SelectedItem != null)
			{
				cboTuViet.Text = lstTuViet.SelectedItem.ToString();
				HienThiNghiaVietAnh();
			}
		}
		//Xử lý sự kiện thay đổi lựa chọn trong ListBox Việt - Anh để hiển thị ngay nghĩa
		private void lstTuViet_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstTuViet.SelectedItem != null)
			{
				string tu = lstTuViet.SelectedItem.ToString();
				cboTuViet.Text = tu;
				if (tuDienVietAnh.ContainsKey(tu))
				{
					txtNghiaAnh.Text = tuDienVietAnh[tu];
				}
			}
		}
	}
}
