namespace CinemaWindows
{
	partial class AddTime
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
			this.AddTimeBTN = new System.Windows.Forms.Button();
			this.DoneBTN = new System.Windows.Forms.Button();
			this.HomeBTN = new System.Windows.Forms.Button();
			this.HallLB = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.NumHall = new System.Windows.Forms.NumericUpDown();
			this.TimeLB = new System.Windows.Forms.Label();
			this.DateLB = new System.Windows.Forms.Label();
			this.DTP = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.NumHall)).BeginInit();
			this.SuspendLayout();
			// 
			// AddTimeBTN
			// 
			this.AddTimeBTN.Enabled = false;
			this.AddTimeBTN.Location = new System.Drawing.Point(471, 715);
			this.AddTimeBTN.Name = "AddTimeBTN";
			this.AddTimeBTN.Size = new System.Drawing.Size(169, 35);
			this.AddTimeBTN.TabIndex = 0;
			this.AddTimeBTN.Text = "Add another time";
			this.AddTimeBTN.UseVisualStyleBackColor = true;
			this.AddTimeBTN.Click += new System.EventHandler(this.AddTimeBTN_Click);
			// 
			// DoneBTN
			// 
			this.DoneBTN.Enabled = false;
			this.DoneBTN.Location = new System.Drawing.Point(783, 715);
			this.DoneBTN.Name = "DoneBTN";
			this.DoneBTN.Size = new System.Drawing.Size(112, 35);
			this.DoneBTN.TabIndex = 1;
			this.DoneBTN.Text = "Done";
			this.DoneBTN.UseVisualStyleBackColor = true;
			this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
			// 
			// HomeBTN
			// 
			this.HomeBTN.Location = new System.Drawing.Point(1271, 12);
			this.HomeBTN.Name = "HomeBTN";
			this.HomeBTN.Size = new System.Drawing.Size(112, 35);
			this.HomeBTN.TabIndex = 2;
			this.HomeBTN.Text = "Logout";
			this.HomeBTN.UseVisualStyleBackColor = true;
			this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
			// 
			// HallLB
			// 
			this.HallLB.AutoSize = true;
			this.HallLB.Location = new System.Drawing.Point(624, 178);
			this.HallLB.Name = "HallLB";
			this.HallLB.Size = new System.Drawing.Size(36, 20);
			this.HallLB.TabIndex = 3;
			this.HallLB.Text = "Hall";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(628, 277);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 26);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// NumHall
			// 
			this.NumHall.Location = new System.Drawing.Point(628, 201);
			this.NumHall.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.NumHall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumHall.Name = "NumHall";
			this.NumHall.Size = new System.Drawing.Size(88, 26);
			this.NumHall.TabIndex = 5;
			this.NumHall.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// TimeLB
			// 
			this.TimeLB.AutoSize = true;
			this.TimeLB.Location = new System.Drawing.Point(624, 254);
			this.TimeLB.Name = "TimeLB";
			this.TimeLB.Size = new System.Drawing.Size(43, 20);
			this.TimeLB.TabIndex = 7;
			this.TimeLB.Text = "Time";
			// 
			// DateLB
			// 
			this.DateLB.AutoSize = true;
			this.DateLB.Location = new System.Drawing.Point(624, 332);
			this.DateLB.Name = "DateLB";
			this.DateLB.Size = new System.Drawing.Size(44, 20);
			this.DateLB.TabIndex = 8;
			this.DateLB.Text = "Date";
			// 
			// DTP
			// 
			this.DTP.Location = new System.Drawing.Point(628, 355);
			this.DTP.Name = "DTP";
			this.DTP.Size = new System.Drawing.Size(200, 26);
			this.DTP.TabIndex = 9;
			// 
			// AddTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1395, 916);
			this.Controls.Add(this.DTP);
			this.Controls.Add(this.DateLB);
			this.Controls.Add(this.TimeLB);
			this.Controls.Add(this.NumHall);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.HallLB);
			this.Controls.Add(this.HomeBTN);
			this.Controls.Add(this.DoneBTN);
			this.Controls.Add(this.AddTimeBTN);
			this.Name = "AddTime";
			this.Text = "AddTime";
			((System.ComponentModel.ISupportInitialize)(this.NumHall)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddTimeBTN;
		private System.Windows.Forms.Button DoneBTN;
		private System.Windows.Forms.Button HomeBTN;
		private System.Windows.Forms.Label HallLB;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.NumericUpDown NumHall;
		private System.Windows.Forms.Label TimeLB;
		private System.Windows.Forms.Label DateLB;
		private System.Windows.Forms.DateTimePicker DTP;
	}
}