using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWindows.Database
{
	class DelData : Connecter
	{
        public void DeleteMovie(int MovieID)
        {
            GetData GD = new GetData();
            Tuple<List<int>, List<int>> dateHallIDs = GD.GetDateHallIDs(MovieID);

            try
            {
                Connection.Open();
                string DeleteMovie = @"DELETE FROM movie WHERE MovieID = @ID";

                MySqlParameter movieIDParam = new MySqlParameter("@ID", MySqlDbType.Int32);
                movieIDParam.Value = MovieID;

                //Delete movie with movieID
                MySqlCommand commandMovie = new MySqlCommand(DeleteMovie, Connection);

                commandMovie.Parameters.Add(movieIDParam);

                commandMovie.Prepare();
                commandMovie.ExecuteNonQuery();

                //Delete dates with movieID
                string DeleteDate = @"DELETE FROM date WHERE MovieID = @ID";
                MySqlCommand commandDate = new MySqlCommand(DeleteDate, Connection);

                commandDate.Parameters.Add(movieIDParam);

                commandDate.Prepare();
                commandDate.ExecuteNonQuery();

                for (int i = 0; i < dateHallIDs.Item1.Count; i++)
                {


                    MySqlParameter dateIDParam = new MySqlParameter("@ID", MySqlDbType.Int32);
                    dateIDParam.Value = dateHallIDs.Item1[i];

                    //Delete halls with dateIDs
                    string DeleteHall = @"DELETE FROM hall WHERE DateID = @ID";
                    MySqlCommand commandhall = new MySqlCommand(DeleteHall, Connection);

                    commandhall.Parameters.Add(dateIDParam);

                    commandhall.Prepare();
                    commandhall.ExecuteNonQuery();

                    //Delete tickets with dateIDs
                    string DeleteTicket = @"DELETE FROM ticket WHERE DateID = @ID";
                    MySqlCommand commandTicket = new MySqlCommand(DeleteTicket, Connection);

                    commandTicket.Parameters.Add(dateIDParam);

                    commandTicket.Prepare();
                    commandTicket.ExecuteNonQuery();
                }

                for (int i = 0; i < dateHallIDs.Item2.Count; i++)
                {
                    MySqlParameter hallIDParam = new MySqlParameter("@ID", MySqlDbType.Int32);
                    hallIDParam.Value = dateHallIDs.Item2[i];

                    string DeleteSeat = @"DELETE FROM seats WHERE HallID = @ID";
                    MySqlCommand commandSeat = new MySqlCommand(DeleteSeat, Connection);

                    commandSeat.Parameters.Add(hallIDParam);

                    commandSeat.Prepare();
                    commandSeat.ExecuteNonQuery();
                }
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

        public void DeleteTime(int DateID)
        {
            GetData GD = new GetData();
            int hallID = GD.GetHallID(DateID);

            try
            {
                Connection.Open();

                MySqlParameter dateIDParam = new MySqlParameter("@ID", MySqlDbType.Int32);
                dateIDParam.Value = DateID;

                //Delete date with DateID
                string DeleteDate = @"DELETE FROM date WHERE DateID = @ID";
                MySqlCommand commandDate = new MySqlCommand(DeleteDate, Connection);

                commandDate.Parameters.Add(dateIDParam);

                commandDate.Prepare();
                commandDate.ExecuteNonQuery();

                //Delete hall with DateID
                string DeleteHall = @"DELETE FROM hall WHERE DateID = @ID";
                MySqlCommand commandhall = new MySqlCommand(DeleteHall, Connection);

                commandhall.Parameters.Add(dateIDParam);

                commandhall.Prepare();
                commandhall.ExecuteNonQuery();

                //Delete tickets with dateID
                string DeleteTicket = @"DELETE FROM ticket WHERE DateID = @ID";
                MySqlCommand commandTicket = new MySqlCommand(DeleteTicket, Connection);

                commandTicket.Parameters.Add(dateIDParam);

                commandTicket.Prepare();
                commandTicket.ExecuteNonQuery();

                //Delete seats met hallID
                string DeleteSeat = @"DELETE FROM seats WHERE HallID = @ID";

                MySqlCommand commandSeat = new MySqlCommand(DeleteSeat, Connection);
                MySqlParameter hallIDParam = new MySqlParameter("@ID", MySqlDbType.Int32);

                hallIDParam.Value = hallID;

                commandSeat.Parameters.Add(hallIDParam);

                commandSeat.Prepare();
                commandSeat.ExecuteNonQuery();
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
