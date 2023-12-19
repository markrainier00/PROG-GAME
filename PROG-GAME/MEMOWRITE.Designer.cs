/*
 * Created by SharpDevelop.
 * User: CRISTEL ILAGAN
 * Date: 15/12/2023
 * Time: 12:03 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROGGAMES
{
	partial class MEMOWRITE
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label countdownLabel;
		private System.Windows.Forms.Label wordsLabel;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label wordsCountdownLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button tryAgainButton;
		private System.Windows.Forms.Button nlButton;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label levelLabel1;
		private System.Windows.Forms.Label levelLabel2;
		private System.Windows.Forms.PictureBox gopictureBox;
		private System.Windows.Forms.PictureBox winpictureBox;
		private System.Windows.Forms.PictureBox congratspictureBox;
		private System.Windows.Forms.Label messageLabel;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MEMOWRITE));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.startButton = new System.Windows.Forms.Button();
			this.helpButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.countdownLabel = new System.Windows.Forms.Label();
			this.wordsLabel = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.wordsCountdownLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tryAgainButton = new System.Windows.Forms.Button();
			this.nlButton = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.levelLabel1 = new System.Windows.Forms.Label();
			this.levelLabel2 = new System.Windows.Forms.Label();
			this.gopictureBox = new System.Windows.Forms.PictureBox();
			this.winpictureBox = new System.Windows.Forms.PictureBox();
			this.congratspictureBox = new System.Windows.Forms.PictureBox();
			this.messageLabel = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gopictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.winpictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.congratspictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(33, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(278, 148);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(228, 1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(931, 572);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.Transparent;
			this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.startButton.FlatAppearance.BorderSize = 0;
			this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.Color.MidnightBlue;
			this.startButton.Location = new System.Drawing.Point(558, 370);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(285, 94);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "START";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// helpButton
			// 
			this.helpButton.BackColor = System.Drawing.Color.Transparent;
			this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.helpButton.FlatAppearance.BorderSize = 0;
			this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.helpButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helpButton.ForeColor = System.Drawing.Color.White;
			this.helpButton.Location = new System.Drawing.Point(1287, 1);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(61, 65);
			this.helpButton.TabIndex = 6;
			this.helpButton.Text = "?";
			this.helpButton.UseVisualStyleBackColor = false;
			this.helpButton.Click += new System.EventHandler(this.HelpButtonClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// countdownLabel
			// 
			this.countdownLabel.BackColor = System.Drawing.Color.Transparent;
			this.countdownLabel.Font = new System.Drawing.Font("Comic Sans MS", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countdownLabel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.countdownLabel.Location = new System.Drawing.Point(470, 259);
			this.countdownLabel.Name = "countdownLabel";
			this.countdownLabel.Size = new System.Drawing.Size(451, 255);
			this.countdownLabel.TabIndex = 12;
			this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// wordsLabel
			// 
			this.wordsLabel.BackColor = System.Drawing.Color.Transparent;
			this.wordsLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wordsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.wordsLabel.Location = new System.Drawing.Point(470, 281);
			this.wordsLabel.Name = "wordsLabel";
			this.wordsLabel.Size = new System.Drawing.Size(451, 252);
			this.wordsLabel.TabIndex = 13;
			this.wordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(514, 259);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(363, 44);
			this.label2.TabIndex = 19;
			this.label2.Text = "GAME STARTS IN";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// wordsCountdownLabel
			// 
			this.wordsCountdownLabel.BackColor = System.Drawing.Color.Transparent;
			this.wordsCountdownLabel.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.wordsCountdownLabel.ForeColor = System.Drawing.Color.White;
			this.wordsCountdownLabel.Location = new System.Drawing.Point(514, 514);
			this.wordsCountdownLabel.Name = "wordsCountdownLabel";
			this.wordsCountdownLabel.Size = new System.Drawing.Size(363, 84);
			this.wordsCountdownLabel.TabIndex = 20;
			this.wordsCountdownLabel.Text = "3";
			this.wordsCountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(402, 259);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(579, 44);
			this.label1.TabIndex = 21;
			this.label1.Text = "WHAT DO YOU REMEMBER?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(514, 325);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(363, 147);
			this.textBox1.TabIndex = 22;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// submitButton
			// 
			this.submitButton.BackColor = System.Drawing.Color.Transparent;
			this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.submitButton.FlatAppearance.BorderSize = 0;
			this.submitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.submitButton.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.ForeColor = System.Drawing.Color.White;
			this.submitButton.Location = new System.Drawing.Point(590, 532);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(188, 66);
			this.submitButton.TabIndex = 23;
			this.submitButton.Text = "SUBMIT";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Click += new System.EventHandler(this.SubmitButtonClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(495, 475);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(399, 58);
			this.label3.TabIndex = 24;
			this.label3.Text = "JUST USE SPACE TO SEPARATE THE WORDS FROM EACH OTHER OR YOU WIL LOSE!";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tryAgainButton
			// 
			this.tryAgainButton.BackColor = System.Drawing.Color.Transparent;
			this.tryAgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tryAgainButton.FlatAppearance.BorderSize = 0;
			this.tryAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.tryAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.tryAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tryAgainButton.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tryAgainButton.ForeColor = System.Drawing.Color.White;
			this.tryAgainButton.Location = new System.Drawing.Point(558, 532);
			this.tryAgainButton.Name = "tryAgainButton";
			this.tryAgainButton.Size = new System.Drawing.Size(264, 66);
			this.tryAgainButton.TabIndex = 26;
			this.tryAgainButton.Text = "TRY AGAIN";
			this.tryAgainButton.UseVisualStyleBackColor = false;
			this.tryAgainButton.Click += new System.EventHandler(this.TryAgainButtonClick);
			// 
			// nlButton
			// 
			this.nlButton.BackColor = System.Drawing.Color.Transparent;
			this.nlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.nlButton.FlatAppearance.BorderSize = 0;
			this.nlButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.nlButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.nlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nlButton.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nlButton.ForeColor = System.Drawing.Color.White;
			this.nlButton.Location = new System.Drawing.Point(558, 514);
			this.nlButton.Name = "nlButton";
			this.nlButton.Size = new System.Drawing.Size(264, 66);
			this.nlButton.TabIndex = 27;
			this.nlButton.Text = "NEXT LEVEL";
			this.nlButton.UseVisualStyleBackColor = false;
			this.nlButton.Click += new System.EventHandler(this.NlButtonClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(1049, 370);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(285, 144);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(33, 370);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(285, 144);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 29;
			this.pictureBox4.TabStop = false;
			// 
			// levelLabel1
			// 
			this.levelLabel1.BackColor = System.Drawing.Color.Transparent;
			this.levelLabel1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.levelLabel1.Location = new System.Drawing.Point(33, 308);
			this.levelLabel1.Name = "levelLabel1";
			this.levelLabel1.Size = new System.Drawing.Size(285, 62);
			this.levelLabel1.TabIndex = 30;
			this.levelLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// levelLabel2
			// 
			this.levelLabel2.BackColor = System.Drawing.Color.Transparent;
			this.levelLabel2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelLabel2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.levelLabel2.Location = new System.Drawing.Point(1049, 308);
			this.levelLabel2.Name = "levelLabel2";
			this.levelLabel2.Size = new System.Drawing.Size(285, 62);
			this.levelLabel2.TabIndex = 31;
			this.levelLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gopictureBox
			// 
			this.gopictureBox.BackColor = System.Drawing.Color.Transparent;
			this.gopictureBox.Image = ((System.Drawing.Image)(resources.GetObject("gopictureBox.Image")));
			this.gopictureBox.Location = new System.Drawing.Point(437, 206);
			this.gopictureBox.Name = "gopictureBox";
			this.gopictureBox.Size = new System.Drawing.Size(505, 83);
			this.gopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gopictureBox.TabIndex = 32;
			this.gopictureBox.TabStop = false;
			// 
			// winpictureBox
			// 
			this.winpictureBox.BackColor = System.Drawing.Color.Transparent;
			this.winpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("winpictureBox.Image")));
			this.winpictureBox.Location = new System.Drawing.Point(437, 206);
			this.winpictureBox.Name = "winpictureBox";
			this.winpictureBox.Size = new System.Drawing.Size(505, 83);
			this.winpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.winpictureBox.TabIndex = 33;
			this.winpictureBox.TabStop = false;
			// 
			// congratspictureBox
			// 
			this.congratspictureBox.BackColor = System.Drawing.Color.Transparent;
			this.congratspictureBox.Image = ((System.Drawing.Image)(resources.GetObject("congratspictureBox.Image")));
			this.congratspictureBox.Location = new System.Drawing.Point(402, 333);
			this.congratspictureBox.Name = "congratspictureBox";
			this.congratspictureBox.Size = new System.Drawing.Size(579, 120);
			this.congratspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.congratspictureBox.TabIndex = 34;
			this.congratspictureBox.TabStop = false;
			// 
			// messageLabel
			// 
			this.messageLabel.BackColor = System.Drawing.Color.Transparent;
			this.messageLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.messageLabel.ForeColor = System.Drawing.Color.MidnightBlue;
			this.messageLabel.Location = new System.Drawing.Point(402, 445);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(579, 44);
			this.messageLabel.TabIndex = 35;
			this.messageLabel.Text = "YOU CAN BE PART OF OUR FROG COMMUNITY AT THIS POINT!";
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.Transparent;
			this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backButton.FlatAppearance.BorderSize = 0;
			this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backButton.ForeColor = System.Drawing.Color.White;
			this.backButton.Location = new System.Drawing.Point(1, 632);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(84, 116);
			this.backButton.TabIndex = 4;
			this.backButton.Text = "< ";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.BackButtonClick);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(948, 296);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(116, 168);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 36;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(313, 296);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(116, 168);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 37;
			this.pictureBox6.TabStop = false;
			// 
			// MEMOWRITE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.congratspictureBox);
			this.Controls.Add(this.winpictureBox);
			this.Controls.Add(this.gopictureBox);
			this.Controls.Add(this.levelLabel2);
			this.Controls.Add(this.levelLabel1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.nlButton);
			this.Controls.Add(this.tryAgainButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.wordsCountdownLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.wordsLabel);
			this.Controls.Add(this.countdownLabel);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "MEMOWRITE";
			this.Text = "MEMOWRITE";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gopictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.winpictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.congratspictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
