using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaWindows.Database;

namespace CinemaWindows
{
	public partial class HomeScreen : Form
	{
		public HomeScreen()
		{
			InitializeComponent();

			GetData GD = new GetData();
			int x = 20;

			foreach(Tuple<string, string, string, string, string> movie in GD.ShowMovies())
			{
				Label movieLabel = new Label();
				movieLabel.Width = 150;
				movieLabel.Height = 60;
				movieLabel.BorderStyle = BorderStyle.FixedSingle;
				movieLabel.Text = "Title: " + movie.Item2;
				movieLabel.Text += "\nGenre: " + movie.Item4;
				movieLabel.Text += "\nDuration: " + movie.Item3 + " minutes";
				movieLabel.Text += "\nAge qualification: " + movie.Item5 +"+";
				MovieInfo MI = new MovieInfo(movie.Item1);

				movieLabel.Click += (s, p) => {
					MI.ShowDialog();
				};
			
				movieLabel.Location = new Point(0 + x, 120);
				movieLabel.AutoSize = false;

				this.Controls.Add(movieLabel);

				x += 200;
			}
		}

		private void loginButon_Click(object sender, EventArgs e)
		{
			Hide();
			InlogPage form = new InlogPage();
			form.ShowDialog();
			Close();
		}

		private void PersonInfoButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			PersonInfo personInfoform = new PersonInfo();
			personInfoform.ShowDialog();
			this.Close();
		}
	}
}
