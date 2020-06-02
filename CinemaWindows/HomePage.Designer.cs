namespace CinemaWindows
{
	partial class HomeScreen
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
            this.loginButon = new System.Windows.Forms.Button();
            this.PersonInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButon
            // 
            this.loginButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButon.Location = new System.Drawing.Point(1046, 12);
            this.loginButon.Name = "loginButon";
            this.loginButon.Size = new System.Drawing.Size(75, 23);
            this.loginButon.TabIndex = 0;
            this.loginButon.Text = "login";
            this.loginButon.UseVisualStyleBackColor = true;
            this.loginButon.Click += new System.EventHandler(this.loginButon_Click);
            // 
            // PersonInfoButton
            // 
            this.PersonInfoButton.Location = new System.Drawing.Point(910, 12);
            this.PersonInfoButton.Name = "PersonInfoButton";
            this.PersonInfoButton.Size = new System.Drawing.Size(130, 23);
            this.PersonInfoButton.TabIndex = 1;
            this.PersonInfoButton.Text = "Personal Information";
            this.PersonInfoButton.UseVisualStyleBackColor = true;
            this.PersonInfoButton.Click += new System.EventHandler(this.PersonInfoButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 615);
            this.Controls.Add(this.PersonInfoButton);
            this.Controls.Add(this.loginButon);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button loginButon;
		private System.Windows.Forms.Button PersonInfoButton;
	}
}

