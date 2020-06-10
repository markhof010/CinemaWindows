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
	public partial class Overview : Form
	{
		GetData GD = new GetData();
		AddData AD = new AddData();
		UpdateData UD = new UpdateData();

		private string Title;

		Tuple<int, int, int, int, double, string, Tuple<int, int>> MovieInfo;
		Tuple<string, string, string> PersonInfo;

		DateTime Time;

		public Overview(Tuple<string,string,string> personInfo, Tuple<int, int, int, int, double, string, Tuple<int, int>> movieInfo)
		{
			InitializeComponent();

			MovieInfo = movieInfo;
			PersonInfo = personInfo;

			Namelbl.Text = PersonInfo.Item1;
			surnameInputlbl.Text = PersonInfo.Item2;
			emailInputlbl.Text = PersonInfo.Item3;
			
			Title = GD.ShowMovieByID(movieInfo.Item6).Item2;
			titellbl.Text = Title;

			seatslbl.Text = "(" + (movieInfo.Item1 + 1).ToString() + "/" + (movieInfo.Item2 + 1).ToString() + ")";
			for (int i = 1; i < movieInfo.Item3; i++)
			{
				seatslbl.Text += ", (" + (movieInfo.Item1 + 1).ToString() + "/" + (movieInfo.Item2 + 1).ToString() + ")";
			}

			totalpricelbl.Text = movieInfo.Item5.ToString("0.00");

			Time = GD.GetDate(movieInfo.Item7.Item1);
			timechosenlbl.Text = Time.ToString("HH:mm dd/MM/yyyy");
		}

		private void reserveBTN_Click(object sender, EventArgs e)
		{
			UD.switchAvail(MovieInfo.Item1,MovieInfo.Item2,MovieInfo.Item4,MovieInfo.Item3, false);
			
			this.Hide();
			TicketCode Ticket = new TicketCode(MovieInfo.Item1, MovieInfo.Item2, MovieInfo.Item7.Item2, Title ,Time, MovieInfo, PersonInfo);
			Ticket.ShowDialog();
			this.Close();
		}

		private void cancelBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen Home = new HomeScreen();
			Home.ShowDialog();
			this.Close();
		}
	}
}
