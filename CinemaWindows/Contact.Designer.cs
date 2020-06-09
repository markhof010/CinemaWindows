namespace CinemaWindows
{
	partial class Contact
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
            this.HomeBTN.Location = new System.Drawing.Point(16, 15);
            this.HomeBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(149, 44);
            this.HomeBTN.TabIndex = 8;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2164, 1186);
            this.Controls.Add(this.HomeBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Contact";
            this.Text = "Contact";
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button HomeBTN;
	}
}