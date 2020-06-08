using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using CinemaWindows.Database;
using System.Windows.Input;

namespace CinemaWindows
{
    public partial class ChooseSeats : Form
    {
        public List<Tuple<Point, Size,Color>> AllSeats { get; set; }

        public Bitmap Hall { get; set; }

        public ChooseSeats()
        {
            InitializeComponent();
            AllSeats = new List<Tuple<Point, Size,Color>>();
            GetData data = new GetData();
            Tuple<int, int, int, int, double, double, double> part1 = data.GetHallInfo(1);
            List<Tuple<double, int, int, string, bool>> part2 = data.GetSeat(1);
            GetHall(part1, part2, Hall);
            DrawHall(AllSeats);
        }

        public void GetHall(Tuple<int, int, int, int, double, double, double> HallInfo, List<Tuple<double, int, int, string, bool>> Seats, Bitmap map)
        {
                for (int i = 0; i < HallInfo.Item1; i++)
                {
                    for (int j = 0; j < HallInfo.Item2; j++)
                    {
                        for (int z = 0; z < Seats.Count; z++)
                        {
                            if (Seats[z].Item2 == i && Seats[z].Item3 == j)
                            {
                                if (Seats[z].Item5)
                                {
                                    if (Seats[z].Item1 == HallInfo.Item5)
                                    {
                                        Color color = Color.FromArgb(250, 250, 0);
                                        Point position = new Point(25 + (j * 100), 25 + (i * 40));
                                        Size dimenision = new Size(95, 35);
                                        Tuple<Point, Size,Color> data = new Tuple<Point, Size,Color>(position, dimenision,color);
                                        AllSeats.Add(data);
                                    }
                                    else if (Seats[z].Item1 == HallInfo.Item6)
                                    {
                                        Color color = Color.FromArgb(0, 0, 250);
                                        Point position = new Point(25 + (j * 100), 25 + (i * 40));
                                        Size dimenision = new Size(95, 35);
                                        Tuple<Point, Size,Color> data = new Tuple<Point, Size,Color>(position, dimenision,color);
                                        AllSeats.Add(data);
                                    }
                                    else if (Seats[z].Item1 == HallInfo.Item7)
                                    {
                                        Color color = Color.FromArgb(0, 250, 0);
                                        Point position = new Point(25 + (j * 100), 25 + (i * 40));
                                        Size dimenision = new Size(95, 35);
                                        Tuple<Point, Size,Color> data = new Tuple<Point, Size,Color>(position, dimenision,color);
                                        AllSeats.Add(data);
                                    }
                                }
                                else if (Seats[z].Item4 == "(No Seat)")
                                {
                                    //idk
                                }
                                else
                                {
                                    Color color = Color.FromArgb(250, 0, 0);
                                    Point position = new Point(25 + (j * 100), 25 + (i * 40));
                                    Size dimenision = new Size(95, 35);
                                    Tuple<Point, Size, Color> data = new Tuple<Point, Size, Color>(position, dimenision, color);
                                    AllSeats.Add(data);
                                }
                                break;
                            }
                        }
                    }
                }
            
        }

        public void DrawHall(List<Tuple<Point, Size, Color>> data)
        {
            foreach (var item in data)
            {
                Label label = new Label();
                label.Name = item.Item1.X + "/" + item.Item1.Y;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Size = item.Item2;
                label.Location = item.Item1;
                label.BackColor = item.Item3;
                label.AutoSize = false;

                label.Click += (s, p) => {
                    Color color = Color.FromArgb(250, 0, 0);
                    if (!label.BackColor.Equals(color))
                    {
                        //Add the new window with:
                        //Name
                        //SeatAmount
                    }
                };

                this.Controls.Add(label);
            }
        }
    }
}
