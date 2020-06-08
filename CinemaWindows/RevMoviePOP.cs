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

namespace CinemaWindows
{
	public partial class RevMoviePOP : Form
	{
		private string MovieID;
		private string Title;

		public RevMoviePOP(string movieID, string title)
		{
			InitializeComponent();
			MovieID = movieID;
			Title = title;
			this.Text += Title;
		}

		private void MovieBTN_Click(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Are you sure you want to remove "+ Title + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (confirmation == DialogResult.Yes)
			{
				DelData DD = new DelData();
				DD.DeleteMovie(Convert.ToInt32(MovieID));
				
				this.Hide();
				RemoveMovie delform = new RemoveMovie();
				delform.ShowDialog();
				this.Close();
			}
			else
			{
				this.Hide();
				RemoveMovie delform = new RemoveMovie();
				delform.ShowDialog();
				this.Close();
			}
		}

		private void TimeBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			DelTimes delform = new DelTimes(MovieID, Title);
			delform.ShowDialog();
			this.Close();
		}
	}
}
