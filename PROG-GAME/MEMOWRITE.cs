using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PROGGAMES
{
	/// <summary>
	/// Description of MEMOWRITE.
	/// //MRCI
	/// </summary>
	public partial class MEMOWRITE : Form
	{
		public MEMOWRITE()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pictureBox2.Location = new Point(221, -153);
			countdownLabel.Hide();
			wordsLabel.Hide();
			label2.Hide();
			wordsCountdownLabel.Text = "";
			wordsCountdownLabel.Hide();
			label1.Hide();
			textBox1.Hide();
			submitButton.Hide();
			label3.Hide();
			levelLabel1.Hide();
			levelLabel2.Hide();
			winpictureBox.Hide();
		   	gopictureBox.Hide();
		   	messageLabel.Hide();
		   	congratspictureBox.Hide();
		   	pictureBox5.Hide();
		   	pictureBox6.Hide();
		   	tryAgainButton.Hide();
		   	nlButton.Hide();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//Setting variables, queues, and list
	  	Queue<string> randomOrder = new Queue<string>();
		Queue<string> answer = new Queue<string>();
		List<string> order = new List<string>();	
	   	string words;
		int timeleft = 3;
		int timeleft2;
		string[] wordArray;
		int level = 1;
//To load the start of the game
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
				wordsLabel.Show();
				countdownLabel.Hide();
				label2.Hide();
				timer2.Start();
				wordsCountdownLabel.Show();
				countdownLabel.Text = "";
				timeleft = 3;
			}
		}	
//Inserting the given words on queue
	    List<string> Game(List<string> order, Label wordsLabel)
		{
		   	order = Shuffle(order);   
		   	randomOrder.Clear();
		    foreach(string treat in order)
		   	{
		    	words += treat + "\n";
		    	string upperWords = treat.ToUpper();
		    	randomOrder.Enqueue(upperWords);
	     	}
		    
		    wordsLabel.Text = words;
		    return(order);
		}
//To exit the game
		void BackButtonClick(object sender, EventArgs e)
		{
			PLAY form = new PLAY();
			form.Show();
			this.Hide();
		}
//Initializing the game: adding the words on list and setting the texts and designs
		void StartButtonClick(object sender, EventArgs e)
		{
			timer1.Start();
			startButton.Hide();
			label2.Show();
			countdownLabel.Show();
			
			if (level == 1)
			{
				levelLabel1.Text = "LEVEL 1";
				levelLabel2.Text = "LEVEL 1";
				levelLabel1.Show();
				levelLabel2.Show();
				
	     		order.Add("Frog");
	        	order.Add("Kokak");	
	        	order.Add("Tadpole");	
	        	order.Add("Waterlilies");	
	        	order.Add("Toad");
	    	    
	        	timeleft2 = 5;
	        	wordsCountdownLabel.Text = "";
	        	wordsLabel.Font = new Font("Comic Sans MS", 18);
	        	Game(order, wordsLabel);
			}
	    	else if (level == 2)
			{
				levelLabel1.Text = "LEVEL 2";
				levelLabel2.Text = "LEVEL 2";
				levelLabel1.Show();
				levelLabel2.Show();
				
	     		order.Add("Bullfrog");
	        	order.Add("Croaker");	
	        	order.Add("Palaka");
	        	
	        	timeleft2 = 8;
	        	wordsCountdownLabel.Text = "";
	        	wordsLabel.Font = new Font("Comic Sans MS", 14);
	        	Game(order, wordsLabel);
			}
	    	else if (level == 3)
			{
				levelLabel1.Text = "LEVEL 3";
				levelLabel2.Text = "LEVEL 3";
				levelLabel1.Show();
				levelLabel2.Show();
				
	     		order.Add("Salamanders");
	        	order.Add("Newts");	
	    	    
	        	timeleft2 = 10;
	        	wordsCountdownLabel.Text = "";
	        	wordsLabel.Font = new Font("Comic Sans MS", 10);
	        	Game(order, wordsLabel);
			}
	    	else
	    	{
	    		nlButton.Hide();
	    		tryAgainButton.Show();
	    		congratspictureBox.Show();
		  	 	pictureBox5.Show();
		   		pictureBox6.Show();
	    		messageLabel.Show();
	    	}
		}
//To shuffle the words
		public static List<T> Shuffle<T> (List<T> list)
		{
			Random rnd = new Random();
			for (int i = 0; i < list.Count; i++)
			{
		    	int k = rnd.Next(0, i);
		    	T value = list[k];
		    	list[k] = list[i];
		    	list[i] = value;
			}
			return list;
		}
//Timing the appearance of the words to remember
		void Timer2Tick(object sender, EventArgs e)
		{
			if (timeleft2 == 10)
			{
				wordsCountdownLabel.Text = "10";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 9)
			{
				wordsCountdownLabel.Text = "9";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 8)
			{
				wordsCountdownLabel.Text = "8";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 7)
			{
				wordsCountdownLabel.Text = "7";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 6)
			{
				wordsCountdownLabel.Text = "6";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 5)
			{
				wordsCountdownLabel.Text = "5";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 4)
			{
				wordsCountdownLabel.Text = "4";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 3)
			{
				wordsCountdownLabel.Text = "3";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 2)
			{
				wordsCountdownLabel.Text = "2";
		    	timeleft2 -= 1;
			}
			else if (timeleft2 == 1)
			{
				wordsCountdownLabel.Text = "1";
		    	timeleft2 -= 1;
			}
			else
			{
				timer2.Stop();
				wordsCountdownLabel.Hide();
				words = "";
				wordsLabel.Hide();
				label1.Show();
				label3.Show();
				textBox1.Show();
				submitButton.Show();
			}
		}
//Collecting the answer of the player
		void SubmitButtonClick(object sender, EventArgs e)
		{
			wordArray = (textBox1.Text).Split(' ');
			
	    	if (wordArray.Length == order.Count)
	    	{
	        	for(int inputCount = 0; inputCount <= order.Count - 1; inputCount++)
			    {
	    			answer.Enqueue(wordArray[inputCount].ToUpper());
	    		}
	        	Array.Clear(wordArray, 0, wordArray.Length);
		    }
	    	else
	    	{
	    		goto here;
	    	}
	    	
		    int num = randomOrder.Count;
	//Comparing the answer to the given	    
		    while(num > 0)
		    {
		    	if(answer.Peek() == randomOrder.Peek())
		    	{
		        	answer.Dequeue();
		        	randomOrder.Dequeue();
		    	}
		    	num -= 1;
		    }
	//Deciding whether the player completed the level or not
	//MRCI
		   here:
		    if (randomOrder.Count == 0)
		    {
				level += 1;
		    	label1.Hide();
		    	label3.Hide();
		    	submitButton.Hide();
		    	
		    	if(level == 4)
		    	{
		    		StartButtonClick(sender, e);
		    		timer1.Enabled = false;
		    		label2.Hide();
		    	}
		    	else
		    	{
		   		 	winpictureBox.Show();
		    		nlButton.Show();
		    	}
		    }
		    else
		    {
		    	label1.Hide();
		    	textBox1.Hide();
		    	label3.Hide();
		    	submitButton.Hide();
		    	gopictureBox.Show();
		    	wordsLabel.Show();
		    	tryAgainButton.Show();
		    }
		}
//To play again		
		void TryAgainButtonClick(object sender, EventArgs e)
		{
			MEMOWRITE form = new MEMOWRITE();
			form.Show();
			this.Hide();
		}
//To move to the next level		
		void NlButtonClick(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox1.Hide();
			StartButtonClick(sender, e);
		   	gopictureBox.Hide();
		   	winpictureBox.Hide();
		   	tryAgainButton.Hide();
		   	nlButton.Hide();
		}
//To show how the game works
		void HelpButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("MEMOWRITE is a memory game that tests your ability to remember " +
			                "the given words and their exact order.\n" +
			                "\nThe game has three levels comprise number of words to memorize " +
			                "that will be only shown in a given amount of time:\n" +
			                "     LEVEL 1 - 5 WORDS  - 5 SECONDS\n" +
			                "     LEVEL 2 - 8 WORDS  - 8 SECONDS\n" +
			                "     LEVEL 3 - 10 WORDS - 10 SECONDS\n" +
			                "\nNote that to divide each words, the player may only use " +
			                "whitespace ' ' or else the words will not be valid and the game will be over.");
		}
	}
}
