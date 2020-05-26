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
	public partial class PersonInfo : Form
	{
		public PersonInfo()
		{
			InitializeComponent();
		}

		private void PersonInfoNext_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen personInfoform = new HomeScreen();
			personInfoform.ShowDialog();
			this.Close();
		}

		private void NameInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(SurnameInput.Text) && !string.IsNullOrWhiteSpace(EmailInput.Text))
			{
				PersonInfoNext.Enabled = true;
			}
		}

		private void SurnameInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(NameInput.Text) && !string.IsNullOrWhiteSpace(EmailInput.Text))
			{
				PersonInfoNext.Enabled = true;
			}
		}

		private void EmailInput_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(SurnameInput.Text) && !string.IsNullOrWhiteSpace(NameInput.Text))
			{
				PersonInfoNext.Enabled = true;
			}
		}
	}
}
