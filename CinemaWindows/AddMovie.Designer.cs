namespace CinemaWindows
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
            this.AddMovieNxtBTN = new System.Windows.Forms.Button();
            this.GenreInput = new System.Windows.Forms.TextBox();
            this.GenreLB = new System.Windows.Forms.Label();
            this.DurationInput = new System.Windows.Forms.TextBox();
            this.DurLB = new System.Windows.Forms.Label();
            this.ActorsInput = new System.Windows.Forms.TextBox();
            this.ActorsLB = new System.Windows.Forms.Label();
            this.SumLB = new System.Windows.Forms.Label();
            this.AgeResInput = new System.Windows.Forms.TextBox();
            this.AgeResLB = new System.Windows.Forms.Label();
            this.ReleaseInput = new System.Windows.Forms.TextBox();
            this.ReleasedateLB = new System.Windows.Forms.Label();
            this.MovieNameInput = new System.Windows.Forms.TextBox();
            this.MovieNameLB = new System.Windows.Forms.Label();
            this.SumInput = new System.Windows.Forms.TextBox();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.ReturnBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMovieNxtBTN
            // 
            this.AddMovieNxtBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMovieNxtBTN.Enabled = false;
            this.AddMovieNxtBTN.Location = new System.Drawing.Point(1124, 1031);
            this.AddMovieNxtBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMovieNxtBTN.Name = "AddMovieNxtBTN";
            this.AddMovieNxtBTN.Size = new System.Drawing.Size(149, 44);
            this.AddMovieNxtBTN.TabIndex = 33;
            this.AddMovieNxtBTN.Text = "Next";
            this.AddMovieNxtBTN.UseVisualStyleBackColor = true;
            this.AddMovieNxtBTN.Click += new System.EventHandler(this.AddMovieNxtBTN_Click);
            // 
            // GenreInput
            // 
            this.GenreInput.Location = new System.Drawing.Point(831, 919);
            this.GenreInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenreInput.Name = "GenreInput";
            this.GenreInput.Size = new System.Drawing.Size(441, 31);
            this.GenreInput.TabIndex = 32;
            this.GenreInput.TextChanged += new System.EventHandler(this.GenreInput_TextChanged);
            // 
            // GenreLB
            // 
            this.GenreLB.AutoSize = true;
            this.GenreLB.Location = new System.Drawing.Point(825, 889);
            this.GenreLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.Size = new System.Drawing.Size(71, 25);
            this.GenreLB.TabIndex = 31;
            this.GenreLB.Text = "Genre";
            // 
            // DurationInput
            // 
            this.DurationInput.Location = new System.Drawing.Point(831, 829);
            this.DurationInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DurationInput.Name = "DurationInput";
            this.DurationInput.Size = new System.Drawing.Size(132, 31);
            this.DurationInput.TabIndex = 30;
            this.DurationInput.TextChanged += new System.EventHandler(this.DurationInput_TextChanged);
            this.DurationInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DurationInput_KeyDown);
            this.DurationInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DurationInput_KeyPress);
            // 
            // DurLB
            // 
            this.DurLB.AutoSize = true;
            this.DurLB.Location = new System.Drawing.Point(825, 799);
            this.DurLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DurLB.Name = "DurLB";
            this.DurLB.Size = new System.Drawing.Size(211, 25);
            this.DurLB.TabIndex = 29;
            this.DurLB.Text = "Duration (in minutes)";
            // 
            // ActorsInput
            // 
            this.ActorsInput.Location = new System.Drawing.Point(831, 671);
            this.ActorsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActorsInput.Multiline = true;
            this.ActorsInput.Name = "ActorsInput";
            this.ActorsInput.Size = new System.Drawing.Size(719, 102);
            this.ActorsInput.TabIndex = 28;
            this.ActorsInput.TextChanged += new System.EventHandler(this.ActorsInput_TextChanged);
            // 
            // ActorsLB
            // 
            this.ActorsLB.AutoSize = true;
            this.ActorsLB.Location = new System.Drawing.Point(825, 642);
            this.ActorsLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActorsLB.Name = "ActorsLB";
            this.ActorsLB.Size = new System.Drawing.Size(73, 25);
            this.ActorsLB.TabIndex = 27;
            this.ActorsLB.Text = "Actors";
            // 
            // SumLB
            // 
            this.SumLB.AutoSize = true;
            this.SumLB.Location = new System.Drawing.Point(825, 388);
            this.SumLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumLB.Name = "SumLB";
            this.SumLB.Size = new System.Drawing.Size(102, 25);
            this.SumLB.TabIndex = 26;
            this.SumLB.Text = "Summary";
            // 
            // AgeResInput
            // 
            this.AgeResInput.Location = new System.Drawing.Point(831, 329);
            this.AgeResInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgeResInput.Name = "AgeResInput";
            this.AgeResInput.Size = new System.Drawing.Size(132, 31);
            this.AgeResInput.TabIndex = 25;
            this.AgeResInput.TextChanged += new System.EventHandler(this.AgeResInput_TextChanged);
            this.AgeResInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgeResInput_KeyDown);
            this.AgeResInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeResInput_KeyPress);
            // 
            // AgeResLB
            // 
            this.AgeResLB.AutoSize = true;
            this.AgeResLB.Location = new System.Drawing.Point(825, 300);
            this.AgeResLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeResLB.Name = "AgeResLB";
            this.AgeResLB.Size = new System.Drawing.Size(349, 25);
            this.AgeResLB.TabIndex = 24;
            this.AgeResLB.Text = "Age Restriction (between 0 and 99)";
            // 
            // ReleaseInput
            // 
            this.ReleaseInput.Location = new System.Drawing.Point(831, 229);
            this.ReleaseInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReleaseInput.Name = "ReleaseInput";
            this.ReleaseInput.Size = new System.Drawing.Size(132, 31);
            this.ReleaseInput.TabIndex = 23;
            this.ReleaseInput.TextChanged += new System.EventHandler(this.ReleaseInput_TextChanged);
            this.ReleaseInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReleaseInput_KeyDown);
            this.ReleaseInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReleaseInput_KeyPress);
            // 
            // ReleasedateLB
            // 
            this.ReleasedateLB.AutoSize = true;
            this.ReleasedateLB.Location = new System.Drawing.Point(825, 200);
            this.ReleasedateLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReleasedateLB.Name = "ReleasedateLB";
            this.ReleasedateLB.Size = new System.Drawing.Size(139, 25);
            this.ReleasedateLB.TabIndex = 22;
            this.ReleasedateLB.Text = "Releasedate ";
            // 
            // MovieNameInput
            // 
            this.MovieNameInput.Location = new System.Drawing.Point(831, 136);
            this.MovieNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieNameInput.Name = "MovieNameInput";
            this.MovieNameInput.Size = new System.Drawing.Size(441, 31);
            this.MovieNameInput.TabIndex = 21;
            this.MovieNameInput.TextChanged += new System.EventHandler(this.MovieNameInput_TextChanged);
            // 
            // MovieNameLB
            // 
            this.MovieNameLB.AutoSize = true;
            this.MovieNameLB.Location = new System.Drawing.Point(825, 106);
            this.MovieNameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieNameLB.Name = "MovieNameLB";
            this.MovieNameLB.Size = new System.Drawing.Size(129, 25);
            this.MovieNameLB.TabIndex = 20;
            this.MovieNameLB.Text = "Movie name";
            // 
            // SumInput
            // 
            this.SumInput.Location = new System.Drawing.Point(831, 416);
            this.SumInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SumInput.Multiline = true;
            this.SumInput.Name = "SumInput";
            this.SumInput.Size = new System.Drawing.Size(719, 202);
            this.SumInput.TabIndex = 19;
            this.SumInput.TextChanged += new System.EventHandler(this.SumInput_TextChanged);
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.Location = new System.Drawing.Point(2151, 15);
            this.LogoutBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(149, 44);
            this.LogoutBTN.TabIndex = 18;
            this.LogoutBTN.Text = "Logout";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // ReturnBTN
            // 
            this.ReturnBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBTN.Location = new System.Drawing.Point(16, 15);
            this.ReturnBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnBTN.Name = "ReturnBTN";
            this.ReturnBTN.Size = new System.Drawing.Size(149, 44);
            this.ReturnBTN.TabIndex = 17;
            this.ReturnBTN.Text = "Return";
            this.ReturnBTN.UseVisualStyleBackColor = true;
            this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2316, 1258);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddMovieNxtBTN;
		private System.Windows.Forms.TextBox GenreInput;
		private System.Windows.Forms.Label GenreLB;
		private System.Windows.Forms.TextBox DurationInput;
		private System.Windows.Forms.Label DurLB;
		private System.Windows.Forms.TextBox ActorsInput;
		private System.Windows.Forms.Label ActorsLB;
		private System.Windows.Forms.Label SumLB;
		private System.Windows.Forms.TextBox AgeResInput;
		private System.Windows.Forms.Label AgeResLB;
		private System.Windows.Forms.TextBox ReleaseInput;
		private System.Windows.Forms.Label ReleasedateLB;
		private System.Windows.Forms.TextBox MovieNameInput;
		private System.Windows.Forms.Label MovieNameLB;
		private System.Windows.Forms.TextBox SumInput;
		private System.Windows.Forms.Button LogoutBTN;
		private System.Windows.Forms.Button ReturnBTN;
	}
}