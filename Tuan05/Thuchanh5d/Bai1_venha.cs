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
	public partial class frmBai1_venha : Form
	{
		// Khai báo tổng số giây đếm ngược (Ví dụ: 30 phút = 30 * 60 = 1800 giây)
		private int tongSoGiay = 30 * 60;
		public frmBai1_venha()
		{
			InitializeComponent();
		}

		private void frmBai1_venha_Load(object sender, EventArgs e)
		{
			CapNhatHienThi();
		}

		private void btnBatDau_Click(object sender, EventArgs e)
		{
			// Bật Timer chạy
			timer1.Start();

			// Vô hiệu hóa nút bấm để tránh bấm nhiều lần liên tiếp khi đang đếm ngược
			btnBatDau.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (tongSoGiay > 0)
			{
				tongSoGiay--; // Giảm đi 1 giây
				CapNhatHienThi();
			}
			else
			{
				// Khi thời gian về 0
				timer1.Stop();
				MessageBox.Show("Đã hết thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnBatDau.Enabled = true;
				tongSoGiay = 30 * 60; // Reset lại thời gian nếu muốn
				CapNhatHienThi();
			}
		}

		// Hàm phụ trợ định dạng và hiển thị phút:giây lên Label
		private void CapNhatHienThi()
		{
			int phut = tongSoGiay / 60;
			int giay = tongSoGiay % 60;

			// Định dạng chuỗi luôn có 2 chữ số (ví dụ: 09:05)
			label1.Text = $"{phut:D2}:{giay:D2}";
		}
	}
}
