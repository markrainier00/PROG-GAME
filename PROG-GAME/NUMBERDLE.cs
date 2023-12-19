using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace PROGGAMES
{
	/// <summary>
	/// Description of NUMBERDLE.
	/// //MRCI
	/// </summary>
	public partial class NUMBERDLE : Form
	{
		public NUMBERDLE()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pictureBox2.Location = new Point(221, -153);
			guess21.Hide();
			guess22.Hide();
			guess23.Hide();
			guess24.Hide();
			guess25.Hide();
			guess31.Hide();
			guess32.Hide();
			guess33.Hide();
			guess34.Hide();
			guess35.Hide();
			guess41.Hide();
			guess42.Hide();
			guess43.Hide();
			guess44.Hide();
			guess45.Hide();
			guess51.Hide();
			guess52.Hide();
			guess53.Hide();
			guess54.Hide();
			guess55.Hide();
			tryAgainButton.Hide();
			yeypictureBox1.Hide();
			yeypictureBox2.Hide();
			wowpictureBox1.Hide();
			wowpictureBox2.Hide();
			nicepictureBox1.Hide();
			nicepictureBox2.Hide();
			leastpictureBox1.Hide();
			leastpictureBox2.Hide();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//Setting variables and arrays		
		Random rnd = new Random();
		int[] guess = new int[5];
		int[] randomNumbers = new int[5];
		int num, num1 = 10, num2 = 10, num3 = 10, num4 = 10, num5 = 10;
		int length = 0;
		int input1;
		int input2;
		int input3;
		int input4;
		int input5;
		int trynum = 0;
		int containsGrayYellow;
		string[] color = new string[5];
//Setting the numbers to guess as the form loads
		void NUMBERDLELoad(object sender, EventArgs e)
		{
			while (length < 5)
			{
				num = rnd.Next(10);
				
				if (num != num1 && num != num2 && num != num3 && num != num4 && num != num5)
				{
					randomNumbers[length] = num;
					length += 1;
					num5 = num4; num4 = num3; num3 = num2; num2 = num1; num1 = num;
				}
			}
		}

		void SubmitButtonClick(object sender, EventArgs e)
		{
			trynum += 1;
			containsGrayYellow = 0;
			
			CollectInfo();
	//Checking if the player's answer is matched with the numbers to guess
			for (int l = 1; l <= 5; l++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (randomNumbers.Contains(guess[j]))
					{
						if (randomNumbers[j] == guess[j])
						{
							color[j] = "Green";
						}
						else
						{
							color[j] = "Yellow";
							containsGrayYellow += 1;
						}
					}
					else
					{
							color[j] = "ControlDark";
							containsGrayYellow += 1;
					}
				}
				
				if(trynum == 5)
				{
					Decide();
				}
				else if (trynum != 5 && containsGrayYellow == 0)
				{
					Decide();
				}
				
				ChangeColor();
				
			}
		}
//Setting a color to the player's answer accodring to their state		
		void ChangeColor()
		{
			string color1 = color[0];
			string color2 = color[1];
			string color3 = color[2];
			string color4 = color[3];
			string color5 = color[4];
			
			if (trynum == 1)
			{
				guess11.BackColor = Color.FromName(color1); guess11.ReadOnly = true;
				guess12.BackColor = Color.FromName(color2); guess12.ReadOnly = true;
				guess13.BackColor = Color.FromName(color3); guess13.ReadOnly = true;
				guess14.BackColor = Color.FromName(color4); guess14.ReadOnly = true;
				guess15.BackColor = Color.FromName(color5); guess15.ReadOnly = true;
				
				if(color.Contains("ControlDark") || color.Contains("Yellow"))
				{
					guess21.Show();
					guess22.Show();
					guess23.Show();
					guess24.Show();
					guess25.Show();
				}
			}
			
			else if (trynum == 2)
			{
				guess21.BackColor = Color.FromName(color1); guess21.ReadOnly = true;
				guess22.BackColor = Color.FromName(color2); guess22.ReadOnly = true;
				guess23.BackColor = Color.FromName(color3); guess23.ReadOnly = true;
				guess24.BackColor = Color.FromName(color4); guess24.ReadOnly = true;
				guess25.BackColor = Color.FromName(color5); guess25.ReadOnly = true;
				
				if(color.Contains("ControlDark") || color.Contains("Yellow"))
				{
					guess31.Show();
					guess32.Show();
					guess33.Show();
					guess34.Show();
					guess35.Show();
				}
			}
			
			else if (trynum == 3)
			{
				guess31.BackColor = Color.FromName(color1); guess31.ReadOnly = true;
				guess32.BackColor = Color.FromName(color2); guess32.ReadOnly = true;
				guess33.BackColor = Color.FromName(color3); guess33.ReadOnly = true;
				guess34.BackColor = Color.FromName(color4); guess34.ReadOnly = true;
				guess35.BackColor = Color.FromName(color5); guess35.ReadOnly = true;
				
				if(color.Contains("ControlDark") || color.Contains("Yellow"))
				{
					guess41.Show();
					guess42.Show();
					guess43.Show();
					guess44.Show();
					guess45.Show();
				}
			}
			
			else if (trynum == 4)
			{
				guess41.BackColor = Color.FromName(color1); guess41.ReadOnly = true;
				guess42.BackColor = Color.FromName(color2); guess42.ReadOnly = true;
				guess43.BackColor = Color.FromName(color3); guess43.ReadOnly = true;
				guess44.BackColor = Color.FromName(color4); guess44.ReadOnly = true;
				guess45.BackColor = Color.FromName(color5); guess45.ReadOnly = true;
				
				if(color.Contains("ControlDark") || color.Contains("Yellow"))
				{
					guess51.Show();
					guess52.Show();
					guess53.Show();
					guess54.Show();
					guess55.Show();
				}
			}
			
			else if (trynum == 5)
			{
				guess51.BackColor = Color.FromName(color1); guess51.ReadOnly = true;
				guess52.BackColor = Color.FromName(color2); guess52.ReadOnly = true;
				guess53.BackColor = Color.FromName(color3); guess53.ReadOnly = true;
				guess54.BackColor = Color.FromName(color4); guess54.ReadOnly = true;
				guess55.BackColor = Color.FromName(color5); guess55.ReadOnly = true;
			}
		}
//Collecting the player's answer		
		void CollectInfo()
		{
			int number;
			if(trynum == 1 && (int.TryParse(guess11.Text, out number) && 
			                   int.TryParse(guess12.Text, out number) &&  
			                   int.TryParse(guess13.Text, out number) &&  
			                   int.TryParse(guess14.Text, out number) &&  
			                   int.TryParse(guess15.Text, out number) ))
			{
				input1 = Convert.ToInt32(guess11.Text);
				input2 = Convert.ToInt32(guess12.Text);
				input3 = Convert.ToInt32(guess13.Text);
				input4 = Convert.ToInt32(guess14.Text);
				input5 = Convert.ToInt32(guess15.Text);
				
				guess[0] = input1;	guess[1] = input2;	guess[2] = input3;	guess[3] = input4;	guess[4] = input5;
			}
			
			else if(trynum == 2 && (int.TryParse(guess21.Text, out number) && 
			                   int.TryParse(guess22.Text, out number) &&  
			                   int.TryParse(guess23.Text, out number) &&  
			                   int.TryParse(guess24.Text, out number) &&  
			                   int.TryParse(guess25.Text, out number) ))
			{
				input1 = Convert.ToInt32(guess21.Text);
				input2 = Convert.ToInt32(guess22.Text);
				input3 = Convert.ToInt32(guess23.Text);
				input4 = Convert.ToInt32(guess24.Text);
				input5 = Convert.ToInt32(guess25.Text);
				
				guess[0] = input1;	guess[1] = input2;	guess[2] = input3;	guess[3] = input4;	guess[4] = input5;
			}
			
			else if(trynum == 3 && (int.TryParse(guess31.Text, out number) && 
			                   int.TryParse(guess32.Text, out number) &&  
			                   int.TryParse(guess33.Text, out number) &&  
			                   int.TryParse(guess34.Text, out number) &&  
			                   int.TryParse(guess35.Text, out number) ))
			{
				input1 = Convert.ToInt32(guess31.Text);
				input2 = Convert.ToInt32(guess32.Text);
				input3 = Convert.ToInt32(guess33.Text);
				input4 = Convert.ToInt32(guess34.Text);
				input5 = Convert.ToInt32(guess35.Text);
				
				guess[0] = input1;	guess[1] = input2;	guess[2] = input3;	guess[3] = input4;	guess[4] = input5;
			}
			
			else if(trynum == 4 && (int.TryParse(guess41.Text, out number) && 
			                   int.TryParse(guess42.Text, out number) &&  
			                   int.TryParse(guess43.Text, out number) &&  
			                   int.TryParse(guess44.Text, out number) &&  
			                   int.TryParse(guess45.Text, out number) ))
			{
				input1 = Convert.ToInt32(guess41.Text);
				input2 = Convert.ToInt32(guess42.Text);
				input3 = Convert.ToInt32(guess43.Text);
				input4 = Convert.ToInt32(guess44.Text);
				input5 = Convert.ToInt32(guess45.Text);
				
				guess[0] = input1;	guess[1] = input2;	guess[2] = input3;	guess[3] = input4;	guess[4] = input5;
			}
			
			else if(trynum == 5 && (int.TryParse(guess51.Text, out number) && 
			                   int.TryParse(guess52.Text, out number) &&  
			                   int.TryParse(guess53.Text, out number) &&  
			                   int.TryParse(guess54.Text, out number) &&  
			                   int.TryParse(guess55.Text, out number) ))
			{
				input1 = Convert.ToInt32(guess51.Text);
				input2 = Convert.ToInt32(guess52.Text);
				input3 = Convert.ToInt32(guess53.Text);
				input4 = Convert.ToInt32(guess54.Text);
				input5 = Convert.ToInt32(guess55.Text);
				
				guess[0] = input1;	guess[1] = input2;	guess[2] = input3;	guess[3] = input4;	guess[4] = input5;
			}
			
			else
			{
				nicepictureBox1.Show();
				nicepictureBox2.Show();
				leastpictureBox1.Show();
				leastpictureBox2.Show();
				tryAgainButton.Show();
			}
		}
//To exit the game
		void BackButtonClick(object sender, EventArgs e)
		{
			PLAY form = new PLAY();
			form.Show();
			this.Hide();
		}
//Deciding whether the player wins or not
//MRCI
		void Decide()
		{
			if(containsGrayYellow > 0)
			{
				answerLabel1.Text = (randomNumbers[0]).ToString();
				answerLabel2.Text = (randomNumbers[1]).ToString();
				answerLabel3.Text = (randomNumbers[2]).ToString();
				answerLabel4.Text = (randomNumbers[3]).ToString();
				answerLabel5.Text = (randomNumbers[4]).ToString();
				
				nicepictureBox1.Show();
				nicepictureBox2.Show();
				leastpictureBox1.Show();
				leastpictureBox2.Show();
				whatpictureBox1.Hide();
				whatpictureBox2.Hide();
				submitButton.Hide();
				tryAgainButton.Show();
			}
			else
			{
				answerLabel1.Text = (randomNumbers[0]).ToString();
				answerLabel2.Text = (randomNumbers[1]).ToString();
				answerLabel3.Text = (randomNumbers[2]).ToString();
				answerLabel4.Text = (randomNumbers[3]).ToString();
				answerLabel5.Text = (randomNumbers[4]).ToString();
				
				yeypictureBox1.Show();
				yeypictureBox2.Show();
				wowpictureBox1.Show();
				wowpictureBox2.Show();
				whatpictureBox1.Hide();
				whatpictureBox2.Hide();
				submitButton.Hide();
				tryAgainButton.Show();
			}
		}
//To play again
		void TryAgainButtonClick(object sender, EventArgs e)
		{
			NUMBERDLE form = new NUMBERDLE();
			form.Show();
			this.Hide();
		}
//To show how the game works
		void HelpButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("Inspired by the game 'WORDLE', NUMBERDLE is an analytical guessing game that uses numbers (0-9) as elements instead of letters.\n" +
			                "\nThe player is given five chances to guess the five numbers and their exact order.\n" +
			                "\nAs a clue, the guesses of the player will be colored according to their current state:" +
			                "\n     GREEN - The number is one of the elements to be guessed and" +
			                "\n             is placed in its correct order." +
			                "\n        RED - The number is one of the elements to be guessed but" +
			                "\n             is not placed in its correct order." +
			                "\n      GRAY - The number is not one of the elements to be guessed.\n" +
			                "\nChallenge your luck and logical reasoning NOW!");
		}
	}
}
