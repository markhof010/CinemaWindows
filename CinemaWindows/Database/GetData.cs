﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;

namespace CinemaWindows.Database
{
    class GetData : Connecter
    {
        /// <summary>
        /// Gets all the seats from 1 specific hall
        /// </summary>
        /// <param name="HallID">The hall you want to search all the seats for</param>
        /// <returns>A list of seats with availability, prices and place</returns>
        public List<Tuple<double, int, int, string, bool>> GetSeat(int HallID)
        {
            List<Tuple<double, int, int, string, bool>> seat = new List<Tuple<double, int, int, string, bool>>();
            try
            {
                Connection.Open();
                string IntToCheck = @"SELECT * FROM seats WHERE HallID = @HallID";

                MySqlCommand command = new MySqlCommand(IntToCheck, Connection);
                MySqlParameter HallIDParam = new MySqlParameter("@HallID", MySqlDbType.Int32);

                HallIDParam.Value = HallID;

                command.Parameters.Add(HallIDParam);


                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    double price = dataReader.GetDouble("price");
                    int Y = dataReader.GetInt32("RowSeat");
                    int X = dataReader.GetInt32("ColumnSeat");
                    string Name = dataReader.GetString("Name");
                    bool avail = false;
                    if (dataReader.GetInt32("Availability") == 1)
                    {
                        avail = true;
                    }

                    seat.Add(Tuple.Create(price, Y, X, Name, avail));
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
            return seat;
        }

        /// <summary>
        /// Gets all the info about a specific hall
        /// </summary>
        /// <param name="HallID">The hall you want to search all the info about</param>
        /// <returns>A Tuple with all the seats and prices</returns>
        public Tuple<int, int, int, int, double, double, double> GetHallInfo(int HallID)
        {
            int row = 0;
            int col = 0;
            int dateID = 0;
            double inner = 0;
            double middle = 0;
            double outer = 0;

            try
            {
                Connection.Open();
                string IntToCheck = @"SELECT * FROM hall WHERE HallID = @HallID";

                MySqlCommand command = new MySqlCommand(IntToCheck, Connection);
                MySqlParameter HallIDParam = new MySqlParameter("@HallID", MySqlDbType.Int32);

                HallIDParam.Value = HallID;

                command.Parameters.Add(HallIDParam);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    row = dataReader.GetInt32("RowLength");
                    col = dataReader.GetInt32("ColLength");
                    dateID = dataReader.GetInt32("DateID");
                    inner = dataReader.GetDouble("InnerCircle");
                    middle = dataReader.GetDouble("MiddleCircle");
                    outer = dataReader.GetDouble("OuterCircle");
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

            return Tuple.Create(row, col, dateID, HallID, inner, middle, outer);
        }
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

        public Tuple<List<DateTime>, List<int>, List<int>> GetTime(int MovieID)
        {
            List<DateTime> dt = new List<DateTime>();
            List<int> dateID = new List<int>();
            List<int> Hall = new List<int>();
            try
            {
                Connection.Open();
                string IntToCheck = @"SELECT DateTime, DateID, Hall FROM date WHERE MovieID = @MovieID";

                MySqlCommand command = new MySqlCommand(IntToCheck, Connection);
                MySqlParameter MovieIDParam = new MySqlParameter("@MovieID", MySqlDbType.Int32);

                MovieIDParam.Value = MovieID;

                command.Parameters.Add(MovieIDParam);

                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    dt.Add(dataReader.GetDateTime("DateTime"));
                    dateID.Add(dataReader.GetInt32("DateID"));
                    Hall.Add(dataReader.GetInt32("Hall"));
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
            return Tuple.Create(dt, dateID, Hall);
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

        public Tuple<List<int>, List<int>> GetDateHallIDs(int MovieID)
        {
            List<int> DateIDs = new List<int>();
            List<int> HallIDs = new List<int>();
            try
            {
                Connection.Open();

                string SelectDate = @"SELECT DateID FROM date WHERE MovieID = @MovieID";

                MySqlCommand commandDate = new MySqlCommand(SelectDate, Connection);
                MySqlParameter MovieIDParam = new MySqlParameter("@MovieID", MySqlDbType.Int32);

                MovieIDParam.Value = MovieID;

                commandDate.Parameters.Add(MovieIDParam);

                MySqlDataReader dataReader = commandDate.ExecuteReader();

                while (dataReader.Read())
                {
                    DateIDs.Add(dataReader.GetInt32("DateID"));
                }
                dataReader.Close();

                for (int i = 0; i < DateIDs.Count; i++)
                {
                    string SelectHall = @"SELECT HallID FROM hall WHERE DateID = @dateID";

                    MySqlCommand commandHall = new MySqlCommand(SelectHall, Connection);
                    MySqlParameter DateIDParam = new MySqlParameter("@dateID", MySqlDbType.Int32);

                    DateIDParam.Value = DateIDs[i];

                    commandHall.Parameters.Add(DateIDParam);

                    MySqlDataReader dataReader2 = commandHall.ExecuteReader();

                    while (dataReader2.Read())
                    {
                        HallIDs.Add(dataReader2.GetInt32("HallID"));
                    }
                    dataReader2.Close();
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
            return Tuple.Create(DateIDs, HallIDs);
        }

        public DateTime GetDate(int DateID)
        {
            try
            {
                Connection.Open();
                string DateInfo = @"SELECT * FROM date";

                MySqlCommand oCmd = new MySqlCommand(DateInfo, Connection);

                MySqlDataReader getDateInfo = oCmd.ExecuteReader();
                DataTable dataTable = new DataTable();

                dataTable.Load(getDateInfo);
                DateTime date = new DateTime();
                while (true)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int dateindb = Convert.ToInt32(row["DateID"]);

                        string datetime = Convert.ToDateTime(row["DateTime"]).ToString("dd/MM/yyyy HH:mm");

                        if (DateID == dateindb)
                        {
                            date = Convert.ToDateTime(row["DateTime"]);
                            break;
                        }
                    }
                    return date;
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
    }
}
