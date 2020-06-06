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
		// Boolean flags used to determine when a character other than a number is entered.
		private bool ReleaseInputEntered = false;
		private bool AgeResEntered = false;
		private bool DurationEntered = false;
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

		// Handle the KeyDown event to determine the type of character entered into the control.
		private void ReleaseInput_KeyDown(object sender, KeyEventArgs e)
		{
			// Initialize the flag to false.
			ReleaseInputEntered = false;

			// Determine whether the keystroke is a number from the top of the keyboard.
			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				// Determine whether the keystroke is a number from the keypad.
				if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
				{
					// Determine whether the keystroke is a backspace.
					if (e.KeyCode != Keys.Back)
					{
						// A non-numerical keystroke was pressed.
						// Set the flag to true and evaluate in KeyPress event.
						ReleaseInputEntered = true;
					}
				}
			}
			//If shift key was pressed, it's not a number.
			if (Control.ModifierKeys == Keys.Shift)
			{
				ReleaseInputEntered = true;
			}
		}


		// This event occurs after the KeyDown event and can be used to prevent
		// characters from entering the control.
		private void ReleaseInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check for the flag being set in the KeyDown event.
			if (ReleaseInputEntered == true)
			{
				// Stop the character from being entered into the control since it is non-numerical.
				e.Handled = true;
			}
		}

		// Handle the KeyDown event to determine the type of character entered into the control.
		private void AgeResInput_KeyDown(object sender, KeyEventArgs e)
		{
			// Initialize the flag to false.
			AgeResEntered = false;

			// Determine whether the keystroke is a number from the top of the keyboard.
			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				// Determine whether the keystroke is a number from the keypad.
				if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
				{
					// Determine whether the keystroke is a backspace.
					if (e.KeyCode != Keys.Back)
					{
						// A non-numerical keystroke was pressed.
						// Set the flag to true and evaluate in KeyPress event.
						AgeResEntered = true;
					}
				}
			}
			//If shift key was pressed, it's not a number.
			if (Control.ModifierKeys == Keys.Shift)
			{
				AgeResEntered = true;
			}
		}

		// This event occurs after the KeyDown event and can be used to prevent
		// characters from entering the control.
		private void AgeResInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check for the flag being set in the KeyDown event.
			if (AgeResEntered == true)
			{
				// Stop the character from being entered into the control since it is non-numerical.
				e.Handled = true;
			}
		}

		// Handle the KeyDown event to determine the type of character entered into the control.
		private void DurationInput_KeyDown(object sender, KeyEventArgs e)
		{
			// Initialize the flag to false.
			DurationEntered = false;

			// Determine whether the keystroke is a number from the top of the keyboard.
			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				// Determine whether the keystroke is a number from the keypad.
				if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
				{
					// Determine whether the keystroke is a backspace.
					if (e.KeyCode != Keys.Back)
					{
						// A non-numerical keystroke was pressed.
						// Set the flag to true and evaluate in KeyPress event.
						DurationEntered = true;
					}
				}
			}
			//If shift key was pressed, it's not a number.
			if (Control.ModifierKeys == Keys.Shift)
			{
				DurationEntered = true;
			}
		}

		// This event occurs after the KeyDown event and can be used to prevent
		// characters from entering the control.
		private void DurationInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Check for the flag being set in the KeyDown event.
			if (DurationEntered == true)
			{
				// Stop the character from being entered into the control since it is non-numerical.
				e.Handled = true;
			}
		}
	}
}
