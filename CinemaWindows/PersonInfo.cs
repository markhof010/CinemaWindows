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

namespace CinemaWindows
{
	public partial class PersonInfo : Form
	{




		public PersonInfo(Point Startxy, int amount, int hallID, double totalprice, string movieID, int dateID)
		{
			InitializeComponent();
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
				Overview personInfoform = new Overview(NameInput.Text,SurnameInput.Text,EmailInput.Text);
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
