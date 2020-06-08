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
			int place2 = 275;
			Tuple<string, string, string, string, string, string> movieInfo = GD.ShowMovieByID(movieId);

			Label LB1 = new Label();
			LB1.Text = "Movie selected: " + movieInfo.Item2 + "\n\nYear: " + movieInfo.Item4 + "\n\nAge restriction:  " + movieInfo.Item3 + "\n\nActors:  " + movieInfo.Item5 + "\n\nSummary:  " + movieInfo.Item6;
			LB1.MaximumSize = new Size(600, 0);
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
				LB2.Cursor = Cursors.Hand;

				LB2.Text = times.Item1[i].ToString("HH:mm dd/MM/yyyy");
				this.Controls.Add(LB2);
				LB2.Click += (sender, EventArgs) => { LB2_Click(sender, EventArgs, movieId); };
				LB2.MouseEnter += new EventHandler(mouseEnter);
				LB2.MouseLeave += new EventHandler(mouseLeave);
				place2 += 20;
			}
		}

		private void InitializeComponent()
		{
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

		public void LB2_Click(object sender, EventArgs e, string movieId)
        {
			GetData GD = new GetData();
			Tuple<string, string, string, string, string, string> movieInfo = GD.ShowMovieByID(movieId);

			string message;
			string title;

			message = "Are you over " + movieInfo.Item3 + " years old?";
			title = "Age check";
			DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.No)
			{
				message = "You're not old enough for this movie\n\nYou can only go if you take someone who is 18 years or older with you\n\nMake sure that person reserves the tickets";
				MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

				this.Hide();
				HomeScreen form = new HomeScreen();
				form.ShowDialog();
				this.Close();
			}
			else
            {
				// code to reserve tickets here
            }
		}
		private void mouseEnter(object sender, EventArgs e)
		{
			Label theLabel = (Label)sender;
			theLabel.BorderStyle = BorderStyle.Fixed3D;
			theLabel.BackColor = Color.FromKnownColor(KnownColor.AliceBlue);
		}

		private void mouseLeave(object sender, EventArgs e)
		{
			Label theLabel = (Label)sender;
			theLabel.BorderStyle = BorderStyle.FixedSingle;
			theLabel.BackColor = Control.DefaultBackColor;
		}
	}
}
