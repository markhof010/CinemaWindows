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
	public partial class HomeScreen : Form
	{
		public HomeScreen()
		{
			InitializeComponent();
		}

		private void loginButon_Click(object sender, EventArgs e)
		{
			InlogPage form = new InlogPage();
			form.Show();
		}
	}
}
