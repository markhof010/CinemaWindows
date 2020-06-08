namespace CinemaWindows
{
	partial class InlogPage
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
			this.AdminPageBTN = new System.Windows.Forms.Button();
			this.HomePageBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AdminPageBTN
			// 
			this.AdminPageBTN.Location = new System.Drawing.Point(13, 13);
			this.AdminPageBTN.Name = "AdminPageBTN";
			this.AdminPageBTN.Size = new System.Drawing.Size(112, 35);
			this.AdminPageBTN.TabIndex = 0;
			this.AdminPageBTN.Text = "Admin";
			this.AdminPageBTN.UseVisualStyleBackColor = true;
			this.AdminPageBTN.Click += new System.EventHandler(this.AdminPageBTN_Click);
			// 
			// HomePageBTN
			// 
			this.HomePageBTN.Location = new System.Drawing.Point(1076, 12);
			this.HomePageBTN.Name = "HomePageBTN";
			this.HomePageBTN.Size = new System.Drawing.Size(112, 35);
			this.HomePageBTN.TabIndex = 1;
			this.HomePageBTN.Text = "Home";
			this.HomePageBTN.UseVisualStyleBackColor = true;
			this.HomePageBTN.Click += new System.EventHandler(this.HomePageBTN_Click);
			// 
			// InlogPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1600, 865);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.HomePageBTN);
			this.Controls.Add(this.AdminPageBTN);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "InlogPage";
			this.Text = "Login Page";
			this.Load += new System.EventHandler(this.InlogPage_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AdminPageBTN;
		private System.Windows.Forms.Button HomePageBTN;
	}
}