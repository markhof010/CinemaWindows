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
        public List<Tuple<Point, Size,Color,bool,double>> AllSeats { get; set; }

        public Bitmap Hall { get; set; }

        public int Amount { get; set; }

        public int HighestX { get; set; }

        public int HallNumber { get; set; }

        public ChooseSeats(int hallNumber, int amount)
        {
            InitializeComponent();
            Amount = amount;
            AllSeats = new List<Tuple<Point, Size,Color,bool,double>>();
            GetData data = new GetData();
            Tuple<int, int, int, int, double, double, double> part1 = data.GetHallInfo(hallNumber);
            HighestX = part1.Item2;
            List<Tuple<double, int, int, string, bool>> part2 = data.GetSeat(hallNumber);
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
                                    bool avail = Seats[z].Item5;
                                    double price = Seats[z].Item1;
                                    Tuple<Point, Size,Color, bool,double> data = new Tuple<Point, Size,Color,bool,double>(position, dimenision,color,avail,price);
                                    AllSeats.Add(data);
                                }
                                else if (Seats[z].Item1 == HallInfo.Item6)
                                {
                                    Color color = Color.FromArgb(0, 0, 250);
                                    Point position = new Point(25 + (j * 100), 25 + (i * 40));
                                    Size dimenision = new Size(95, 35);
                                    bool avail = Seats[z].Item5;
                                    double price = Seats[z].Item1;
                                    Tuple<Point, Size, Color, bool, double> data = new Tuple<Point, Size, Color, bool, double>(position, dimenision, color, avail, price);
                                    AllSeats.Add(data);
                                }
                                else if (Seats[z].Item1 == HallInfo.Item7)
                                {
                                    Color color = Color.FromArgb(0, 250, 0);
                                    Point position = new Point(25 + (j * 100), 25 + (i * 40));
                                    Size dimenision = new Size(95, 35);
                                    bool avail = Seats[z].Item5;
                                    double price = Seats[z].Item1;
                                    Tuple<Point, Size, Color, bool, double> data = new Tuple<Point, Size, Color, bool, double>(position, dimenision, color, avail, price);
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
                                bool avail = Seats[z].Item5;
                                double price = Seats[z].Item1;
                                Tuple<Point, Size, Color, bool, double> data = new Tuple<Point, Size, Color, bool, double>(position, dimenision, color, avail, price);
                                AllSeats.Add(data);
                            }
                            break;
                        }
                    }
                }
            }
        
        }

        public void DrawHall(List<Tuple<Point, Size, Color,bool,double>> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                Label label = new Label();
                label.Name = data[i].Item1.X + "/" + data[i].Item1.Y;
                label.BorderStyle = BorderStyle.FixedSingle;
                label.Size = data[i].Item2;
                label.Location = data[i].Item1;
                label.BackColor = data[i].Item3;
                label.AutoSize = false;
                bool avail = data[i].Item4;
                int index = i;
                label.Click += (s, p) => {
                    bool canreserve = false;
                    double totalprice = 0.0;
                    Color color = Color.FromArgb(250, 0, 0);
                    for (int k = 0; k < data.Count; k++)
                    {
                        if (label.Location.Y == data[k].Item1.Y && label.Location.X <= data[k].Item1.X && label.Location.X + Amount >= data[k].Item1.X)
                        {
                            if (data[k].Item4)
                            {
                                canreserve = true;
                                totalprice += data[k].Item5;
                            }
                            else
                            {
                                canreserve = false;
                                break;
                            }
                        }
                    }
                    if (canreserve)
                    {
                        this.Hide();
                        PersonInfo destination = new PersonInfo(label.Location,Amount,HallNumber,totalprice);
                        destination.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                };

                this.Controls.Add(label);
            }
        }
    }
}
