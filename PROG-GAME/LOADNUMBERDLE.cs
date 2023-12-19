using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROGGAMES
{
	/// <summary>
	/// Description of LOADNUMBERDLE.
	/// </summary>
	public partial class LOADNUMBERDLE : Form
	{
		public LOADNUMBERDLE()
		{
			InitializeComponent();
			pictureBox1.Location = new Point(57, -53);
			pictureBox2.Hide();
			pictureBox3.Hide();
			pictureBox4.Hide();
			pictureBox5.Hide();
			pictureBox6.Hide();
			pictureBox7.Hide();
			pictureBox8.Hide();
			pictureBox9.Hide();
			pictureBox10.Hide();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call. 
			//MRCI
		}
		
		void LOADNUMBERDLELoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
		
		int timeleft = 10;
		void Timer1Tick(object sender, EventArgs e)
		{
			if (timeleft == 10)
			{
		    	timeleft -= 1;
			}
			else if (timeleft == 9)
			{
		    	pictureBox2.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 8)
			{
		    	pictureBox10.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 7)
			{
				this.BackColor = Color.Navy;
		    	pictureBox9.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 6)
			{
		    	pictureBox8.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 5)
			{
		    	pictureBox7.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 4)
			{
		    	pictureBox6.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 3)
			{
				this.BackColor = Color.RosyBrown;
		    	pictureBox5.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 2)
			{
		    	pictureBox4.Show();
		    	timeleft -= 1;
			}
			else if (timeleft == 1)
			{
		    	pictureBox3.Show();
		    	timeleft -= 1;
			}
			else
			{
				timer1.Stop();
	    		NUMBERDLE form = new NUMBERDLE();
				form.Show();
				this.Hide();
			}
		}
	}
}
