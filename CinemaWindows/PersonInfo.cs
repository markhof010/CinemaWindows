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
using System.Runtime.InteropServices;
using CinemaWindows.Database;

namespace CinemaWindows
{
	public partial class PersonInfo : Form
	{
		GetData GD = new GetData();

		Tuple<int, int, int, int, double, string, Tuple<int, int>> information;

		public PersonInfo(int X, int Y, int amount, int hallID, double totalprice, string movieID, int dateID, int hallNumber)
		{
			InitializeComponent();

			information = Tuple.Create(X, Y, amount, hallID, totalprice, movieID, Tuple.Create(dateID, hallNumber));

			titellbl.Text = GD.ShowMovieByID(movieID).Item2;

			seatslbl.Text = "(" + (X + 1).ToString() + "/" + (Y + 1).ToString() + ")";
			for (int i = 1; i < amount; i++)
			{
				seatslbl.Text += ", (" + (X + 1).ToString() + "/" + (Y + 1).ToString() + ")";
			}

			totalpricelbl.Text = totalprice.ToString("0.00");

			timechosenlbl.Text = GD.GetDate(dateID).ToString("HH:mm dd/MM/yyyy");
		}

		private void PersonInfoNext_Click(object sender, EventArgs e)
		{
			bool IsValidEmail(string emailaddress)
			{
				Regex rx = new Regex(
				@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
				return rx.IsMatch(emailaddress);
			}
			if(IsValidEmail(EmailInput.Text))
			{
				this.Hide();
				Overview personInfoform = new Overview(Tuple.Create(NameInput.Text,SurnameInput.Text,EmailInput.Text), information);
				personInfoform.ShowDialog();
				this.Close();
			}
			else
			{
				EmailInput.Clear();
				MessageBox.Show("The email was not valid. Please try again", "Invalid Email",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void NameInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(EmailInput.Text) && !string.IsNullOrWhiteSpace(SurnameInput.Text) && !string.IsNullOrWhiteSpace(NameInput.Text))
			{
				PersonInfoNext.Enabled = true;
			}
			else
			{
				PersonInfoNext.Enabled = false;
			}
		}

		private void SurnameInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(EmailInput.Text) && !string.IsNullOrWhiteSpace(SurnameInput.Text) && !string.IsNullOrWhiteSpace(NameInput.Text))
			{
				PersonInfoNext.Enabled = true;
			}
			else
			{
				PersonInfoNext.Enabled = false;
			}
		}

		private void EmailInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(EmailInput.Text) && !string.IsNullOrWhiteSpace(SurnameInput.Text) && !string.IsNullOrWhiteSpace(NameInput.Text))
			{
				PersonInfoNext.Enabled = true;
			}
			else
			{
				PersonInfoNext.Enabled = false;
			}
		}
	}
}
