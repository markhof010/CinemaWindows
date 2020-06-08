namespace CinemaWindows.Database
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
			this.removeBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LogoutBTN
			// 
			this.LogoutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LogoutBTN.Location = new System.Drawing.Point(852, 8);
			this.LogoutBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.LogoutBTN.Name = "LogoutBTN";
			this.LogoutBTN.Size = new System.Drawing.Size(74, 23);
			this.LogoutBTN.TabIndex = 0;
			this.LogoutBTN.Text = "Logout";
			this.LogoutBTN.UseVisualStyleBackColor = true;
			this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
			// 
			// AddMovieBTN
			// 
			this.AddMovieBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AddMovieBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddMovieBTN.Location = new System.Drawing.Point(411, 153);
			this.AddMovieBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AddMovieBTN.Name = "AddMovieBTN";
			this.AddMovieBTN.Size = new System.Drawing.Size(120, 23);
			this.AddMovieBTN.TabIndex = 1;
			this.AddMovieBTN.Text = "Add Movie";
			this.AddMovieBTN.UseVisualStyleBackColor = true;
			this.AddMovieBTN.Click += new System.EventHandler(this.AddMovieBTN_Click);
			// 
			// removeBTN
			// 
			this.removeBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.removeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.removeBTN.Location = new System.Drawing.Point(411, 263);
			this.removeBTN.Margin = new System.Windows.Forms.Padding(2);
			this.removeBTN.Name = "removeBTN";
			this.removeBTN.Size = new System.Drawing.Size(120, 23);
			this.removeBTN.TabIndex = 2;
			this.removeBTN.Text = "Remove Movie";
			this.removeBTN.UseVisualStyleBackColor = true;
			this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
			// 
			// AdminPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 552);
			this.Controls.Add(this.removeBTN);
			this.Controls.Add(this.AddMovieBTN);
			this.Controls.Add(this.LogoutBTN);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AdminPage";
			this.Text = "AdminPage";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button LogoutBTN;
		private System.Windows.Forms.Button AddMovieBTN;
		private System.Windows.Forms.Button DelMovieBTN;
		private System.Windows.Forms.Button removeBTN;
	}
}