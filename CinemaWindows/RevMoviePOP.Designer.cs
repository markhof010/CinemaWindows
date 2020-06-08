namespace CinemaWindows
{
	partial class RevMoviePOP
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.QuestionLBL = new System.Windows.Forms.Label();
			this.MovieBTN = new System.Windows.Forms.Button();
			this.TimeBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// QuestionLBL
			// 
			this.QuestionLBL.AutoSize = true;
			this.QuestionLBL.Location = new System.Drawing.Point(179, 50);
			this.QuestionLBL.Name = "QuestionLBL";
			this.QuestionLBL.Size = new System.Drawing.Size(150, 13);
			this.QuestionLBL.TabIndex = 0;
			this.QuestionLBL.Text = "What do you want to remove?";
			// 
			// MovieBTN
			// 
			this.MovieBTN.Location = new System.Drawing.Point(120, 103);
			this.MovieBTN.Name = "MovieBTN";
			this.MovieBTN.Size = new System.Drawing.Size(75, 23);
			this.MovieBTN.TabIndex = 1;
			this.MovieBTN.Text = "Entire Movie";
			this.MovieBTN.UseVisualStyleBackColor = true;
			this.MovieBTN.Click += new System.EventHandler(this.MovieBTN_Click);
			// 
			// TimeBTN
			// 
			this.TimeBTN.Location = new System.Drawing.Point(302, 103);
			this.TimeBTN.Name = "TimeBTN";
			this.TimeBTN.Size = new System.Drawing.Size(75, 23);
			this.TimeBTN.TabIndex = 2;
			this.TimeBTN.Text = "Certain Time";
			this.TimeBTN.UseVisualStyleBackColor = true;
			this.TimeBTN.Click += new System.EventHandler(this.TimeBTN_Click);
			// 
			// RevMoviePOP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 200);
			this.Controls.Add(this.TimeBTN);
			this.Controls.Add(this.MovieBTN);
			this.Controls.Add(this.QuestionLBL);
			this.Name = "RevMoviePOP";
			this.Text = "Remove Options for ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label QuestionLBL;
		private System.Windows.Forms.Button MovieBTN;
		private System.Windows.Forms.Button TimeBTN;
	}
}