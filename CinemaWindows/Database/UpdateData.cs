using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWindows.Database
{
	class UpdateData : Connecter
	{
        public void switchAvail(int SeatX, int SeatY, int HallID, int Amount, bool Avail)
        {
            try
            {
                int count = 0;
                Connection.Open();
                while (true)
                {
                    string stringToUpdate = @"UPDATE seats SET Availability = @Availability WHERE RowSeat = @seatY AND ColumnSeat = @seatX AND HallID = @HallID";

                    MySqlCommand command = new MySqlCommand(stringToUpdate, Connection);

                    MySqlParameter availparam = new MySqlParameter("@Availability", MySqlDbType.Bit);
                    MySqlParameter Yparam = new MySqlParameter("@seatY", MySqlDbType.Int32);
                    MySqlParameter Xparam = new MySqlParameter("@seatX", MySqlDbType.Int32);
                    MySqlParameter IDparam = new MySqlParameter("@HallID", MySqlDbType.Int32);

                    if (Avail)
                    {
                        availparam.Value = 1;
                    }
                    else
                    {
                        availparam.Value = 0;
                    }

                    Yparam.Value = SeatY;
                    Xparam.Value = (SeatX + count);
                    IDparam.Value = HallID;

                    command.Parameters.Add(availparam);
                    command.Parameters.Add(Yparam);
                    command.Parameters.Add(Xparam);
                    command.Parameters.Add(IDparam);

                    command.Prepare();
                    command.ExecuteNonQuery();

                    count++;
                    if (count >= Amount)
                    {
                        break;
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
        }
    }
}
