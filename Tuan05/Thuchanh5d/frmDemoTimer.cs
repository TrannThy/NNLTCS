namespace Thuchanh5d
{
	public partial class frmDemoTimer : Form
	{
		public frmDemoTimer()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			// lấy tgian htai
			DateTime now = DateTime.Now; 
            
            
            label1.Text = now.ToString("MM/dd/yyyy hh:mm:ss tt");
		}
	}
}

	