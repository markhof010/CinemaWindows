namespace CinemaWindows.AdminPage
{
	partial class AddMovie
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
			this.ReturnBTN = new System.Windows.Forms.Button();
			this.LogoutBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ReturnBTN
			// 
			this.ReturnBTN.Location = new System.Drawing.Point(13, 13);
			this.ReturnBTN.Name = "ReturnBTN";
			this.ReturnBTN.Size = new System.Drawing.Size(112, 35);
			this.ReturnBTN.TabIndex = 0;
			this.ReturnBTN.Text = "Return";
			this.ReturnBTN.UseVisualStyleBackColor = true;
			this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
			// 
			// LogoutBTN
			// 
			this.LogoutBTN.Location = new System.Drawing.Point(1507, 12);
			this.LogoutBTN.Name = "LogoutBTN";
			this.LogoutBTN.Size = new System.Drawing.Size(112, 35);
			this.LogoutBTN.TabIndex = 1;
			this.LogoutBTN.Text = "Logout";
			this.LogoutBTN.UseVisualStyleBackColor = true;
			this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
			// 
			// AddMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1631, 921);
			this.Controls.Add(this.LogoutBTN);
			this.Controls.Add(this.ReturnBTN);
			this.Name = "AddMovie";
			this.Text = "AddMovie";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ReturnBTN;
		private System.Windows.Forms.Button LogoutBTN;
	}
}