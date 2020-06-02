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
			GetData GD = new GetData();
			int hallid = GD.GetHallID(18);
			InitializeComponent();
			Label LB1 = new Label();
			LB1.Text = hallid.ToString();
			this.Controls.Add(LB1);
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

		private void MovieInfo_Click(object sender, EventArgs e)
		{
			Hide();
			MovieInfo form = new MovieInfo();
			form.ShowDialog();
			Close();
		}

		private void ChooseMovieButton_Click(object sender, EventArgs e)
		{
			Hide();
			ChooseMovie form = new ChooseMovie();
			form.ShowDialog();
			Close();
		}
	}
}
