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
		public MovieInfo(string movieId)
		{
			InitializeComponent();
			GetData GD = new GetData();

			this.AutoScroll = true;
			int place = 120;
			int place2 = 200;
			Tuple<string, string, string, string, string, string> movieInfo = GD.ShowMovieByID(movieId);

			Label LB1 = new Label();
			LB1.Text = "Movie selected: " + movieInfo.Item2 + "\nYear: " + movieInfo.Item4 + "\nAge restriction:  " + movieInfo.Item3 + "\nActors:  " + movieInfo.Item5 + "\nSummary:  " + movieInfo.Item6;
			LB1.Location = new Point(50, place);
			LB1.AutoSize = true;
			this.Controls.Add(LB1);

			int MovieId = Convert.ToInt32(movieInfo.Item1);

			Tuple<List<DateTime>, List<int>, List<int>> times = GD.GetTime(MovieId);

			for (int i = 0; i < times.Item1.Count; i++)
			{
				Label LB2 = new Label();
				LB2.Location = new Point(50, place2);
				LB2.AutoSize = true;
				LB2.BorderStyle = BorderStyle.FixedSingle;

				LB2.Text = "[" + (i + 1) + "] " + times.Item1[i].ToString("HH:mm dd/MM/yyyy");
				this.Controls.Add(LB2);

				LB2.Click += HomeScreenBTN_Click;

				place2 += 20;
			}
		}

		private void InitializeComponent()
		{
			// 
			// MovieInfo
			// 
			this.ClientSize = new System.Drawing.Size(948, 655);
	
			this.Name = "MovieInfo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void HomeScreenBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}
	}
}
