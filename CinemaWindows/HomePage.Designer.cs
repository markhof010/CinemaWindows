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
			this.MenuBTN = new System.Windows.Forms.Button();
			this.ContactBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginButon
			// 
			this.loginButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginButon.Location = new System.Drawing.Point(1569, 18);
			this.loginButon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.loginButon.Name = "loginButon";
			this.loginButon.Size = new System.Drawing.Size(112, 35);
			this.loginButon.TabIndex = 0;
			this.loginButon.Text = "login";
			this.loginButon.UseVisualStyleBackColor = true;
			this.loginButon.Click += new System.EventHandler(this.loginButon_Click);
			// 
			// MenuBTN
			// 
			this.MenuBTN.Location = new System.Drawing.Point(12, 18);
			this.MenuBTN.Name = "MenuBTN";
			this.MenuBTN.Size = new System.Drawing.Size(112, 35);
			this.MenuBTN.TabIndex = 1;
			this.MenuBTN.Text = "Menu";
			this.MenuBTN.UseVisualStyleBackColor = true;
			this.MenuBTN.Click += new System.EventHandler(this.MenuBTN_Click);
			// 
			// ContactBTN
			// 
			this.ContactBTN.Location = new System.Drawing.Point(1569, 899);
			this.ContactBTN.Name = "ContactBTN";
			this.ContactBTN.Size = new System.Drawing.Size(112, 35);
			this.ContactBTN.TabIndex = 2;
			this.ContactBTN.Text = "Contact";
			this.ContactBTN.UseVisualStyleBackColor = true;
			this.ContactBTN.Click += new System.EventHandler(this.ContactBTN_Click);
			// 
			// HomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1700, 946);
			this.Controls.Add(this.ContactBTN);
			this.Controls.Add(this.MenuBTN);
			this.Controls.Add(this.loginButon);
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "HomeScreen";
			this.Text = "Home Screen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button loginButon;
		private System.Windows.Forms.Button MenuBTN;
		private System.Windows.Forms.Button ContactBTN;
	}
}

