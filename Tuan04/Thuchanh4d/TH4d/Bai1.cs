using System.Windows.Forms;

namespace TH4d
{
	public partial class lblCongTruNhanChia : Form
	{
		public lblCongTruNhanChia()
		{
			InitializeComponent();
		}

		public class TinhToan
		{
			private float _a, _b;

			public float b
			{
				get { return _b; }
				set { _b = value; }
			}

			public float a
			{
				get { return _a; }
				set { _a = value; }
			}

			public TinhToan()
			{
				a = b = 0;
			}

			public TinhToan(float a, float b)
			{
				_a = a;
				_b = b;
			}

			public float Cong() { return _a + _b; }
			public float Tru() { return _a - _b; }
			public float Nhan() { return _a * _b; }
			public float Chia() { return _a / _b; }
		}
		//sự kiện
		private void txtA_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void txtB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void btnTinh_Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			bool isError = false;

			// Kiểm tra dữ liệu bằng ErrorProvider
			if (!float.TryParse(txtA.Text, out float a))
			{
				errorProvider1.SetError(txtA, "Vui lòng nhập số hợp lệ!");
				isError = true;
			}

			if (!float.TryParse(txtB.Text, out float b))
			{
				errorProvider1.SetError(txtB, "Vui lòng nhập số hợp lệ!");
				isError = true;
			}

			if (isError) return;

			// Gọi class TinhToan theo hướng dẫn
			TinhToan dt = new TinhToan(a, b);
			string s = "Kết quả là: \n";

			if (rbtnCong.Checked)
			{
				float kq = dt.Cong();
				txtKetQua.Text = kq.ToString();
				MessageBox.Show(s + a + " + " + b + " = " + kq);
			}
			else if (rbtnTru.Checked)
			{
				float kq = dt.Tru();
				txtKetQua.Text = kq.ToString();
				MessageBox.Show(s + a + " - " + b + " = " + kq);
			}
			else if (rbtnNhan.Checked)
			{
				float kq = dt.Nhan();
				txtKetQua.Text = kq.ToString();
				MessageBox.Show(s + a + " * " + b + " = " + kq);
			}
			else if (b != 0)
			{
				float kq = dt.Chia();
				txtKetQua.Text = kq.ToString();
				MessageBox.Show(s + a + " / " + b + " = " + kq);
			}
			else
			{
				errorProvider1.SetError(txtB, "Mẫu số phải khác 0!");
				MessageBox.Show("Phép chia bị lỗi!");
			}
		}

		private void lblCongTruNhanChia_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
											MessageBoxButtons.YesNo,
											MessageBoxIcon.Question);

			if (r == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
	}

}