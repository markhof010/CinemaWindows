using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaWindows.Database;

namespace CinemaWindows
{
	public partial class AmountSeat : Form
	{
        private Tuple<int, int, int, int, double, double, double> HallInfo;
        private List<Tuple<double, int, int, string, bool>> Seats;

        private int DateID { get; set; }

        private int HallID { get; set; }

        private string MovieID { get; set; }

        private int HallNumber { get; set; }

        public AmountSeat(int hallID,int dateID, string movieID, int hallNumber)
		{
			InitializeComponent();
            DateID = dateID;
            HallID = hallID;
            MovieID = movieID;
            HallNumber = hallNumber;
            GetData GD = new GetData();
            HallInfo = GD.GetHallInfo(hallID);
            Seats = GD.GetSeat(HallInfo.Item4);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (seatCheck((int)amountNum.Value))
			{
                Hide();
                ChooseSeats form = new ChooseSeats(HallID, (int)amountNum.Value, DateID, MovieID, HallNumber);
                form.ShowDialog();
                Close();
            }
			else
			{
                DialogResult result = MessageBox.Show("There are not enough seats in the hall. Would you like to try another amount?","Not Enough",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.No)
				{
                    Hide();
                    HomeScreen form = new HomeScreen();
                    form.ShowDialog();
                    Close();
                }
			}
		}

        public bool seatCheck(int Amount)
        {
            bool free = false;
            int count = 0;

            for (int i = 0; i < HallInfo.Item1; i++)
            {
                for (int j = 0; j < HallInfo.Item2; j++)
                {
                    for (int z = 0; z < Seats.Count; z++)
                    {
                        if (Seats[z].Item2 == i && Seats[z].Item3 == j)
                        {
                            if (Seats[z].Item5)
                            {
                                count++;
                                if (count >= Amount)
                                {
                                    free = true;
                                    break;
                                }
                            }
                            else
                            {
                                count = 0;
                            }
                        }
                    }
                    if (free)
                    {
                        break;
                    }
                }
                if (free)
                {
                    break;
                }
                count = 0;
            }

            return free;
        }
    }
}
