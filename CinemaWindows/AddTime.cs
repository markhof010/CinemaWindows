using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaWindows.Database;

namespace CinemaWindows
{
	public partial class AddTime : Form
	{
		private string Title;
		private int Duration;
		private AddData AD;
		private GetData GD;
		public AddTime(string name, int duration)
		{
			InitializeComponent();
			Title = name;
			Duration = duration;
			AD = new AddData();
			GD = new GetData();
			DateTime CurrentDate = DateTime.Now;
			DTP.MinDate = CurrentDate;
			DTP.MaxDate = CurrentDate.AddYears(2);
		}

		private void HomeBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}

		private void AddTimeBTN_Click(object sender, EventArgs e)
		{
			string Date = DTP.Value.ToString("dd/MM/yyyy");
			string Time = textBox1.Text;
			DateTime DT = DateTime.ParseExact((Date + " "+ Time), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

			if (!checkdoubletimes((Int32)NumHall.Value, DT, Duration))
			{
				AD.CreateDateTime(DT, Title, (Int32)NumHall.Value);

				DTP.ResetText();
				textBox1.Clear();
				NumHall.ResetText();
			}
			else
			{
				DTP.ResetText();
				textBox1.Clear();
				NumHall.ResetText();
				MessageBox.Show("The given hall is already in use at the given time. Please try again", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DoneBTN_Click(object sender, EventArgs e)
		{
			string Date = DTP.Value.ToString("dd/MM/yyyy");
			string Time = textBox1.Text;
			DateTime DT = DateTime.ParseExact((Date + " " + Time), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

			if (!checkdoubletimes((Int32)NumHall.Value, DT, Duration))
			{
				AD.CreateDateTime(DT, Title, (Int32)NumHall.Value);

				this.Hide();
				AdminPage form = new AdminPage();
				form.ShowDialog();
				this.Close();
			}
			else
			{
				DTP.ResetText();
				textBox1.Clear();
				NumHall.ResetText();
				MessageBox.Show("The given hall is already in use at the given time. Please try again", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool checkdoubletimes(int Hall, DateTime Date, int Duration)
		{
			Tuple<List<DateTime>, List<int>, List<DateTime>> check = GD.GetAllDates();
			bool checking = false;
			for (int j = 0; j < Duration; j++)
			{
				Date.AddMinutes(1);
				for (int i = 0; i < check.Item1.Count; i++)
				{
					if ((Date > check.Item1[i]) && (Date < check.Item3[i]) && (Hall == check.Item2[i]))
					{
						checking = true;
						break;
					}

				}
			}
			return checking;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text.Length == 5)
			{
				try
				{
					DateTime TBTime = DateTime.ParseExact(textBox1.Text, "HH:mm", CultureInfo.InvariantCulture);
					AddTimeBTN.Enabled = true;
					DoneBTN.Enabled = true;
				}
				catch (FormatException)
				{
					AddTimeBTN.Enabled = false;
					DoneBTN.Enabled = false;
				}				
			}
			else
			{
				AddTimeBTN.Enabled = false;
				DoneBTN.Enabled = false;
			}
		}
	}
}
