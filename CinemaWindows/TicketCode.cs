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
	public partial class TicketCode : Form
	{
		public TicketCode()
		{
			InitializeComponent();
            DateTime Time = new DateTime(2020, 7, 24);
            string MovieName = "Star Wars";
            int X = 15;
            int Y = 15;
            int TheatherHall = 1;

            //Takes the first 3 letters of the movie and makes them all caps
            string MovieNameShort = MovieName.Substring(0, 3).ToUpper();

            Label LB1 = new Label();
            LB1.Text = (Time.ToString("mm")) + (Time.ToString("HH")) + (Time.ToString("dd")) +
                (Time.ToString("MM")) + (Time.ToString("yyyy")) + MovieNameShort + X + Y + TheatherHall;
            LB1.Location = new Point((this.Width / 2) - 100, 100);
            LB1.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB1.AutoSize = true;
            this.Controls.Add(LB1);
        }

        /// <summary>
        /// Creates a ticketID for the customer
        /// </summary>
        /// <param name="Time">The time the movie starts</param>
        /// <param name="MovieName">The name of the movie</param>
        /// <param name="X">The X start position the reservation</param>
        /// <param name="Y">The Y start position the reservation</param>
        /// <param name="TheatherHall">The hall the movie is playing</param>
        /// <returns>The ticketID</returns>


        private void HomeBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}
	}
}
