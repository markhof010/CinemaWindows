using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using CinemaWindows.Database;


namespace CinemaWindows
{
	public partial class MovieInfo : Form
	{
		public MovieInfo()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MovieInfo
			// 
			this.ClientSize = new System.Drawing.Size(1446, 655);
			this.Name = "MovieInfo";
			this.ResumeLayout(false);

		}

		
	}
}
