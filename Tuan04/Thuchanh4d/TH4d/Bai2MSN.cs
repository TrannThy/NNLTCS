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

	public partial class frmBai2MSN : Form
	{
		private MangSoNguyen mang = new MangSoNguyen();
		public List<int> Arr { get; set; } = new List<int>();
		public frmBai2MSN()
		{
			InitializeComponent();
		}


		// Hàm hỗ trợ nạp dữ liệu từ TextBox "Nhập mảng"
		private bool LoadMang()
		{
			if (!mang.ParseInput(txtNhapMang.Text))
			{
				return false;
			}
			return true;
		}
		private void CapNhatKetQuaMang()
		{
			txtKetQuaMang.Text = mang.GetArrayString();
		}
	//hàm tìm kiếm
		private void ThucHienTimKiem()
		{
			if (!LoadMang()) return;

			if (rdoTimGiaTri.Checked)
			{
				if (int.TryParse(txtTimGiaTri.Text, out int val))
				{
					int pos = mang.TimViTriTheoGiaTri(val);
					txtSoTimDuoc.Text = (pos != -1) ? pos.ToString() : "Không thấy";
				}
			}
			else if (rdoTimViTri.Checked)
			{
				if (int.TryParse(txtTimViTri.Text, out int pos))
				{
					int val = mang.TimGiaTriTheoViTri(pos);
					txtSoTimDuoc.Text = (val != -1) ? val.ToString() : "K.Hợp lệ";
				}
			}
		}
		
		//sự kiện 
		private void txtNhapMang_TextChanged(object sender, EventArgs e)
		{
			if (LoadMang())
			{
				CapNhatKetQuaMang();
			}
		}
		
		private void txtKetQuaMang_TextChanged(object sender, EventArgs e)
		{

		}

		private void rdoSXTang_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rdoSXGiam_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnThucHien_Click(object sender, EventArgs e)
		{
			if (!LoadMang()) return;

			if (rdoSXTang.Checked)
			{
				mang.SapXepTang();
			}
			else if (rdoSXGiam.Checked)
			{
				mang.SapXepGiam();
			}
			CapNhatKetQuaMang();
		}
	



		public class MangSoNguyen
		{
			public List<int> Arr { get; set; } = new List<int>();

			// Chuyển chuỗi nhập vào thành danh sách số
			public bool ParseInput(string input)
			{
				try
				{
					if (string.IsNullOrWhiteSpace(input)) return false;
					Arr = input.Trim()
							   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
							   .Select(int.Parse)
							   .ToList();
					return Arr.Count > 0;
				}
				catch
				{
					return false;
				}
			}

			public string GetArrayString()
			{
				return string.Join(" ", Arr);
			}

			// 1. Sắp xếp
			public void SapXepTang() => Arr.Sort();
			public void SapXepGiam() => Arr.Sort((a, b) => b.CompareTo(a));

			// 2. Tìm kiếm
			public int TimViTriTheoGiaTri(int val) => Arr.IndexOf(val);
			public int TimGiaTriTheoViTri(int index) => (index >= 0 && index < Arr.Count) ? Arr[index] : -1;

			// 3. Xóa
			public bool XoaTheoGiaTri(int val) => Arr.Remove(val);
			public bool XoaTheoViTri(int index)
			{
				if (index >= 0 && index < Arr.Count)
				{
					Arr.RemoveAt(index);
					return true;
				}
				return false;
			}

			// 4. Thêm
			public bool ThemGiaTriTaiViTri(int val, int index)
			{
				if (index >= 0 && index <= Arr.Count)
				{
					Arr.Insert(index, val);
					return true;
				}
				return false;
			}

			// 5. Tổng
			public int TongMang() => Arr.Sum();
			public int TongChan() => Arr.Where(n => n % 2 == 0).Sum();
			public int TongLe() => Arr.Where(n => n % 2 != 0).Sum();

			// 6. Max - Min
			public int GetMax() => Arr.Max();
			public int GetMin() => Arr.Min();

			// 7. Thay thế
			public bool ThayTheTheoGiaTri(int oldVal, int newVal)
			{
				int idx = Arr.IndexOf(oldVal);
				if (idx != -1)
				{
					Arr[idx] = newVal;
					return true;
				}
				return false;
			}
			public bool ThayTheTheoViTri(int index, int newVal)
			{
				if (index >= 0 && index < Arr.Count)
				{
					Arr[index] = newVal;
					return true;
				}
				return false;
			}
		}

		//các hàm thực hiện
		//xóa
		private void ThucHienXoa()
		{
			if (!LoadMang()) return;

			if (rdoXoaGiaTri.Checked)
			{
				if (int.TryParse(txtXoaGiaTri.Text, out int val))
				{
					mang.XoaTheoGiaTri(val);
					CapNhatKetQuaMang();
				}
			}
			else if (rdoXoaViTri.Checked)
			{
				if (int.TryParse(txtXoaViTri.Text, out int pos))
				{
					mang.XoaTheoViTri(pos);
					CapNhatKetQuaMang();
				}
			}
		}
		//thêm
		private void ThucHienThem()
		{
			if (!LoadMang()) return;

			if (int.TryParse(txtThemGiaTri.Text, out int val) && int.TryParse(txtThemTaiViTri.Text, out int pos))
			{
				if (mang.ThemGiaTriTaiViTri(val, pos))
				{
					CapNhatKetQuaMang();
				}
			}
		}
		//thay thế
		private void ThucHienThayThe()
		{
			if (!LoadMang()) return;

			if (int.TryParse(txtSoThayThe.Text, out int newVal))
			{
				if (rdoThayGiaTri.Checked && int.TryParse(txtThayGiaTri.Text, out int oldVal))
				{
					mang.ThayTheTheoGiaTri(oldVal, newVal);
					CapNhatKetQuaMang();
				}
				else if (rdoThayViTri.Checked && int.TryParse(txtThayViTri.Text, out int pos))
				{
					mang.ThayTheTheoViTri(pos, newVal);
					CapNhatKetQuaMang();
				}
			}
		}
		//sự kiên

		private void rdoTimGiaTri_CheckedChanged(object sender, EventArgs e)
		{
			txtTimGiaTri.Enabled = rdoTimGiaTri.Checked;
			if (rdoTimGiaTri.Checked)
			{
				txtTimViTri.Enabled = false;
				txtTimViTri.Clear();
			}
			ThucHienTimKiem();
		}

		private void rdoTimViTri_CheckedChanged(object sender, EventArgs e)
		{
			txtTimViTri.Enabled = rdoTimViTri.Checked;
			if (rdoTimViTri.Checked)
			{
				txtTimGiaTri.Enabled = false;
				txtTimGiaTri.Clear();
			}
			ThucHienTimKiem();
		}

		private void txtTimGiaTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienTimKiem();
		}

		private void txtTimViTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienTimKiem();
		}

		private void txtSoTimDuoc_TextChanged(object sender, EventArgs e)
		{

		}

		private void rdoXoaGiaTri_CheckedChanged(object sender, EventArgs e)
		{
			txtXoaGiaTri.Enabled = rdoXoaGiaTri.Checked;
			if (rdoXoaGiaTri.Checked)
			{
				txtXoaViTri.Enabled = false;
				txtXoaViTri.Clear();
			}
			ThucHienXoa();
		}

		private void rdoXoaViTri_CheckedChanged(object sender, EventArgs e)
		{
			txtXoaViTri.Enabled = rdoXoaViTri.Checked;
			if (rdoXoaViTri.Checked)
			{
				txtXoaGiaTri.Enabled = false;
				txtXoaGiaTri.Clear();
			}
			ThucHienXoa();
		}

		private void txtXoaGiaTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienXoa();
		}

		private void txtXoaViTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienXoa();
		}

		private void rdoThemGiaTri_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void txtThemTaiViTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienThem();
		}

		private void txtThemGiaTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienThem();
		}

		private void btnTong_Click(object sender, EventArgs e)
		{
			if (!LoadMang()) return;

			txtTongMang.Text = mang.TongMang().ToString();
			txtTongChan.Text = mang.TongChan().ToString();
			txtTongLe.Text = mang.TongLe().ToString();
		}

		private void txtTongMang_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtTongChan_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtTongLe_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (!LoadMang()) return;

			txtGTLN.Text = mang.GetMax().ToString();
			txtGTNN.Text = mang.GetMin().ToString();
		}

		private void txtGTLN_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtGTNN_TextChanged(object sender, EventArgs e)
		{

		}

		private void rdoThayGiaTri_CheckedChanged(object sender, EventArgs e)
		{
			txtThayGiaTri.Enabled = rdoThayGiaTri.Checked;
			if (rdoThayGiaTri.Checked)
			{
				txtThayViTri.Enabled = false;
				txtThayViTri.Clear();
			}
			ThucHienThayThe();
		}

		private void rdoThayViTri_CheckedChanged(object sender, EventArgs e)
		{
			txtThayViTri.Enabled = rdoThayViTri.Checked;
			if (rdoThayViTri.Checked)
			{
				txtThayGiaTri.Enabled = false;
				txtThayGiaTri.Clear();
			}
			ThucHienThayThe();
		}

		private void txtThayGiaTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienThayThe();
		}

		private void txtThayViTri_TextChanged(object sender, EventArgs e)
		{
			ThucHienThayThe();
		}

		private void txtSoThayThe_TextChanged(object sender, EventArgs e)
		{
			ThucHienThayThe();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtNhapMang.Clear();
			txtKetQuaMang.Clear();

			txtTimGiaTri.Clear();
			txtTimViTri.Clear();
			txtSoTimDuoc.Clear();

			txtXoaGiaTri.Clear();
			txtXoaViTri.Clear();

			txtThemGiaTri.Clear();
			txtThemTaiViTri.Clear();

			txtTongMang.Clear();
			txtTongChan.Clear();
			txtTongLe.Clear();

			txtGTLN.Clear();
			txtGTNN.Clear();

			txtThayGiaTri.Clear();
			txtThayViTri.Clear();
			txtSoThayThe.Clear();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmBai2MSN_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận",
												  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
	}
}
