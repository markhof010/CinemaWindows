using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaWindows
{
	public partial class RestaurantMenu : Form
	{
		public RestaurantMenu()
		{
			InitializeComponent();
			this.AutoScroll = true;
			int place = 120;

			try
			{
				Connection.Open();
				string stringToDisplay = @"SELECT * FROM restaurantitems";

				MySqlCommand command = new MySqlCommand(stringToDisplay, Connection);

				MySqlDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
					double test = dataReader.GetDouble("Price");
					
					Label LB1 = new Label();
					LB1.Text = "(" + dataReader["ItemID"] + ") " + dataReader["ItemName"] + "    €" + test.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
					LB1.Location = new Point((this.Width / 2) - 177, place);
					LB1.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					LB1.AutoSize = true;
					this.Controls.Add(LB1);

					place += 20;
					//Console.WriteLine("(" + dataReader["ItemID"] + ") " + dataReader["ItemName"] + "    €" + test.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));
				}

				dataReader.Close();
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

		private void HomeBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			HomeScreen form = new HomeScreen();
			form.ShowDialog();
			this.Close();
		}
	}
}
