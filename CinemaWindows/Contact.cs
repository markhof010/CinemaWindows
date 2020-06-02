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
	public partial class Contact : Form
	{
		public Contact()
		{
			InitializeComponent();
			Label LB1 = new Label();
			LB1.Text = "Adres:";
			LB1.Location = new Point((this.Width/2) - 177, 120);
			LB1.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB1.AutoSize = true;

			Label LB2 = new Label();
			LB2.Text = "Wijnhaven 99, 3011 WN Rotterdam";
			LB2.Location = new Point((this.Width / 2) - 177, 140);
			LB2.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB2.AutoSize = true;

			Label LB3 = new Label();
			LB3.Text = "Phone number:";
			LB3.Location = new Point((this.Width / 2) - 177, 180);
			LB3.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB3.AutoSize = true;

			Label LB4 = new Label();
			LB4.Text = "010-794 4000";
			LB4.Location = new Point((this.Width / 2) - 177, 200);
			LB4.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB4.AutoSize = true;

			Label LB5 = new Label();
			LB5.Text = "Opening hours:";
			LB5.Location = new Point((this.Width / 2) - 177, 240);
			LB5.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB5.AutoSize = true;

			Label LB6 = new Label();
			LB6.Text = "Monday - Thursday: 09:00 - 21:00";
			LB6.Location = new Point((this.Width / 2) - 177, 260);
			LB6.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB6.AutoSize = true;

			Label LB7 = new Label();
			LB7.Text = "Friday: 09:00 - 01:00";
			LB7.Location = new Point((this.Width / 2) - 177, 280);
			LB7.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB7.AutoSize = true;

			Label LB8 = new Label();
			LB8.Text = "Saturday - Sunday: 12:00 - 02:00 ";
			LB8.Location = new Point((this.Width / 2) - 177, 300);
			LB8.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			LB8.AutoSize = true;

			this.Controls.Add(LB1);
			this.Controls.Add(LB2);
			this.Controls.Add(LB3);
			this.Controls.Add(LB4);
			this.Controls.Add(LB5);
			this.Controls.Add(LB6);
			this.Controls.Add(LB7);
			this.Controls.Add(LB8);
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
