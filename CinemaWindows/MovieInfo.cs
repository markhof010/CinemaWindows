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
			this.label1 = new System.Windows.Forms.Label();
			this.DateAndTimeYesButton = new System.Windows.Forms.Button();
			this.DateAndTimeNoButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(247, 456);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(413, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Would you like to see the date and times?";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// DateAndTimeYesButton
			// 
			this.DateAndTimeYesButton.Location = new System.Drawing.Point(287, 514);
			this.DateAndTimeYesButton.Name = "DateAndTimeYesButton";
			this.DateAndTimeYesButton.Size = new System.Drawing.Size(133, 53);
			this.DateAndTimeYesButton.TabIndex = 1;
			this.DateAndTimeYesButton.Text = "Yes";
			this.DateAndTimeYesButton.UseVisualStyleBackColor = true;
			this.DateAndTimeYesButton.Click += new System.EventHandler(this.DateAndTimeYesButton_Click);
			// 
			// DateAndTimeNoButton
			// 
			this.DateAndTimeNoButton.Location = new System.Drawing.Point(463, 514);
			this.DateAndTimeNoButton.Name = "DateAndTimeNoButton";
			this.DateAndTimeNoButton.Size = new System.Drawing.Size(133, 53);
			this.DateAndTimeNoButton.TabIndex = 2;
			this.DateAndTimeNoButton.Text = "No";
			this.DateAndTimeNoButton.UseVisualStyleBackColor = true;
			this.DateAndTimeNoButton.Click += new System.EventHandler(this.DateAndTimeNoButton_Click);
			// 
			// MovieInfo
			// 
			this.ClientSize = new System.Drawing.Size(948, 655);
			this.Controls.Add(this.DateAndTimeNoButton);
			this.Controls.Add(this.DateAndTimeYesButton);
			this.Controls.Add(this.label1);
			this.Name = "MovieInfo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Label label1;

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private Button DateAndTimeYesButton;
		private Button DateAndTimeNoButton;

		private void DateAndTimeYesButton_Click(object sender, EventArgs e)
		{

		}

		private void DateAndTimeNoButton_Click(object sender, EventArgs e)
		{
			Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			Close();
		}
	}
}
