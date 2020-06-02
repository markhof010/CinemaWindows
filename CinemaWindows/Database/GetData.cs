using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;

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

        /// <param name="movieID">given movie id</param>
        public Tuple<string, string, string, string, string, string> ShowMovieByID(string movieID)
        {
            try
            {
                Connection.Open();
                string oString = @"SELECT * from movie WHERE MovieID = @id";
                MySqlCommand oCmd = new MySqlCommand(oString, Connection);
                oCmd.Parameters.AddWithValue("@id", movieID);

                using (MySqlDataReader getMovieInfo = oCmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();

                    dataTable.Load(getMovieInfo);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        /*Console.Clear();
                        Console.WriteLine("\nMovie selected: " + row["MovieName"].ToString());
                        Console.WriteLine("Year: " + row["MovieYear"].ToString());
                        Console.WriteLine("Age restriction: " + row["MovieMinimumAge"].ToString() + "+");
                        Console.WriteLine("Actors: " + row["MovieActors"].ToString());
                        Console.WriteLine("Summary: " + row["MovieSummary"].ToString());
                        */

                        // show the times with the id of the movie
                        return Tuple.Create(row["MovieID"].ToString(), row["MovieName"].ToString(), row["MovieMinimumAge"].ToString(), row["MovieYear"].ToString(), row["MovieActors"].ToString(), row["MovieSummary"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return Tuple.Create("", "", "", "", "", "");
        }
    }
}
