/*
 * Created by SharpDevelop.
 * User: CRISTEL ILAGAN
 * Date: 15/12/2023
 * Time: 3:05 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROGGAMES
{
	partial class PLAY
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button flamesButton;
		private System.Windows.Forms.Button memowriteButton;
		private System.Windows.Forms.Button numberdleButton;
		private System.Windows.Forms.Button aboutUsButton;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLAY));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.flamesButton = new System.Windows.Forms.Button();
			this.memowriteButton = new System.Windows.Forms.Button();
			this.numberdleButton = new System.Windows.Forms.Button();
			this.aboutUsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(28, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(610, 331);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.Transparent;
			this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.Color.White;
			this.exitButton.Location = new System.Drawing.Point(1238, 687);
			this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(132, 59);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "EXIT";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// flamesButton
			// 
			this.flamesButton.FlatAppearance.BorderSize = 0;
			this.flamesButton.Image = ((System.Drawing.Image)(resources.GetObject("flamesButton.Image")));
			this.flamesButton.Location = new System.Drawing.Point(60, 230);
			this.flamesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.flamesButton.Name = "flamesButton";
			this.flamesButton.Size = new System.Drawing.Size(302, 399);
			this.flamesButton.TabIndex = 3;
			this.flamesButton.UseVisualStyleBackColor = true;
			this.flamesButton.Click += new System.EventHandler(this.FlamesButtonClick);
			// 
			// memowriteButton
			// 
			this.memowriteButton.FlatAppearance.BorderSize = 0;
			this.memowriteButton.Image = ((System.Drawing.Image)(resources.GetObject("memowriteButton.Image")));
			this.memowriteButton.Location = new System.Drawing.Point(390, 230);
			this.memowriteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.memowriteButton.Name = "memowriteButton";
			this.memowriteButton.Size = new System.Drawing.Size(302, 399);
			this.memowriteButton.TabIndex = 4;
			this.memowriteButton.UseVisualStyleBackColor = true;
			this.memowriteButton.Click += new System.EventHandler(this.MemowriteButtonClick);
			// 
			// numberdleButton
			// 
			this.numberdleButton.FlatAppearance.BorderSize = 0;
			this.numberdleButton.Image = ((System.Drawing.Image)(resources.GetObject("numberdleButton.Image")));
			this.numberdleButton.Location = new System.Drawing.Point(729, 230);
			this.numberdleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numberdleButton.Name = "numberdleButton";
			this.numberdleButton.Size = new System.Drawing.Size(302, 399);
			this.numberdleButton.TabIndex = 5;
			this.numberdleButton.UseVisualStyleBackColor = true;
			this.numberdleButton.Click += new System.EventHandler(this.NumberdleButtonClick);
			// 
			// aboutUsButton
			// 
			this.aboutUsButton.BackColor = System.Drawing.Color.Transparent;
			this.aboutUsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.aboutUsButton.FlatAppearance.BorderSize = 0;
			this.aboutUsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.aboutUsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.aboutUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aboutUsButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutUsButton.ForeColor = System.Drawing.Color.White;
			this.aboutUsButton.Location = new System.Drawing.Point(1231, 0);
			this.aboutUsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.aboutUsButton.Name = "aboutUsButton";
			this.aboutUsButton.Size = new System.Drawing.Size(127, 65);
			this.aboutUsButton.TabIndex = 8;
			this.aboutUsButton.Text = "About Us";
			this.aboutUsButton.UseVisualStyleBackColor = false;
			this.aboutUsButton.Click += new System.EventHandler(this.AboutUsButtonClick);
			// 
			// PLAY
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(198)))), ((int)(((byte)(142)))));
			this.ClientSize = new System.Drawing.Size(1370, 748);
			this.Controls.Add(this.aboutUsButton);
			this.Controls.Add(this.numberdleButton);
			this.Controls.Add(this.memowriteButton);
			this.Controls.Add(this.flamesButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PLAY";
			this.Text = "PLAY";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
