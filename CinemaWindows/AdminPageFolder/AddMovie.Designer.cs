namespace CinemaWindows.AdminPage
{
	partial class AddMovie
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
			this.ReturnBTN = new System.Windows.Forms.Button();
			this.LogoutBTN = new System.Windows.Forms.Button();
			this.SumInput = new System.Windows.Forms.TextBox();
			this.MovieNameLB = new System.Windows.Forms.Label();
			this.MovieNameInput = new System.Windows.Forms.TextBox();
			this.ReleasedateLB = new System.Windows.Forms.Label();
			this.ReleaseInput = new System.Windows.Forms.TextBox();
			this.AgeResLB = new System.Windows.Forms.Label();
			this.AgeResInput = new System.Windows.Forms.TextBox();
			this.SumLB = new System.Windows.Forms.Label();
			this.ActorsLB = new System.Windows.Forms.Label();
			this.ActorsInput = new System.Windows.Forms.TextBox();
			this.DurLB = new System.Windows.Forms.Label();
			this.DurationInput = new System.Windows.Forms.TextBox();
			this.GenreLB = new System.Windows.Forms.Label();
			this.GenreInput = new System.Windows.Forms.TextBox();
			this.AddMovieNxtBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ReturnBTN
			// 
			this.ReturnBTN.Location = new System.Drawing.Point(13, 13);
			this.ReturnBTN.Name = "ReturnBTN";
			this.ReturnBTN.Size = new System.Drawing.Size(112, 35);
			this.ReturnBTN.TabIndex = 0;
			this.ReturnBTN.Text = "Return";
			this.ReturnBTN.UseVisualStyleBackColor = true;
			this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
			// 
			// LogoutBTN
			// 
			this.LogoutBTN.Location = new System.Drawing.Point(1507, 12);
			this.LogoutBTN.Name = "LogoutBTN";
			this.LogoutBTN.Size = new System.Drawing.Size(112, 35);
			this.LogoutBTN.TabIndex = 1;
			this.LogoutBTN.Text = "Logout";
			this.LogoutBTN.UseVisualStyleBackColor = true;
			this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
			// 
			// SumInput
			// 
			this.SumInput.Location = new System.Drawing.Point(544, 300);
			this.SumInput.Multiline = true;
			this.SumInput.Name = "SumInput";
			this.SumInput.Size = new System.Drawing.Size(540, 162);
			this.SumInput.TabIndex = 2;
			this.SumInput.TextChanged += new System.EventHandler(this.SumInput_TextChanged);
			// 
			// MovieNameLB
			// 
			this.MovieNameLB.AutoSize = true;
			this.MovieNameLB.Location = new System.Drawing.Point(540, 52);
			this.MovieNameLB.Name = "MovieNameLB";
			this.MovieNameLB.Size = new System.Drawing.Size(94, 20);
			this.MovieNameLB.TabIndex = 3;
			this.MovieNameLB.Text = "Movie name";
			// 
			// MovieNameInput
			// 
			this.MovieNameInput.Location = new System.Drawing.Point(544, 76);
			this.MovieNameInput.Name = "MovieNameInput";
			this.MovieNameInput.Size = new System.Drawing.Size(332, 26);
			this.MovieNameInput.TabIndex = 4;
			this.MovieNameInput.TextChanged += new System.EventHandler(this.MovieNameInput_TextChanged);
			// 
			// ReleasedateLB
			// 
			this.ReleasedateLB.AutoSize = true;
			this.ReleasedateLB.Location = new System.Drawing.Point(540, 127);
			this.ReleasedateLB.Name = "ReleasedateLB";
			this.ReleasedateLB.Size = new System.Drawing.Size(100, 20);
			this.ReleasedateLB.TabIndex = 5;
			this.ReleasedateLB.Text = "Releasedate";
			// 
			// ReleaseInput
			// 
			this.ReleaseInput.Location = new System.Drawing.Point(544, 150);
			this.ReleaseInput.Name = "ReleaseInput";
			this.ReleaseInput.Size = new System.Drawing.Size(100, 26);
			this.ReleaseInput.TabIndex = 6;
			this.ReleaseInput.TextChanged += new System.EventHandler(this.ReleaseInput_TextChanged);
			this.ReleaseInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReleaseInput_KeyPress);
			// 
			// AgeResLB
			// 
			this.AgeResLB.AutoSize = true;
			this.AgeResLB.Location = new System.Drawing.Point(540, 207);
			this.AgeResLB.Name = "AgeResLB";
			this.AgeResLB.Size = new System.Drawing.Size(118, 20);
			this.AgeResLB.TabIndex = 7;
			this.AgeResLB.Text = "Age Restriction";
			// 
			// AgeResInput
			// 
			this.AgeResInput.Location = new System.Drawing.Point(544, 230);
			this.AgeResInput.Name = "AgeResInput";
			this.AgeResInput.Size = new System.Drawing.Size(100, 26);
			this.AgeResInput.TabIndex = 8;
			this.AgeResInput.TextChanged += new System.EventHandler(this.AgeResInput_TextChanged);
			// 
			// SumLB
			// 
			this.SumLB.AutoSize = true;
			this.SumLB.Location = new System.Drawing.Point(540, 277);
			this.SumLB.Name = "SumLB";
			this.SumLB.Size = new System.Drawing.Size(76, 20);
			this.SumLB.TabIndex = 9;
			this.SumLB.Text = "Summary";
			// 
			// ActorsLB
			// 
			this.ActorsLB.AutoSize = true;
			this.ActorsLB.Location = new System.Drawing.Point(540, 481);
			this.ActorsLB.Name = "ActorsLB";
			this.ActorsLB.Size = new System.Drawing.Size(55, 20);
			this.ActorsLB.TabIndex = 10;
			this.ActorsLB.Text = "Actors";
			// 
			// ActorsInput
			// 
			this.ActorsInput.Location = new System.Drawing.Point(544, 504);
			this.ActorsInput.Multiline = true;
			this.ActorsInput.Name = "ActorsInput";
			this.ActorsInput.Size = new System.Drawing.Size(540, 82);
			this.ActorsInput.TabIndex = 11;
			this.ActorsInput.TextChanged += new System.EventHandler(this.ActorsInput_TextChanged);
			// 
			// DurLB
			// 
			this.DurLB.AutoSize = true;
			this.DurLB.Location = new System.Drawing.Point(540, 606);
			this.DurLB.Name = "DurLB";
			this.DurLB.Size = new System.Drawing.Size(70, 20);
			this.DurLB.TabIndex = 12;
			this.DurLB.Text = "Duration";
			// 
			// DurationInput
			// 
			this.DurationInput.Location = new System.Drawing.Point(544, 630);
			this.DurationInput.Name = "DurationInput";
			this.DurationInput.Size = new System.Drawing.Size(100, 26);
			this.DurationInput.TabIndex = 13;
			this.DurationInput.TextChanged += new System.EventHandler(this.DurationInput_TextChanged);
			// 
			// GenreLB
			// 
			this.GenreLB.AutoSize = true;
			this.GenreLB.Location = new System.Drawing.Point(540, 678);
			this.GenreLB.Name = "GenreLB";
			this.GenreLB.Size = new System.Drawing.Size(54, 20);
			this.GenreLB.TabIndex = 14;
			this.GenreLB.Text = "Genre";
			// 
			// GenreInput
			// 
			this.GenreInput.Location = new System.Drawing.Point(544, 702);
			this.GenreInput.Name = "GenreInput";
			this.GenreInput.Size = new System.Drawing.Size(332, 26);
			this.GenreInput.TabIndex = 15;
			this.GenreInput.TextChanged += new System.EventHandler(this.GenreInput_TextChanged);
			// 
			// AddMovieNxtBTN
			// 
			this.AddMovieNxtBTN.Enabled = false;
			this.AddMovieNxtBTN.Location = new System.Drawing.Point(764, 792);
			this.AddMovieNxtBTN.Name = "AddMovieNxtBTN";
			this.AddMovieNxtBTN.Size = new System.Drawing.Size(112, 35);
			this.AddMovieNxtBTN.TabIndex = 16;
			this.AddMovieNxtBTN.Text = "Next";
			this.AddMovieNxtBTN.UseVisualStyleBackColor = true;
			this.AddMovieNxtBTN.Click += new System.EventHandler(this.AddMovieNxtBTN_Click);
			// 
			// AddMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1631, 921);
			this.Controls.Add(this.AddMovieNxtBTN);
			this.Controls.Add(this.GenreInput);
			this.Controls.Add(this.GenreLB);
			this.Controls.Add(this.DurationInput);
			this.Controls.Add(this.DurLB);
			this.Controls.Add(this.ActorsInput);
			this.Controls.Add(this.ActorsLB);
			this.Controls.Add(this.SumLB);
			this.Controls.Add(this.AgeResInput);
			this.Controls.Add(this.AgeResLB);
			this.Controls.Add(this.ReleaseInput);
			this.Controls.Add(this.ReleasedateLB);
			this.Controls.Add(this.MovieNameInput);
			this.Controls.Add(this.MovieNameLB);
			this.Controls.Add(this.SumInput);
			this.Controls.Add(this.LogoutBTN);
			this.Controls.Add(this.ReturnBTN);
			this.Name = "AddMovie";
			this.Text = "AddMovie";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ReturnBTN;
		private System.Windows.Forms.Button LogoutBTN;
		private System.Windows.Forms.TextBox SumInput;
		private System.Windows.Forms.Label MovieNameLB;
		private System.Windows.Forms.TextBox MovieNameInput;
		private System.Windows.Forms.Label ReleasedateLB;
		private System.Windows.Forms.TextBox ReleaseInput;
		private System.Windows.Forms.Label AgeResLB;
		private System.Windows.Forms.TextBox AgeResInput;
		private System.Windows.Forms.Label SumLB;
		private System.Windows.Forms.Label ActorsLB;
		private System.Windows.Forms.TextBox ActorsInput;
		private System.Windows.Forms.Label DurLB;
		private System.Windows.Forms.TextBox DurationInput;
		private System.Windows.Forms.Label GenreLB;
		private System.Windows.Forms.TextBox GenreInput;
		private System.Windows.Forms.Button AddMovieNxtBTN;
	}
}