﻿namespace CinemaWindows.Database
{
	partial class AdminPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.AddMovieBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBTN.Location = new System.Drawing.Point(1704, 15);
            this.LogoutBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(149, 44);
            this.LogoutBTN.TabIndex = 0;
            this.LogoutBTN.Text = "Logout";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // AddMovieBTN
            // 
            this.AddMovieBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddMovieBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMovieBTN.Location = new System.Drawing.Point(857, 241);
            this.AddMovieBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMovieBTN.Name = "AddMovieBTN";
            this.AddMovieBTN.Size = new System.Drawing.Size(149, 44);
            this.AddMovieBTN.TabIndex = 1;
            this.AddMovieBTN.Text = "Add Movie";
            this.AddMovieBTN.UseVisualStyleBackColor = true;
            this.AddMovieBTN.Click += new System.EventHandler(this.AddMovieBTN_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 1104);
            this.Controls.Add(this.AddMovieBTN);
            this.Controls.Add(this.LogoutBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button LogoutBTN;
		private System.Windows.Forms.Button AddMovieBTN;
	}
}