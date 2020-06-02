namespace CinemaWindows
{
	partial class HomeScreen
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
			this.loginButon = new System.Windows.Forms.Button();
			this.MovieInfoButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginButon
			// 
			this.loginButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButon.Location = new System.Drawing.Point(2092, 23);
			this.loginButon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.loginButon.Name = "loginButon";
			this.loginButon.Size = new System.Drawing.Size(150, 44);
			this.loginButon.TabIndex = 0;
			this.loginButon.Text = "login";
			this.loginButon.UseVisualStyleBackColor = true;
			this.loginButon.Click += new System.EventHandler(this.loginButon_Click);
			// 
			// MovieInfoButton
			// 
			this.MovieInfoButton.Location = new System.Drawing.Point(1021, 822);
			this.MovieInfoButton.Name = "MovieInfoButton";
			this.MovieInfoButton.Size = new System.Drawing.Size(271, 81);
			this.MovieInfoButton.TabIndex = 1;
			this.MovieInfoButton.Text = "Movie information";
			this.MovieInfoButton.UseVisualStyleBackColor = true;
			this.MovieInfoButton.Click += new System.EventHandler(this.MovieInfoButton_Click);
			// 
			// HomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2266, 1183);
			this.Controls.Add(this.MovieInfoButton);
			this.Controls.Add(this.loginButon);
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "HomeScreen";
			this.Text = "Home Screen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button loginButon;
		private System.Windows.Forms.Button MovieInfoButton;
	}
}

