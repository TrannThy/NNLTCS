using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4d
{
	public partial class frmBai3tailop : Form
	{
		public frmBai3tailop()
		{
			InitializeComponent();
		}

		public class PhuongTrinhBacHai
		{
			public double A { get; set; }
			public double B { get; set; }
			public double C { get; set; }

			public PhuongTrinhBacHai() { }

			public PhuongTrinhBacHai(double a, double b, double c = 0)
			{
				A = a;
				B = b;
				C = c;
			}

			// Phương thức giải phương trình bậc nhất: ax + b = 0
			public string GiaiBacNhat()
			{
				if (A == 0)
				{
					if (B == 0)
						return "Phương trình có vô số nghiệm";
					else
						return "Phương trình vô nghiệm";
				}
				double x = -B / A;
				return $"Phương trình có nghiệm x = {x:F2}";
			}

			// Phương thức giải phương trình bậc hai: ax^2 + bx + c = 0
			public string GiaiBacHai()
			{
				if (A == 0)
				{
					// Nếu a = 0 thì trở thành phương trình bậc nhất bx + c = 0
					PhuongTrinhBacHai pt1 = new PhuongTrinhBacHai { A = B, B = C };
					return pt1.GiaiBacNhat();
				}

				double delta = B * B - 4 * A * C;
				if (delta < 0)
				{
					return "Phương trình vô nghiệm";
				}
				else if (delta == 0)
				{
					double x = -B / (2 * A);
					return $"Phương trình có nghiệm kép x1 = x2 = {x:F2}";
				}
				else
				{
					double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
					double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
					return $"Phương trình có 2 nghiệm phân biệt:\nx1 = {x1:F2}, x2 = {x2:F2}";
				}
			}


		}

		// Bật/tắt nút "Giải" tự động khi nhập đủ dữ liệu
		private void KiemTraThongTinNhap()
		{
			if (rdoBacNhat.Checked)
			{
				btnGiai.Enabled = !string.IsNullOrWhiteSpace(txtA.Text) &&
								  !string.IsNullOrWhiteSpace(txtB.Text);
			}
			else
			{
				btnGiai.Enabled = !string.IsNullOrWhiteSpace(txtA.Text) &&
								  !string.IsNullOrWhiteSpace(txtB.Text) &&
								  !string.IsNullOrWhiteSpace(txtC.Text);
			}
		}


		//sự kiện

		private void rdoBacNhat_CheckedChanged(object sender, EventArgs e)
		{
			bool isBacHai = rdoBacHai.Checked;
			lblC.Enabled = isBacHai;
			txtC.Enabled = isBacHai;
			if (!isBacHai) txtC.Clear();

			KiemTraThongTinNhap();
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
			{
				MessageBox.Show("Dữ liệu nhập vào phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (rdoBacNhat.Checked)
			{
				PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b);
				txtKetQua.Text = pt.GiaiBacNhat();
			}
			else
			{
				if (!double.TryParse(txtC.Text, out double c))
				{
					MessageBox.Show("Vui lòng nhập hệ số c hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);
				txtKetQua.Text = pt.GiaiBacHai();
			}

			// Giải xong thì làm mờ nút Giải theo yêu cầu
			btnGiai.Enabled = false;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmBai3tailop_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void txtA_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void txtB_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}

		private void txtC_TextChanged(object sender, EventArgs e)
		{
			KiemTraThongTinNhap();
		}
	}

}
