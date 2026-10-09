using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TH4d
{
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}
		// Sự kiện khi Form load: Thiết lập mặc định
		private void frmFormat_Load(object sender, EventArgs e)
		{
			rdoAutoColor.Checked = true;
			chkRegular.Checked = true;
		}

		// Phương thức xử lý việc kết hợp nhiều FontStyle (Bold, Italic)

		private void UpdateFontStyle()
		{
			FontStyle style = FontStyle.Regular;

			if (chkBold.Checked)
			{
				style |= FontStyle.Bold;
			}
			if (chkItalic.Checked)
			{
				style |= FontStyle.Italic;
			}

			lblTittle.Font = new Font(lblTittle.Font.FontFamily, lblTittle.Font.Size, style);
		}

		private void chkRegular_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRegular.Checked)
			{
				chkBold.Checked = false;
				chkItalic.Checked = false;
				chkBoldItalic.Checked = false;
				lblTittle.Font = new Font(lblTittle.Font.FontFamily, lblTittle.Font.Size, FontStyle.Regular);
			}
		}

		private void chkBold_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBold.Checked)
			{
				chkRegular.Checked = false;
				chkBoldItalic.Checked = false;
			}
			UpdateFontStyle();
		}

		private void chkItalic_CheckedChanged(object sender, EventArgs e)
		{
			if (chkItalic.Checked)
			{
				chkRegular.Checked = false;
				chkBoldItalic.Checked = false;
			}
			UpdateFontStyle();
		}

		private void chkBoldItalic_CheckedChanged(object sender, EventArgs e)
		{
			if (chkBoldItalic.Checked)
			{
				chkRegular.Checked = false;
				chkBold.Checked = false;
				chkItalic.Checked = false;
				lblTittle.Font = new Font(lblTittle.Font.FontFamily, lblTittle.Font.Size, (FontStyle)(FontStyle.Bold | FontStyle.Italic));
			}
		}

		private void rdoAutoColor_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoAutoColor.Checked)
			{
				lblTittle.ForeColor = Color.Black; // Mặc định
			}
		}

		private void rdoRed_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoRed.Checked == true)
			{
				lblTittle.ForeColor = Color.Red;
			}
		}

		private void rdoGreen_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoGreen.Checked)
			{
				lblTittle.ForeColor = Color.Green;
			}
		}

		private void rdoBlue_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoBlue.Checked)
			{
				lblTittle.ForeColor = Color.Blue;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Bạn có chắc chắn muốn thoát khỏi chương trình?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}



}
