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
                    //Console.WriteLine("(" + dataReader["ItemID"] + ") " + dataReader["ItemName"] + "    €" + test.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));
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
    }
}
