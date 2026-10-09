namespace DentalPaymentApp
{
	public partial class form : Form
	{
		public form()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Phương thức tính tổng tiền dựa trên các dịch vụ đã chọn
		private void GetPay()
		{
			// 1. Kiểm tra xem tên khách hàng đã được nhập hay chưa
			if (string.IsNullOrWhiteSpace(txtName.Text))
			{
				MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtName.Focus(); // Đưa con trỏ chuột về ô nhập tên
				return;
			}

			// 2. Khởi tạo tổng tiền = 0
			long total = 0;

			// 3. Kiểm tra các dịch vụ được chọn và cộng dồn tiền
			if (chkClean.Checked)
			{
				total += 100000;
			}

			if (chkWhitening.Checked)
			{
				total += 1200000;
			}

			if (chkXRay.Checked)
			{
				total += 200000;
			}

			// 4. Cộng tiền trám răng = (số lượng răng) * 80.000
			total += (long)numFilling.Value * 80000;

			// 5. Xuất số tiền ra TextBox txtTotal (định dạng dấu phân cách hàng nghìn)
			txtTotal.Text = "$" + total.ToString("N0");
		}
		private void btnCalc_Click(object sender, EventArgs e)
		{
			GetPay();
		}
	}
}
