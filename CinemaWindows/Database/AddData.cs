using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace CinemaWindows.Database
{
	class AddData : Connecter
	{

		public void InsertMovie(string Name, int Year, int MinimumAge, string Summary, string Actors, int Duration, string Genre)
		{
			try
			{
				Connection.Open();
				string stringToInsert = "INSERT INTO movie (MovieName, MovieYear, MovieMinimumAge, MovieSummary, MovieActors, MovieDuration, MovieGenre) " +
					"VALUES (@Name, @Year, @MAge, @MSummary, @MovieActors, @MovieDuration, @MovieGenre)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				MySqlParameter NameParam = new MySqlParameter("@Name", MySqlDbType.VarChar);
				MySqlParameter YearParam = new MySqlParameter("@Year", MySqlDbType.Int32);
				MySqlParameter MAgeParam = new MySqlParameter("@MAge", MySqlDbType.Int32);
				MySqlParameter MSummaryParam = new MySqlParameter("@MSummary", MySqlDbType.LongText);
				MySqlParameter ActorsParam = new MySqlParameter("@MovieActors", MySqlDbType.LongText);
				MySqlParameter DurationParam = new MySqlParameter("@MovieDuration", MySqlDbType.Int32);
				MySqlParameter GenreParam = new MySqlParameter("@MovieGenre", MySqlDbType.VarChar);

				NameParam.Value = Name;
				YearParam.Value = Year;
				MAgeParam.Value = MinimumAge;
				MSummaryParam.Value = Summary;
				ActorsParam.Value = Actors;
				DurationParam.Value = Duration;
				GenreParam.Value = Genre;

				command.Parameters.Add(NameParam);
				command.Parameters.Add(YearParam);
				command.Parameters.Add(MAgeParam);
				command.Parameters.Add(MSummaryParam);
				command.Parameters.Add(ActorsParam);
				command.Parameters.Add(DurationParam);
				command.Parameters.Add(GenreParam);

				command.Prepare();
				command.ExecuteNonQuery();
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				Connection.Close();
			}
		}

		public void CreateDateTime(DateTime DT, string Title, int Hall)
		{
			try
			{
				Connection.Open();

				GetData GD = new GetData();

				string stringToInsert = @"INSERT INTO date (MovieID, DateTime, Hall) VALUES (@MovieID, @DateTime, @Hall)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				MySqlParameter MovieIDParam = new MySqlParameter("@MovieID", MySqlDbType.Double);
				MySqlParameter DTParam = new MySqlParameter("@DateTime", MySqlDbType.DateTime);
				MySqlParameter HallParam = new MySqlParameter("@Hall", MySqlDbType.Int32);

				MovieIDParam.Value = GD.GetMovieID(Title);
				DTParam.Value = DT;
				HallParam.Value = Hall;

				command.Parameters.Add(MovieIDParam);
				command.Parameters.Add(DTParam);
				command.Parameters.Add(HallParam);

				command.Prepare();
				command.ExecuteNonQuery();
			}
			catch (MySqlException ex)
			{

				if (ex.Message.Contains("Duplicate"))
				{
					
				}
				//throw;
			}
			finally
			{
				Connection.Close();
			}
		}

		public void ReserveTicket(string Owner, string Email, string TicketCode, int MovieID, int Amount, int SeatX, int SeatY, int DateID, int Hall, double TotalPrice, int HallID)
		{
			try
			{
				Connection.Open();

				string stringToInsert = @"INSERT INTO ticket (Owner, Email, TicketCode, MovieID, Amount, seatX, seatY, DateID, HallID, TotalPrice, Hall) VALUES (@Owner, @Email, @TicketCode, @MovieID, @Amount, @seatX, @seatY, @DateID, @HallID, @TotalPrice, @Hall)";

				MySqlCommand command = new MySqlCommand(stringToInsert, Connection);
				MySqlParameter OwnerParam = new MySqlParameter("@Owner", MySqlDbType.VarChar);
				MySqlParameter EmailParam = new MySqlParameter("@Email", MySqlDbType.VarChar);
				MySqlParameter TicketCodeParam = new MySqlParameter("@TicketCode", MySqlDbType.VarChar);
				MySqlParameter MovieIDParam = new MySqlParameter("@MovieID", MySqlDbType.Int32);
				MySqlParameter AmountParam = new MySqlParameter("@Amount", MySqlDbType.Int32);
				MySqlParameter seatXParam = new MySqlParameter("@seatX", MySqlDbType.Int32);
				MySqlParameter seatYParam = new MySqlParameter("@seatY", MySqlDbType.Int32);
				MySqlParameter DateIDParam = new MySqlParameter("@DateID", MySqlDbType.Int32);
				MySqlParameter HallIDParam = new MySqlParameter("@HallID", MySqlDbType.Int32);
				MySqlParameter TotalPriceParam = new MySqlParameter("@TotalPrice", MySqlDbType.Double);
				MySqlParameter HallParam = new MySqlParameter("@Hall", MySqlDbType.Int32);


				//TicketIDParam.Value = TicketID;
				OwnerParam.Value = Owner;
				EmailParam.Value = Email;
				TicketCodeParam.Value = TicketCode;
				MovieIDParam.Value = MovieID;
				AmountParam.Value = Amount;
				seatXParam.Value = SeatX;
				seatYParam.Value = SeatY;
				DateIDParam.Value = DateID;
				HallParam.Value = Hall;
				HallIDParam.Value = HallID;
				TotalPriceParam.Value = TotalPrice;

				//command.Parameters.Add(TicketIDParam);
				command.Parameters.Add(OwnerParam);
				command.Parameters.Add(EmailParam);
				command.Parameters.Add(TicketCodeParam);
				command.Parameters.Add(MovieIDParam);
				command.Parameters.Add(AmountParam);
				command.Parameters.Add(seatXParam);
				command.Parameters.Add(seatYParam);
				command.Parameters.Add(DateIDParam);
				command.Parameters.Add(HallIDParam);
				command.Parameters.Add(TotalPriceParam);
				command.Parameters.Add(HallParam);

				command.Prepare();
				command.ExecuteNonQuery();
			}
			catch (MySqlException)
			{
				throw;
			}
			finally
			{
				Connection.Close();
			}
		}
	}
}
