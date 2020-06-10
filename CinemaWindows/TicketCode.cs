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
	public partial class TicketCode : Form
	{

        AddData AD = new AddData();
		public TicketCode(int X, int Y, int TheatherHall, string MovieName, DateTime Time, Tuple<int, int, int, int, double, string, Tuple<int, int>> MovieInfo, Tuple<string, string, string> PersonInfo)
		{
			InitializeComponent();

            //Takes the first 3 letters of the movie and makes them all caps
            string MovieNameShort = MovieName.Substring(0, 3).ToUpper();
            string TicketCode = (Time.ToString("mm")) + (Time.ToString("HH")) + (Time.ToString("dd")) +
                (Time.ToString("MM")) + (Time.ToString("yyyy")) + MovieNameShort + X + Y + TheatherHall;
            
            Label LB1 = new Label();
            LB1.Location = new Point((this.Width / 2) - 100, 100);
            LB1.Text = "TicketCode:\n" + TicketCode;
            LB1.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB1.AutoSize = true;
            this.Controls.Add(LB1);

            AD.ReserveTicket((PersonInfo.Item1 + " " + PersonInfo.Item2), PersonInfo.Item3, TicketCode, Convert.ToInt32(MovieInfo.Item6), MovieInfo.Item3, MovieInfo.Item1, MovieInfo.Item2, MovieInfo.Item7.Item1, MovieInfo.Item7.Item2, MovieInfo.Item5, MovieInfo.Item4);
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
