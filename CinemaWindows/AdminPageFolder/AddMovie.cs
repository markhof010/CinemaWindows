using CinemaWindows.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaWindows.AdminPage
{
	public partial class AddMovie : Form
	{
		public AddMovie()
		{
			InitializeComponent();
		}

		private void ReturnBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			//AdminPage form = new AdminPage();
			//form.ShowDialog();
			this.Close();
		}

		private void LogoutBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}

		private void AddMovieNxtBTN_Click(object sender, EventArgs e)
		{
			AddData AD = new AddData();

			string Name = MovieNameInput.Text;
			int Year = Int32.Parse(ReleaseInput.Text);
			int MinimumAge = Int32.Parse(AgeResInput.Text);
			string Summary = SumInput.Text;
			string Actors = ActorsInput.Text;
			int Duration = Int32.Parse(DurationInput.Text);
			string Genre = GenreInput.Text;

			AD.InsertMovie(Name, Year, MinimumAge, Summary, Actors, Duration, Genre);
		}

		private void MovieNameInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(ReleaseInput.Text) && !string.IsNullOrWhiteSpace(AgeResInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}

		private void ReleaseInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(AgeResInput.Text) && !string.IsNullOrWhiteSpace(SumInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}

		private void AgeResInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(SumInput.Text) && !string.IsNullOrWhiteSpace(ActorsInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}

		private void SumInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(ActorsInput.Text) && !string.IsNullOrWhiteSpace(DurationInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}

		private void ActorsInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(DurationInput.Text) && !string.IsNullOrWhiteSpace(GenreInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}

		private void DurationInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(GenreInput.Text) && !string.IsNullOrWhiteSpace(MovieNameInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}

		private void GenreInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(MovieNameInput.Text) && !string.IsNullOrWhiteSpace(ReleaseInput.Text))
			{
				AddMovieNxtBTN.Enabled = true;
			}
		}
	}
}
