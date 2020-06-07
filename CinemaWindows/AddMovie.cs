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
	public partial class AddMovie : Form
	{
		private bool ReleaseInputEntered = false;
		private bool AgeResEntered = false;
		private bool DurationEntered = false;
		public AddMovie()
		{
			InitializeComponent();
			ReleasedateLB.Text += $"(between 1800 and {DateTime.Now.ToString("yyyy")})";
		}

		private void ReturnBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminPage form = new AdminPage();
			form.ShowDialog();
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

			if (Year <= 1800 || Year > Convert.ToInt32((DateTime.Now.ToString("yyyy"))))
			{
				ReleaseInput.Clear();
				MessageBox.Show("The year of release was not valid. Please try again", "Invalid year of release", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (MinimumAge < 0 || MinimumAge > 99)
			{
				AgeResInput.Clear();
				MessageBox.Show("The minimum age was not valid. Please try again", "Invalid minimum age", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				AD.InsertMovie(Name, Year, MinimumAge, Summary, Actors, Duration, Genre);
				this.Hide();
				AddTime form = new AddTime(Name, Duration);
				form.ShowDialog();
				this.Close();
			}			
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

		private void ReleaseInput_KeyDown(object sender, KeyEventArgs e)
		{
			ReleaseInputEntered = false;

			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
				{
					if (e.KeyCode != Keys.Back)
					{
						ReleaseInputEntered = true;
					}
				}
			}
			if (Control.ModifierKeys == Keys.Shift)
			{
				ReleaseInputEntered = true;
			}
		}

		private void ReleaseInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (ReleaseInputEntered == true)
			{
				e.Handled = true;
			}
		}

		private void AgeResInput_KeyDown(object sender, KeyEventArgs e)
		{
			AgeResEntered = false;

			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
				{
					if (e.KeyCode != Keys.Back)
					{
						AgeResEntered = true;
					}
				}
			}
			if (Control.ModifierKeys == Keys.Shift)
			{
				AgeResEntered = true;
			}
		}

		private void AgeResInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (AgeResEntered == true)
			{
				e.Handled = true;
			}
		}

		private void DurationInput_KeyDown(object sender, KeyEventArgs e)
		{
			DurationEntered = false;

			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
				{
					if (e.KeyCode != Keys.Back)
					{
						DurationEntered = true;
					}
				}
			}
			if (Control.ModifierKeys == Keys.Shift)
			{
				DurationEntered = true;
			}
		}

		private void DurationInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (DurationEntered == true)
			{
				e.Handled = true;
			}
		}
	}
}
