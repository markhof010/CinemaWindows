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

        public List<Tuple<string, string, string, string, string>> ShowMovies()
        {
            List<Tuple<string, string, string, string, string>> movielist = new List<Tuple<string, string, string, string, string>>();
            try
            {
                List<int> MovieIDs = new List<int>();
                Connection.Open();
                string oString = @"SELECT * from movie";
                MySqlCommand command = new MySqlCommand(oString, Connection);

                // creating the strings 
                string movieID;
                string movieName;
                string movieDuration;
                string movieGenre;
                string movieAge;

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    movieID = dataReader["MovieID"].ToString();
                    movieName = dataReader["MovieName"].ToString();
                    movieDuration = dataReader["MovieDuration"].ToString();
                    movieGenre = dataReader["MovieGenre"].ToString();
                    movieAge = dataReader["MovieMinimumAge"].ToString();

                    movielist.Add(Tuple.Create(movieID, movieName, movieDuration, movieGenre, movieAge));
                }
                dataReader.Close();
                return movielist;
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

    }
}
