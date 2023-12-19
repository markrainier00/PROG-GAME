using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROGGAMES
{
	/// <summary>
	/// Description of LOAD.
	/// </summary>
	public partial class LOADFLAMES : Form
	{
		public LOADFLAMES()
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
		
		void LOADFLAMESLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
		
		int timeleft = 4;
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (timeleft == 4)
			{
		    	timeleft -= 1;
			}
			else if (timeleft == 3)
			{
				this.BackColor = Color.YellowGreen;
		    	pictureBox2.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 2)
			{
				this.BackColor = Color.Gold;
		    	pictureBox3.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 1)
			{
				this.BackColor = Color.OrangeRed;
		    	pictureBox4.Show();
		    	timeleft -= 1;
			}
			else
			{
				timer1.Stop();
	    		FLAMES form = new FLAMES();
				form.Show();
				this.Hide();
			}
		}
	}
}
