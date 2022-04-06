using System;
using System.Drawing;
using System.Windows.Forms;
using ChangeBackgroundColorRunTime.Properties;

namespace ChangeBackgroundColorRunTime
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		int red1, green1, blue1;

		
	//قبل از ذخیره ی تنظیمات برنامه
	private void timer1_Tick(object sender, EventArgs e)
		{
			textBox1.Text = Convert.ToString(trackBar1.Value);
			textBox2.Text = Convert.ToString(trackBar2.Value);
			textBox3.Text = Convert.ToString(trackBar3.Value);

			
			red1 = Convert.ToInt32(textBox1.Text);
			green1 = Convert.ToInt32(textBox2.Text);
			blue1 = Convert.ToInt32(textBox3.Text);

			this.BackColor = Color.FromArgb(red1, green1, blue1);
			
		}

		#region SaveSetting
		//ذخیره تنظیمات برنامه
		private void Form1_Load(object sender, EventArgs e)
		{
			trackBar1.Value = Properties.Settings.Default.trackBar1;
			trackBar2.Value = Properties.Settings.Default.trackBar2;
			trackBar3.Value = Properties.Settings.Default.trackBar3;

			label1.ForeColor = Color.FromArgb(red1 + 255, green1 + 255, blue1 + 255);
			label2.ForeColor = Color.FromArgb(red1 + 255, green1 + 255, blue1 + 255);
			label3.ForeColor = Color.FromArgb(red1 + 255, green1 + 255, blue1 + 255);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			//if (red1 == 255)
			//{
			//	red1 = 0;
			//	green1 = 0;
			//	blue1 = 0;
			//}

			Properties.Settings.Default.trackBar1 = trackBar1.Value;
			Properties.Settings.Default.trackBar2 = trackBar2.Value;
			Properties.Settings.Default.trackBar3 = trackBar3.Value;

			Properties.Settings.Default.Save();
		}
		#endregion




	}
}
