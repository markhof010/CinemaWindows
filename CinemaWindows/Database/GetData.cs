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

        public bool Get1Seat(int HallID, int x, int y)
        {
            bool available = false;

            try
            {
                Connection.Open();
                string BoolToCheck = "SELECT Availability FROM seats where HallID = @HallID AND RowSeat = @Y AND ColumnSeat = @X";

                MySqlCommand command = new MySqlCommand(BoolToCheck, Connection);
                MySqlParameter HallIDParam = new MySqlParameter("@HallID", MySqlDbType.Int32);
                MySqlParameter XParam = new MySqlParameter("@X", MySqlDbType.Int32);
                MySqlParameter YParam = new MySqlParameter("@Y", MySqlDbType.Int32);


            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                Connection.Close();
            }

            return available;
        }
    }
}
