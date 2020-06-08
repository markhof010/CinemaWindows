namespace CinemaWindows
{
	partial class TicketCode
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
            this.HomeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeBTN
            // 
            this.HomeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBTN.Location = new System.Drawing.Point(17, 16);
            this.HomeBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(149, 44);
            this.HomeBTN.TabIndex = 0;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // TicketCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2359, 1215);
            this.Controls.Add(this.HomeBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketCode";
            this.Text = "TicketCode";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button HomeBTN;
	}
}