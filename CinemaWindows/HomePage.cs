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
			/*GetData GD = new GetData();
			int hallid = GD.GetHallID(18);
			InitializeComponent();
			Label LB1 = new Label();
			LB1.Text = hallid.ToString();
			this.Controls.Add(LB1);*/
			GetData GD = new GetData();
			int x = 20;


			foreach(Tuple<string, string, string, string, string, string, string, string> movie in GD.ShowMovies())
			{
				Label movieLabel = new Label();

				movieLabel.Width = 150;
				movieLabel.BorderStyle = BorderStyle.FixedSingle;
				movieLabel.Text = "Title: " + movie.Item2.ToString();
				movieLabel.Text = "Year: " + movie.Item3.ToString();
				movieLabel.Text = "Title: " + movie.Item2.ToString();
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

		public void showMovies()
        {
			
		}
	}
}
