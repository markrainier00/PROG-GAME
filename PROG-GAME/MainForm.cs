using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROGGAMES
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pictureBox2.Hide();
			pictureBox3.Hide();
			pictureBox4.Hide();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
		
		int timeleft = 3;
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (timeleft == 3)
			{
		    	pictureBox2.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 2)
			{
		    	pictureBox3.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 1)
			{
		    	pictureBox4.Show();
		    	timeleft -= 1;
			}
			else
			{
				timer1.Stop();
	    		PLAY form = new PLAY();
				form.Show();
				this.Hide();
			}
		}
	}
}
