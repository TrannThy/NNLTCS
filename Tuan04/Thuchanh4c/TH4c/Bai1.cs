using System.Globalization;
using System.Windows.Forms;
namespace TH4c
{
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}
		//hàm kiểm tra
		private bool KiemTra(TextBox tb, out double giaTri)
		{
			giaTri = 0;

			if (string.IsNullOrWhiteSpace(tb.Text))
			{
				errorProvider1.SetError(tb, "Không được để trống!");
				return false;
			}
			if (!double.TryParse(tb.Text, out giaTri))
			{
				errorProvider1.SetError(tb, "Dữ liệu phải là số!");
				return false;
			}

			errorProvider1.SetError(tb, ""); // hợp lệ → xóa lỗi
			return true;
		}
		private bool LayHaiSo(out double a, out double b)
		{
			bool okA = KiemTra(txta, out a);
			bool okB = KiemTra(txtb, out b);

			if (!okA || !okB)
			{
				// Thông báo lỗi bằng MessageBox
				MessageBox.Show("Dữ liệu nhập không hợp lệ, vui lòng nhập lại!",
								"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		
		//các sự kiện
		private void SoOnly_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			string dauThapPhan = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

			if (char.IsControl(e.KeyChar)) return;   // Backspace, Delete...
			if (char.IsDigit(e.KeyChar)) return;     // chữ số 0-9

			// cho phép dấu '-' ở đầu, chỉ 1 lần
			if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains("-"))
				return;

			// cho phép 1 dấu thập phân
			if (e.KeyChar.ToString() == dauThapPhan && !tb.Text.Contains(dauThapPhan))
				return;

			e.Handled = true; // chặn các ký tự còn lại
		}
		private void btnSum_Click(object sender, EventArgs e)
		{
			if (LayHaiSo(out double a, out double b))
				txtKetQua.Text = (a + b).ToString();
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			if (LayHaiSo(out double a, out double b))
				txtKetQua.Text = (a - b).ToString();
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			if (LayHaiSo(out double a, out double b))
				txtKetQua.Text = (a * b).ToString();
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			if (LayHaiSo(out double a, out double b))
			{
				if (b == 0)
				{
					errorProvider1.SetError(txtb, "b phải khác 0!");
					MessageBox.Show("Không thể chia cho 0!", "Lỗi",
									MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				txtKetQua.Text = (a / b).ToString();
			}
		}

		private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát không?",
											  "Xác nhận",
											  MessageBoxButtons.YesNo,
											  MessageBoxIcon.Question);
			if (kq == DialogResult.No)
				e.Cancel = true; // hủy việc đóng form
		}
	}
}
