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
            this.AddTimeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTimeBTN.Enabled = false;
            this.AddTimeBTN.Location = new System.Drawing.Point(628, 894);
            this.AddTimeBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddTimeBTN.Name = "AddTimeBTN";
            this.AddTimeBTN.Size = new System.Drawing.Size(225, 44);
            this.AddTimeBTN.TabIndex = 0;
            this.AddTimeBTN.Text = "Add another time";
            this.AddTimeBTN.UseVisualStyleBackColor = true;
            this.AddTimeBTN.Click += new System.EventHandler(this.AddTimeBTN_Click);
            // 
            // DoneBTN
            // 
            this.DoneBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneBTN.Enabled = false;
            this.DoneBTN.Location = new System.Drawing.Point(1044, 894);
            this.DoneBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(149, 44);
            this.DoneBTN.TabIndex = 1;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.UseVisualStyleBackColor = true;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBTN.Location = new System.Drawing.Point(1695, 15);
            this.HomeBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(149, 44);
            this.HomeBTN.TabIndex = 2;
            this.HomeBTN.Text = "Logout";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // HallLB
            // 
            this.HallLB.AutoSize = true;
            this.HallLB.Location = new System.Drawing.Point(832, 222);
            this.HallLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HallLB.Name = "HallLB";
            this.HallLB.Size = new System.Drawing.Size(49, 25);
            this.HallLB.TabIndex = 3;
            this.HallLB.Text = "Hall";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(837, 346);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 31);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NumHall
            // 
            this.NumHall.Location = new System.Drawing.Point(837, 251);
            this.NumHall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.NumHall.Size = new System.Drawing.Size(117, 31);
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
            this.TimeLB.Location = new System.Drawing.Point(832, 318);
            this.TimeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(59, 25);
            this.TimeLB.TabIndex = 7;
            this.TimeLB.Text = "Time";
            // 
            // DateLB
            // 
            this.DateLB.AutoSize = true;
            this.DateLB.Location = new System.Drawing.Point(832, 415);
            this.DateLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(57, 25);
            this.DateLB.TabIndex = 8;
            this.DateLB.Text = "Date";
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(837, 444);
            this.DTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(265, 31);
            this.DTP.TabIndex = 9;
            // 
            // AddTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 1145);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.NumHall);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HallLB);
            this.Controls.Add(this.HomeBTN);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.AddTimeBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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