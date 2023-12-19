using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PROGGAMES
{
	/// <summary>
	/// Description of FLAMES.
	/// //MRCI
	/// </summary>
	public partial class FLAMES : Form
	{
		public FLAMES()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pictureBox2.Location = new Point(221, -153);
			nameLabel.Hide();
			FpictureBox.Hide();
			LpictureBox.Hide();
			ApictureBox.Hide();
			MpictureBox.Hide();
			EpictureBox.Hide();
			SpictureBox.Hide();
			returnButton.Hide();
			countdownLabel.Hide();
			label2.Hide();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//To exit the game
		void backButton1Click(object sender, EventArgs e)
		{
			PLAY form = new PLAY();
			form.Show();
			this.Hide();
		}
//To start matching
		void MatchButtonClick(object sender, EventArgs e)
		{
			textBox1.Hide();
			textBox2.Hide();
			matchButton.Hide();
			label1.Hide();
			int count = 0;
			
			//Setting of hashset
			LinkedList<char> letters1 = new LinkedList<char>();
			LinkedList<char> letters2 = new LinkedList<char>();
			
			//Collecting of inputs
			string name1 = textBox1.Text;
			string name2 = textBox2.Text;
			
			//Converting the string to char and inserting them in an array
			char[] array1 = (name1.ToLower()).ToCharArray();
			char[] array2 = (name2.ToLower()).ToCharArray();
			
			//Removing the whitespaces and putting the values on hashset
			foreach (char value in array1)
			{
				if (value == ' ')
				{
					
				}
				else 
				{
					letters1.AddLast(value);
				}
			}
			
			foreach (char value in array2)
			{
				if (value == ' ')
				{
					
				}
				else 
				{
					letters2.AddLast(value);
				}
			}
			
			//Checking if an element on the first hashset is also present on the second hashset
			foreach (char value in letters1)
			{
				if (letters2.Contains(value))
				{
					letters2.Remove(value);
					count++;
				}
			}
			
			//Getting the modulo of 'count' to get the letter in FLAMES, modulo of 6 since there are 6 letters on the word 'FLAMES'
			int countModulo = count % 6;
			
			countdownLabel.Show();
			label2.Show();
			backButton.Hide();
			timer1.Start();
			
			switch(countModulo)
			{
				case 1:
					nameLabel.Text = (name1.ToUpper() + "\nand\n" + name2 + "\nare\n");
					FpictureBox.Show();
					break;
				case 2:
					nameLabel.Text = (name1.ToUpper() + "\nand\n" + name2 + "\nare\n");
					LpictureBox.Show();
					break;
				case 3:
					nameLabel.Text = (name1.ToUpper() + "\nand\n" + name2 + "\nare\n");
					ApictureBox.Show();
					break;
				case 4:
					nameLabel.Text = (name1.ToUpper() + "\nand\n" + name2 + "\nare\n");
					MpictureBox.Show();
					break;
				case 5:
					nameLabel.Text = (name1.ToUpper() + "\nand\n" + name2 + "\nare\n");
					EpictureBox.Show();
					break;
				default:
					nameLabel.Text = (name1.ToUpper() + "\nand\n" + name2 + "\nare\n");
					SpictureBox.Show();
					break;
			}
		}
//To play again
		void ReturnButtonClick(object sender, EventArgs e)
		{
			FLAMES form = new FLAMES();
			form.Show();
			this.Hide();
		}
//To load the result
		int timeleft = 3;
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (timeleft == 3)
			{
				countdownLabel.Text = timeleft.ToString();
		    	timeleft -= 1;
			}
			else if (timeleft == 2)
			{
				countdownLabel.Text = timeleft.ToString();
		    	timeleft -= 1;
			}
			else if (timeleft == 1)
			{
				countdownLabel.Text = timeleft.ToString();
		    	timeleft -= 1;
			}
			else
			{
				timer1.Stop();
				countdownLabel.Hide();
				label2.Hide();
		    	backButton.Show();
	    		nameLabel.Show();
	    		returnButton.Show();
			}
		}
//To show how the game works
		void HelpButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("FLAMES is a matching type of game that shows a result " +
			                "based from the number of letters that the two matched names have.\n" +
			                "\nThere are only six possible results:\n" +
			                "     F - Friends\n" +
			                "     L - Lovers\n" +
			                "     A - Angry\n" +
			                "     M - Married\n" +
			                "     E - Engaged\n" +
			                "     S - Sweethearts\n" +
			                "\nEnjoy matching but don't take this seriously!");
		}
	}
}
