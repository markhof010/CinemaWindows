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

namespace CinemaWindows.Database
{
	public partial class AdminPage : Form
	{
		public AdminPage()
		{
			InitializeComponent();
		}

		private void LogoutBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}

		private void AddMovieBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddMovie form = new AddMovie();
			form.ShowDialog();
			this.Close();
		}

		private void DelMovieBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			RemoveMovie form = new RemoveMovie();
			form.ShowDialog();
			this.Close();
		}
	}
}
