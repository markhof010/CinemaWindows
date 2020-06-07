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
    class GetData : Connecter
    {
        public int GetHallID(int DateID)
        {
            int HallID = -1;
            try
            {
                Connection.Open();
                string IntToCheck = @"SELECT HallID FROM hall WHERE DateID = @DateID";

                MySqlCommand command = new MySqlCommand(IntToCheck, Connection);
                MySqlParameter DateIDParam = new MySqlParameter("@DateID", MySqlDbType.VarChar);

                DateIDParam.Value = DateID;

                command.Parameters.Add(DateIDParam);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    HallID = dataReader.GetInt32("HallID");
                }
                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return HallID;
        }

        public List<Tuple<int, string, double>> GetProducts()
        {
            List<Tuple<int, string, double>> products = new List<Tuple<int, string, double>>();

			try
			{
				Connection.Open();
				string stringToDisplay = @"SELECT * FROM restaurantitems";

                MySqlCommand command = new MySqlCommand(stringToDisplay, Connection);

                MySqlDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
                    int ItemID = dataReader.GetInt32("ItemID");
                    string ItemName = dataReader["ItemName"].ToString();
					double ItemPrice = dataReader.GetDouble("Price");

                    products.Add(Tuple.Create(ItemID, ItemName, ItemPrice));
                }

                dataReader.Close();
                return products;
			}
			catch (MySqlException ex)
			{

				throw;
			}
			finally
			{
				Connection.Close();
			}
        }

        public int GetMovieID(string Title)
        {
            int movieID = -1;
            try
            {
                Connection.Open();
                string IntToCheck = @"SELECT MovieID FROM movie WHERE MovieName = @MovieName";

                MySqlCommand command = new MySqlCommand(IntToCheck, Connection);
                MySqlParameter MovieNameParam = new MySqlParameter("@MovieName", MySqlDbType.VarChar);

                MovieNameParam.Value = Title;

                command.Parameters.Add(MovieNameParam);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    movieID = dataReader.GetInt32("MovieID");
                }
                dataReader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }
            return movieID;
        }

        public Tuple<List<DateTime>, List<int>, List<DateTime>> GetAllDates()
        {
            List<DateTime> StartTime = new List<DateTime>();
            List<int> Hall = new List<int>();
            List<DateTime> Endtime = new List<DateTime>();
            try
            {
                Connection.Open();
                string IntToCheck = @"SELECT date.DateTime, date.hall, movie.MovieDuration FROM Cinema.date LEFT JOIN Cinema.movie ON date.MovieID = movie.MovieID";

                MySqlCommand command = new MySqlCommand(IntToCheck, Connection);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    StartTime.Add(dataReader.GetDateTime("DateTime"));
                    Hall.Add(dataReader.GetInt32("Hall"));
                    Endtime.Add(dataReader.GetDateTime("DateTime").AddMinutes(dataReader.GetInt32("MovieDuration")));
                }
                dataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return Tuple.Create(StartTime, Hall, Endtime);
        }
    }
}
