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
	public partial class InlogPage : Form
	{
		public InlogPage()
		{
			InitializeComponent();
		}

		private void HomePageBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}

		private void AdminPageBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminPage form = new AdminPage();
			form.ShowDialog();
			this.Close();
		}
	}
}
