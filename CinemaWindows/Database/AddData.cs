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



	}
}
