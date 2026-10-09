using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4c
{
	public partial class frmBai1BTVN : Form
	{
		// Các biến toàn cục lưu trữ trạng thái tính toán
		private double soThuNhat = 0;
		private string phepTinh = "";
		private bool isPhepTinhPressed = false;
		public frmBai1BTVN()
		{
			InitializeComponent();
		}
		//hàm nhập
		private void NhapSo(string so)
		{
			if (txtHienThi.Text == "0" || isPhepTinhPressed)
			{
				txtHienThi.Text = so;
				isPhepTinhPressed = false;
			}
			else
			{
				txtHienThi.Text += so;
			}
		}
		//hàm chọn
		private void ChonPhepTinh(string pt)
		{
			soThuNhat = double.Parse(txtHienThi.Text);
			phepTinh = pt;
			isPhepTinhPressed = true;
		}
		//các sự kiện
		private void btn1_Click(object sender, EventArgs e)
		{
			NhapSo("1");
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			NhapSo("2");
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			NhapSo("3");
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			NhapSo("4");
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			NhapSo("5");
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			NhapSo("6");
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			NhapSo("7");
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			NhapSo("8");
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			NhapSo("9");
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			NhapSo("0");
		}


		private void btnXoa_Click(object sender, EventArgs e)
		{
			txtHienThi.Text = "0";
			soThuNhat = 0;
			phepTinh = "";
			isPhepTinhPressed = false;
		}


		private void btnCong_Click(object sender, EventArgs e)
		{
			ChonPhepTinh("+");
		}

		private void btnTru_Click(object sender, EventArgs e)
		{
			ChonPhepTinh("-");
		}

		private void btnNhan_Click(object sender, EventArgs e)
		{
			ChonPhepTinh("*");
		}

		private void btnChia_Click(object sender, EventArgs e)
		{
			ChonPhepTinh("/");
		}

		private void btnBang_Click(object sender, EventArgs e)
		{
			double soThuHai = double.Parse(txtHienThi.Text);
			double ketQua = 0;

			switch (phepTinh)
			{
				case "+":
					ketQua = soThuNhat + soThuHai;
					break;
				case "-":
					ketQua = soThuNhat - soThuHai;
					break;
				case "*":
					ketQua = soThuNhat * soThuHai;
					break;
				case "/":
					if (soThuHai != 0)
					{
						ketQua = soThuNhat / soThuHai;
					}
					else
					{
						MessageBox.Show("Không thể chia cho số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txtHienThi.Text = "0";
						return;
					}
					break;
				default:
					return;
			}

			txtHienThi.Text = ketQua.ToString();
			isPhepTinhPressed = true;
			phepTinh = "";
		}

		private void txtHienThi_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
