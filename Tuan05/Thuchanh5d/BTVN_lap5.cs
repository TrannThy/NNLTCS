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
	public partial class frmBTVN_lap5 : Form
	{
		public frmBTVN_lap5()
		{
			InitializeComponent();
		}



		private void BaidemoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDemoTimer frm = new frmDemoTimer();
			frm.Show();
		}

		private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBai2 frm1 = new frmBai2();
			frm1.Show();
		}

		private void bài3TạiLớpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBai3 frm2 = new frmBai3();
			frm2.Show();
		}

		private void bài1TạiLớpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmBai1_tailop frm3 = new frmBai1_tailop();
			frm3.Show();
		}

		private void bài2TạiLớpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmBai2_tailop frm4 = new frmBai2_tailop();
			frm4.Show();
		}

		private void bài1VềNhàToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBai1_venha frm5 = new frmBai1_venha();
			frm5.Show();
		}

		private void bài1NângCaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBai1_nangcao frm6 = new frmBai1_nangcao();
			frm6.Show();
		}
	}
}
