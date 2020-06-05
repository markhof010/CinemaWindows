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
	}
}
