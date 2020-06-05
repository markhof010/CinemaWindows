﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaWindows.Database;

namespace CinemaWindows
{
	public partial class HomeScreen : Form
	{
		public HomeScreen()
		{
			GetData GD = new GetData();
			InitializeComponent();
		}

		private void loginButon_Click(object sender, EventArgs e)
		{
			Hide();
			InlogPage form = new InlogPage();
			form.ShowDialog();
			Close();
		}

		private void PersonInfoButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			PersonInfo personInfoform = new PersonInfo();
			personInfoform.ShowDialog();
			this.Close();
		}

		private void MenuBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			RestaurantMenu form = new RestaurantMenu();
			form.ShowDialog();
			this.Close();
		}

		private void ContactBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			Contact form = new Contact();
			form.ShowDialog();
			this.Close();
		}

		private void TicketCodeBTN_Click(object sender, EventArgs e)
		{
			this.Hide();
			TicketCode form = new TicketCode();
			form.ShowDialog();
			this.Close();
		}
	}
}
