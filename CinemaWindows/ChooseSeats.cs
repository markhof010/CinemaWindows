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

namespace CinemaWindows
{
    public partial class ChooseSeats : Form
    {
        public ChooseSeats()
        {
            InitializeComponent();
            Bitmap Hall = new Bitmap(1240, 650);
            Draw(Hall);
            HallPictureBox.Image = Hall;
        }

        public void drawBackground(Bitmap map)
        {
            using (Graphics g = Graphics.FromImage(map))
            {
                Color customColor = Color.FromArgb(50, 50, 50);
                g.FillRectangle(new SolidBrush(customColor),0,0,1240,650);
                Console.WriteLine(g.PageScale);
            }
        }

        public void drawSeats(Bitmap map,int hallheigth, int hallwidth)
        {
            using (Graphics g = Graphics.FromImage(map))
            {
                for (int y = 0; y < hallheigth; y++)
                {
                    for (int x = 0; x < hallwidth; x++)
                    {
                        Color colorblue = Color.FromArgb(0, 0, 250);
                        Rectangle rect = new Rectangle(25 + (x * 100), 25 + (y * 40), 95, 35);
                        g.FillRectangle(new SolidBrush(colorblue),rect);
                    }
                }
            }
        }

        private void Draw(Bitmap map)
        {
            drawBackground(map);
            drawSeats(map,14,12);
        }

        public static void showHall(Tuple<int, int, int, int, double, double, double> HallInfo, List<Tuple<double, int, int, string, bool>> Seats)
        {
            Bitmap image = new Bitmap(1250, 650);
            

            string XasNumbers = "\n";

            for (int i = 0; i < HallInfo.Item2; i++)
            {
                if (i > 8)
                {
                    XasNumbers += (i + 1) + " ";
                }
                else if (i == 8)
                {
                    XasNumbers += (i + 1) + "  ";
                }
                else
                {
                    XasNumbers += (i + 1) + "  ";
                }
            }
            XasNumbers += "\n";
            Console.WriteLine(XasNumbers);

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
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                else if (Seats[z].Item1 == HallInfo.Item6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                }
                                else if (Seats[z].Item1 == HallInfo.Item7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }

                                if (j > 8)
                                {
                                    Console.Write(" O ");
                                }
                                else if (j == 8)
                                {
                                    Console.Write("O ");
                                }
                                else
                                {
                                    Console.Write("O  ");
                                }
                                Console.ResetColor();
                            }
                            else if (Seats[z].Item4 == "(No Seat)")
                            {
                                if (j > 8)
                                {
                                    Console.Write("   ");
                                }
                                else if (j == 8)
                                {
                                    Console.Write("  ");
                                }
                                else
                                {
                                    Console.Write("   ");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (j > 8)
                                {
                                    Console.Write(" X ");
                                }
                                else if (j == 8)
                                {
                                    Console.Write("X ");
                                }
                                else
                                {
                                    Console.Write("X  ");
                                }
                                Console.ResetColor();
                            }
                            break;
                        }
                    }
                }
                Console.Write("  " + (HallInfo.Item1 - i));
                Console.Write("\n");
            }

            string screen = "";
            screen += "\n";
            for (int i = 0; i < HallInfo.Item2; i++)
            {
                screen += "---";
            }

            screen += "       (screen)\n";
            Console.WriteLine(screen);
        }

    }
}
