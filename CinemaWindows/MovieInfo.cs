using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using CinemaWindows.Database;


namespace CinemaWindows
{
	public partial class MovieInfo : Form
	{
		public MovieInfo()
		{
			InitializeComponent();
			GetData GD = new GetData();


			this.AutoScroll = true;
			int place = 120;

			Tuple<string, string, string, string, string, string> movieInfo = GD.ShowMovieByID("1");

			Label LB1 = new Label();
			LB1.Text = "Movie selected: " + movieInfo.Item2 + "\nYear: " + movieInfo.Item4 + "\nAge restriction:  " + movieInfo.Item3 + "\nActors:  " + movieInfo.Item5 + "\nSummary:  " + movieInfo.Item6;
			LB1.Location = new Point((this.Width / 2) - 100, place);
			LB1.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB1.AutoSize = true;
			this.Controls.Add(LB1);






		}



		private void InitializeComponent()
		{
			this.MovieIDInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.MovieIDsubmitButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MovieIDInput
			// 
			this.MovieIDInput.Location = new System.Drawing.Point(53, 415);
			this.MovieIDInput.Name = "MovieIDInput";
			this.MovieIDInput.Size = new System.Drawing.Size(100, 31);
			this.MovieIDInput.TabIndex = 0;
			this.MovieIDInput.TextChanged += new System.EventHandler(this.MovieIDInput_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 385);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Please type the movie ID";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// MovieIDsubmitButton
			// 
			this.MovieIDsubmitButton.Location = new System.Drawing.Point(53, 494);
			this.MovieIDsubmitButton.Name = "MovieIDsubmitButton";
			this.MovieIDsubmitButton.Size = new System.Drawing.Size(100, 34);
			this.MovieIDsubmitButton.TabIndex = 2;
			this.MovieIDsubmitButton.Text = "Submit";
			this.MovieIDsubmitButton.UseVisualStyleBackColor = true;
			this.MovieIDsubmitButton.Click += new System.EventHandler(this.MovieIDsubmitButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Movies:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// MovieInfo
			// 
			this.ClientSize = new System.Drawing.Size(948, 655);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MovieIDsubmitButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MovieIDInput);
			this.Name = "MovieInfo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private TextBox MovieIDInput;
		private Label label1;

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void MovieIDInput_TextChanged(object sender, EventArgs e)
		{

		}

		private Button MovieIDsubmitButton;

		private void MovieIDsubmitButton_Click(object sender, EventArgs e)
		{
			



		}

		private Label label2;

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
