﻿namespace CinemaWindows
{
	partial class RestaurantMenu
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
			this.HomeBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HomeBTN
			// 
			this.HomeBTN.Location = new System.Drawing.Point(12, 12);
			this.HomeBTN.Name = "HomeBTN";
			this.HomeBTN.Size = new System.Drawing.Size(112, 35);
			this.HomeBTN.TabIndex = 9;
			this.HomeBTN.Text = "Home";
			this.HomeBTN.UseVisualStyleBackColor = true;
			this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
			// 
			// RestaurantMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1498, 943);
			this.Controls.Add(this.HomeBTN);
			this.Name = "RestaurantMenu";
			this.Text = "Restaurant menu";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button HomeBTN;
	}
}