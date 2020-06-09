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
        private List<Tuple<Point, Size,Color,bool,double>> AllSeats { get; set; }

        private int Amount { get; set; }

        private int HighestX { get; set; }

        private int HallID { get; set; }

        private int DateID { get; set; }

        private string MovieID { get; set; }

        private int HallNumber { get; set; }

        public ChooseSeats(int hallID, int amount, int dateID, string movieID, int hallNumber)
        {
            InitializeComponent();
            Amount = amount;
            AllSeats = new List<Tuple<Point, Size,Color,bool,double>>();
            DateID = dateID;
            MovieID = movieID;
            HallNumber = hallNumber;
            GetData data = new GetData();
            Tuple<int, int, int, int, double, double, double> part1 = data.GetHallInfo(hallID);
            HighestX = part1.Item2;
            List<Tuple<double, int, int, string, bool>> part2 = data.GetSeat(hallID);
            GetHall(part1, part2);
            DrawHall(AllSeats);
            Console.WriteLine();
        }

        public void GetHall(Tuple<int, int, int, int, double, double, double> HallInfo, List<Tuple<double, int, int, string, bool>> Seats)
        {
            int multiplierX = 0;
            int multiplierY = 0;
            if (HallNumber == 1)
            {
                multiplierX = 75;
                multiplierY = 30;
            }
            else if (HallNumber == 2)
            {
                multiplierX = 50;
                multiplierY = 25;
            }
            else if (HallNumber == 3)
            {
                multiplierX = 35;
                multiplierY = 22;
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

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
                                    Point position = new Point(25 + (j * multiplierX), 25 + (i * multiplierY));
                                    Size dimenision = new Size(multiplierX - 5, multiplierY - 5);
                                    bool avail = Seats[z].Item5;
                                    double price = Seats[z].Item1;
                                    Tuple<Point, Size,Color, bool,double> data = new Tuple<Point, Size,Color,bool,double>(position, dimenision,color,avail,price);
                                    AllSeats.Add(data);
                                }
                                else if (Seats[z].Item1 == HallInfo.Item6)
                                {
                                    Color color = Color.FromArgb(0, 0, 250);
                                    Point position = new Point(25 + (j * multiplierX), 25 + (i * multiplierY));
                                    Size dimenision = new Size(multiplierX - 5, multiplierY - 5);
                                    bool avail = Seats[z].Item5;
                                    double price = Seats[z].Item1;
                                    Tuple<Point, Size, Color, bool, double> data = new Tuple<Point, Size, Color, bool, double>(position, dimenision, color, avail, price);
                                    AllSeats.Add(data);
                                }
                                else if (Seats[z].Item1 == HallInfo.Item7)
                                {
                                    Color color = Color.FromArgb(0, 250, 0);
                                    Point position = new Point(25 + (j * multiplierX), 25 + (i * multiplierY));
                                    Size dimenision = new Size(multiplierX - 5, multiplierY - 5);
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
                                Point position = new Point(25 + (j * multiplierX), 25 + (i * multiplierY));
                                Size dimenision = new Size(multiplierX - 5, multiplierY - 5);
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
                    for (int k = 0; k < data.Count; k++)
                    {
                        if (label.Location.Y == data[k].Item1.Y && label.Location.X <= data[k].Item1.X && label.Location.X + ((Amount - 1) *100) >= data[k].Item1.X)
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
                        PersonInfo destination = new PersonInfo(label.Location,Amount,HallID,totalprice,MovieID,DateID);
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
            Color color = Color.FromArgb(0, 0, 0);
            Label screen = new Label();
            screen.Name = "screen";
            screen.BorderStyle = BorderStyle.FixedSingle;
            screen.Size = new Size(1180,25);
            screen.Location = new Point(25,475);
            screen.BackColor = color;
            screen.AutoSize = false;
            this.Controls.Add(screen);
        }
    }
}
