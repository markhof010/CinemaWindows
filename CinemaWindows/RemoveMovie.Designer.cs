namespace CinemaWindows
{
	partial class RemoveMovie
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
			this.SuspendLayout();
			// 
			// ReturnBTN
			// 
			this.ReturnBTN.Location = new System.Drawing.Point(11, 11);
			this.ReturnBTN.Margin = new System.Windows.Forms.Padding(2);
			this.ReturnBTN.Name = "ReturnBTN";
			this.ReturnBTN.Size = new System.Drawing.Size(75, 23);
			this.ReturnBTN.TabIndex = 18;
			this.ReturnBTN.Text = "Return";
			this.ReturnBTN.UseVisualStyleBackColor = true;
			this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
			// 
			// RemoveMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(975, 524);
			this.Controls.Add(this.ReturnBTN);
			this.Name = "RemoveMovie";
			this.Text = "RemoveMovie";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ReturnBTN;
	}
}