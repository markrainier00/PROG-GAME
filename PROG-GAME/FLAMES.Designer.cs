/*
 * Created by SharpDevelop.
 * User: CRISTEL ILAGAN
 * Date: 15/12/2023
 * Time: 4:10 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROGGAMES
{
	partial class FLAMES
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button matchButton;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button returnButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label countdownLabel;
		private System.Windows.Forms.PictureBox FpictureBox;
		private System.Windows.Forms.PictureBox LpictureBox;
		private System.Windows.Forms.PictureBox ApictureBox;
		private System.Windows.Forms.PictureBox MpictureBox;
		private System.Windows.Forms.PictureBox EpictureBox;
		private System.Windows.Forms.PictureBox SpictureBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button helpButton;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLAMES));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.backButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.matchButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.returnButton = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.countdownLabel = new System.Windows.Forms.Label();
			this.FpictureBox = new System.Windows.Forms.PictureBox();
			this.LpictureBox = new System.Windows.Forms.PictureBox();
			this.ApictureBox = new System.Windows.Forms.PictureBox();
			this.MpictureBox = new System.Windows.Forms.PictureBox();
			this.EpictureBox = new System.Windows.Forms.PictureBox();
			this.SpictureBox = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.helpButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FpictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LpictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ApictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MpictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EpictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SpictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(155, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(278, 148);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(222, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(931, 572);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
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
			this.backButton.Location = new System.Drawing.Point(0, 634);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(84, 116);
			this.backButton.TabIndex = 3;
			this.backButton.Text = "< ";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton1Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Khaki;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(484, 356);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(404, 57);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Khaki;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(484, 438);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(404, 57);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(423, 317);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 36);
			this.label1.TabIndex = 6;
			this.label1.Text = "ENTER NAMES HERE:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// matchButton
			// 
			this.matchButton.BackColor = System.Drawing.Color.Transparent;
			this.matchButton.FlatAppearance.BorderSize = 0;
			this.matchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.matchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.matchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.matchButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.matchButton.ForeColor = System.Drawing.Color.White;
			this.matchButton.Location = new System.Drawing.Point(597, 559);
			this.matchButton.Name = "matchButton";
			this.matchButton.Size = new System.Drawing.Size(180, 61);
			this.matchButton.TabIndex = 7;
			this.matchButton.Text = "MATCH";
			this.matchButton.UseVisualStyleBackColor = false;
			this.matchButton.Click += new System.EventHandler(this.MatchButtonClick);
			// 
			// nameLabel
			// 
			this.nameLabel.BackColor = System.Drawing.Color.Transparent;
			this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.ForeColor = System.Drawing.Color.White;
			this.nameLabel.Location = new System.Drawing.Point(337, 279);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(695, 184);
			this.nameLabel.TabIndex = 9;
			this.nameLabel.Text = "RESULT \r\nIN";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// returnButton
			// 
			this.returnButton.BackColor = System.Drawing.Color.Transparent;
			this.returnButton.FlatAppearance.BorderSize = 0;
			this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.returnButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.returnButton.ForeColor = System.Drawing.Color.White;
			this.returnButton.Location = new System.Drawing.Point(494, 612);
			this.returnButton.Name = "returnButton";
			this.returnButton.Size = new System.Drawing.Size(394, 61);
			this.returnButton.TabIndex = 10;
			this.returnButton.Text = "MATCH ANOTHER";
			this.returnButton.UseVisualStyleBackColor = false;
			this.returnButton.Click += new System.EventHandler(this.ReturnButtonClick);
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
			this.countdownLabel.ForeColor = System.Drawing.Color.White;
			this.countdownLabel.Location = new System.Drawing.Point(473, 323);
			this.countdownLabel.Name = "countdownLabel";
			this.countdownLabel.Size = new System.Drawing.Size(451, 255);
			this.countdownLabel.TabIndex = 11;
			this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FpictureBox
			// 
			this.FpictureBox.BackColor = System.Drawing.Color.Transparent;
			this.FpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FpictureBox.Image")));
			this.FpictureBox.Location = new System.Drawing.Point(464, 466);
			this.FpictureBox.Name = "FpictureBox";
			this.FpictureBox.Size = new System.Drawing.Size(451, 87);
			this.FpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FpictureBox.TabIndex = 12;
			this.FpictureBox.TabStop = false;
			// 
			// LpictureBox
			// 
			this.LpictureBox.BackColor = System.Drawing.Color.Transparent;
			this.LpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LpictureBox.Image")));
			this.LpictureBox.Location = new System.Drawing.Point(464, 466);
			this.LpictureBox.Name = "LpictureBox";
			this.LpictureBox.Size = new System.Drawing.Size(451, 87);
			this.LpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LpictureBox.TabIndex = 13;
			this.LpictureBox.TabStop = false;
			// 
			// ApictureBox
			// 
			this.ApictureBox.BackColor = System.Drawing.Color.Transparent;
			this.ApictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ApictureBox.Image")));
			this.ApictureBox.Location = new System.Drawing.Point(464, 466);
			this.ApictureBox.Name = "ApictureBox";
			this.ApictureBox.Size = new System.Drawing.Size(451, 87);
			this.ApictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ApictureBox.TabIndex = 14;
			this.ApictureBox.TabStop = false;
			// 
			// MpictureBox
			// 
			this.MpictureBox.BackColor = System.Drawing.Color.Transparent;
			this.MpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MpictureBox.Image")));
			this.MpictureBox.Location = new System.Drawing.Point(464, 466);
			this.MpictureBox.Name = "MpictureBox";
			this.MpictureBox.Size = new System.Drawing.Size(451, 87);
			this.MpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MpictureBox.TabIndex = 15;
			this.MpictureBox.TabStop = false;
			// 
			// EpictureBox
			// 
			this.EpictureBox.BackColor = System.Drawing.Color.Transparent;
			this.EpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EpictureBox.Image")));
			this.EpictureBox.Location = new System.Drawing.Point(464, 466);
			this.EpictureBox.Name = "EpictureBox";
			this.EpictureBox.Size = new System.Drawing.Size(451, 87);
			this.EpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.EpictureBox.TabIndex = 16;
			this.EpictureBox.TabStop = false;
			// 
			// SpictureBox
			// 
			this.SpictureBox.BackColor = System.Drawing.Color.Transparent;
			this.SpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SpictureBox.Image")));
			this.SpictureBox.Location = new System.Drawing.Point(464, 466);
			this.SpictureBox.Name = "SpictureBox";
			this.SpictureBox.Size = new System.Drawing.Size(451, 87);
			this.SpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SpictureBox.TabIndex = 17;
			this.SpictureBox.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(565, 279);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(265, 44);
			this.label2.TabIndex = 18;
			this.label2.Text = "RESULT IN";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.helpButton.TabIndex = 19;
			this.helpButton.Text = "?";
			this.helpButton.UseVisualStyleBackColor = false;
			this.helpButton.Click += new System.EventHandler(this.HelpButtonClick);
			// 
			// FLAMES
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.countdownLabel);
			this.Controls.Add(this.SpictureBox);
			this.Controls.Add(this.EpictureBox);
			this.Controls.Add(this.MpictureBox);
			this.Controls.Add(this.ApictureBox);
			this.Controls.Add(this.LpictureBox);
			this.Controls.Add(this.FpictureBox);
			this.Controls.Add(this.returnButton);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.matchButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "FLAMES";
			this.Text = "FLAMES";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FpictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LpictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ApictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MpictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EpictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SpictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
