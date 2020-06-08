using CinemaWindows.Database;
using Org.BouncyCastle.Asn1.Cms;
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
	public partial class DelTimes : Form
	{
		private string MovieID;
		private string Title;
		private int DateID;
		private DateTime time;

		public DelTimes(string movieID, string title)
		{
			MovieID = movieID;
			Title = title;

			InitializeComponent();

			GetData GD = new GetData();
			
			Tuple<List<DateTime>, List<int>, List<int>> times = GD.GetTime(Convert.ToInt32(MovieID));

			int place = 200;

			for (int i = 0; i < times.Item1.Count; i++)
			{
				Label LB2 = new Label();
				LB2.Location = new Point(200, place);
				LB2.AutoSize = true;
				LB2.BorderStyle = BorderStyle.FixedSingle;

				LB2.Text = "[" + (i + 1) + "] " + times.Item1[i].ToString("HH:mm dd/MM/yyyy");
				this.Controls.Add(LB2);
				DateID = times.Item2[i];
				time = times.Item1[i];

				LB2.Click += ConfirmBTN_Click;

				LB2.MouseEnter += new EventHandler(mouseEnter);
				LB2.MouseLeave += new EventHandler(mouseLeave);

				place += 20;
			}
		}

		private void mouseEnter(object sender, EventArgs e)
		{
			Label theLabel = (Label)sender;
			theLabel.BorderStyle = BorderStyle.Fixed3D;
			theLabel.BackColor = Color.FromKnownColor(KnownColor.AliceBlue);
		}

		private void mouseLeave(object sender, EventArgs e)
		{
			Label theLabel = (Label)sender;
			theLabel.BorderStyle = BorderStyle.FixedSingle;
			theLabel.BackColor = Control.DefaultBackColor;
		}

		private void ConfirmBTN_Click(object sender, EventArgs e)
		{
			DialogResult confirmation = MessageBox.Show("Are you sure you want to remove the time:" + time.ToString("HH:mm dd/MM/yyyy") + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (confirmation == DialogResult.Yes)
			{
				DelData DD = new DelData();
				DD.DeleteTime(Convert.ToInt32(DateID));

				this.Hide();
				DelTimes delform = new DelTimes(MovieID,Title);
				delform.ShowDialog();
				this.Close();
			}
			else
			{
				this.Hide();
				DelTimes delform = new DelTimes(MovieID, Title);
				delform.ShowDialog();
				this.Close();
			}
		}

		private void ReturnBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			RemoveMovie delform = new RemoveMovie();
			delform.ShowDialog();
			this.Close();
		}
	}
}
