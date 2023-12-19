using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROGGAMES
{
	/// <summary>
	/// Description of PLAY.
	/// </summary>
	public partial class PLAY : Form
	{
		public PLAY()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			pictureBox1.Location = new Point(28, -70);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
//To close the application.
		void ExitButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
//To play FLAMES		
		void FlamesButtonClick(object sender, EventArgs e)
		{
			LOADFLAMES form = new LOADFLAMES();
			form.Show();
			this.Hide();
		}
//To play MEMOWRITE		
		void MemowriteButtonClick(object sender, EventArgs e)
		{
			LOADMEMOWRITE form = new LOADMEMOWRITE();
			form.Show();
			this.Hide();
		}
//To play NUMBERDLE
		void NumberdleButtonClick(object sender, EventArgs e)
		{
			LOADNUMBERDLE form = new LOADNUMBERDLE();
			form.Show();
			this.Hide();
		}
//To show information about the application
		void AboutUsButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("PROG GAMES is made as a final project of the students " +
			                "from Bachelor of Science in Computer Science - 2B " +
			                "in their subject Data Structures and Algorithms.\n" +
			                "\nThe application offers three games that utilizes the principles " +
			                "of the topics in the subject like the HashSet, Array, and List.\n" +
			                "\nThe name 'PROG GAMES' is decided to be the application's name to match the frog theme which " +
			                "is the students inside joke. 'PROG' which sounds like frog but is " +
			                "also shortened for 'programming' which matches the subject's main point.\n" +
			                "\nDEVELOPERS\n" +
			                "Ariane Karell Balan\n" +
			                "Mariel Hope Balazuela\n" +
			                "Mark Rainier Ilagan\n" +
			                "Jan Ilaiza Mendoza\n" +
			                "Raquel Dan Lou Morales\n" +
			                "Mary Joy Valdez");
		}
	}
}
