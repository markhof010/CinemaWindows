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
				movieLabel.Cursor = Cursors.Hand;
				movieLabel.Text = "Title: " + movie.Item2;
				movieLabel.Text += "\nGenre: " + movie.Item4;
				movieLabel.Text += "\nDuration: " + movie.Item3 + " minutes";
				movieLabel.Text += "\nAge qualification: " + movie.Item5 +"+";
				MovieInfo MI = new MovieInfo(movie.Item1);

				movieLabel.Click += (s, p) => {
					MI.ShowDialog();
				};

				movieLabel.MouseEnter += new EventHandler(mouseEnter);
				movieLabel.MouseLeave += new EventHandler(mouseLeave);

				movieLabel.Location = new Point(0 + x, 120);
				movieLabel.AutoSize = false;

				this.Controls.Add(movieLabel);

				x += 200;
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

		private void MenuBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			RestaurantMenu form = new RestaurantMenu();
			form.ShowDialog();
			this.Close();
		}

		private void ContactBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			Contact form = new Contact();
			form.ShowDialog();
			this.Close();
		}

		private void TicketCodeBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddTime form = new AddTime("Transformers", 90);
			form.ShowDialog();
			this.Close();
		}
	}
}
