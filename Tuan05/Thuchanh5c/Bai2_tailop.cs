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
	public partial class frmBai2_tailop : Form
	{
		public frmBai2_tailop()
		{
			InitializeComponent();
		}

		private void frmBai2_tailop_Load(object sender, EventArgs e)
		{
			string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };

			// Tạo node gốc cho TreeView
			TreeNode rootNode = new TreeNode("Danh sách lớp");
			trv_DanhSach.Nodes.Add(rootNode);

			foreach (string lop in dsLop)
			{
				rootNode.Nodes.Add(lop);       // Thêm vào TreeView
				cboChonLop.Items.Add(lop);     // Thêm vào ComboBox
			}

			if (cboChonLop.Items.Count > 0)
				cboChonLop.SelectedIndex = 0;

			// Ẩn khung thông tin lớp khi vừa mở form[cite: 11]
			grpThemLop.Visible = false;
			chkThemLop.Checked = false;

			trv_DanhSach.ExpandAll();
		}

		private void chkThemLop_CheckedChanged(object sender, EventArgs e)
		{
			grpThemLop.Visible = chkThemLop.Checked;
		}

		private void btnThemLop_Click(object sender, EventArgs e)
		{
			string tenLopMoi = txtTenLop.Text.Trim();
			if (string.IsNullOrEmpty(tenLopMoi))
			{
				MessageBox.Show("Vui lòng nhập tên lớp mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTenLop.Focus();
				return;
			}

			// Kiểm tra trùng tên lớp trong ComboBox hoặc TreeView
			bool isTrung = false;
			foreach (var item in cboChonLop.Items)
			{
				if (item.ToString().Equals(tenLopMoi, StringComparison.OrdinalIgnoreCase))
				{
					isTrung = true;
					break;
				}
			}

			if (isTrung)
			{
				MessageBox.Show("Tên lớp này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtTenLop.Clear();
				txtTenLop.Focus();
				return;
			}

			// Thêm vào node gốc (node thứ 0) của TreeView
			trv_DanhSach.Nodes[0].Nodes.Add(tenLopMoi);
			// Thêm vào ComboBox
			cboChonLop.Items.Add(tenLopMoi);

			MessageBox.Show("Thêm lớp thành công!", "Thông báo");
			txtTenLop.Clear();
			trv_DanhSach.ExpandAll();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			if (cboChonLop.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn lớp cần thêm sinh viên!", "Thông báo");
				return;
			}

			string maSV = txtMaSV.Text.Trim();
			string hoTen = txtHoTen.Text.Trim();
			string diaChi = txtDiaChi.Text.Trim();
			string tenLopChon = cboChonLop.SelectedItem.ToString();

			// Kiểm tra không được để trống thông tin
			if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi))
			{
				MessageBox.Show("Mã SV, Họ Tên và Địa Chỉ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Tìm node lớp tương ứng trong TreeView
			TreeNode nodeLop = null;
			foreach (TreeNode node in trv_DanhSach.Nodes[0].Nodes)
			{
				if (node.Text.Equals(tenLopChon))
				{
					nodeLop = node;
					break;
				}
			}

			if (nodeLop == null)
			{
				MessageBox.Show("Không tìm thấy lớp trong danh sách!", "Lỗi");
				return;
			}

			// Kiểm tra trùng mã sinh viên đã có trong lớp đó chưa
			foreach (TreeNode svNode in nodeLop.Nodes)
			{
				// Cấu trúc chuỗi node con dạng: "MaSV, HoTen"
				if (svNode.Text.StartsWith(maSV + ","))
				{
					MessageBox.Show("Mã sinh viên này đã tồn tại trong lớp!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtMaSV.Focus();
					return;
				}
			}

			// Thêm sinh viên vào cấu trúc phân cấp cây
			// Node cấp 1: "MaSV, HoTen"
			TreeNode nodeSV = nodeLop.Nodes.Add($"{maSV}, {hoTen}");
			// Node cấp 2 con của sinh viên: Địa chỉ
			nodeSV.Nodes.Add(diaChi);

			trv_DanhSach.ExpandAll();
			MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");

			// Xóa trắng ô nhập liệu sau khi thêm
			txtMaSV.Clear();
			txtHoTen.Clear();
			txtDiaChi.Clear();
			txtMaSV.Focus();
		}

		private void trv_DanhSach_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode selectedNode = e.Node;

			// Kiểm tra xem node đang chọn có phải là node sinh viên không 

			if (selectedNode.Level == 2)
			{
				string textSV = selectedNode.Text; // Dạng "MaSV, HoTen"
				string[] parts = textSV.Split(',');

				if (parts.Length >= 2)
				{
					txtMaSV.Text = parts[0].Trim();
					txtHoTen.Text = parts[1].Trim();
				}

				// Lấy thông tin địa chỉ từ node con bên dưới của sinh viên (nếu có)
				if (selectedNode.Nodes.Count > 0)
				{
					txtDiaChi.Text = selectedNode.Nodes[0].Text.Trim();
				}

				// Tự động chọn đúng lớp tương ứng trên ComboBox cho sinh viên đó
				string tenLopCha = selectedNode.Parent.Text;
				cboChonLop.SelectedItem = tenLopCha;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = trv_DanhSach.SelectedNode;

			if (selectedNode == null)
			{
				MessageBox.Show("Vui lòng chọn một sinh viên cần xóa trên cây TreeView!", "Thông báo");
				return;
			}

			// Kiểm tra điều kiện chỉ được xóa node sinh viên 
			if (selectedNode.Level == 2)
			{
				DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên: {selectedNode.Text} không?",
								  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
				{
					selectedNode.Remove(); // Xóa node sinh viên khỏi TreeView
					MessageBox.Show("Đã xóa sinh viên thành công!");

					// Xóa trắng textbox sau khi xóa
					txtMaSV.Clear();
					txtHoTen.Clear();
					txtDiaChi.Clear();
				}
			}
			else
			{
				MessageBox.Show("Chỉ được phép chọn và xóa đối tượng là Sinh viên trên TreeView!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		
		}
	}


}
