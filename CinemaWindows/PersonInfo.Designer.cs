namespace CinemaWindows
{
    partial class PersonInfo
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
			this.Name = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NameInput = new System.Windows.Forms.TextBox();
			this.SurnameInput = new System.Windows.Forms.TextBox();
			this.EmailInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Name
			// 
			this.Name.AutoSize = true;
			this.Name.Location = new System.Drawing.Point(120, 101);
			this.Name.Name = "Name";
			this.Name.Size = new System.Drawing.Size(38, 13);
			this.Name.TabIndex = 0;
			this.Name.Text = "Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email adress:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(120, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Surname:";
			// 
			// NameInput
			// 
			this.NameInput.Location = new System.Drawing.Point(123, 118);
			this.NameInput.Name = "NameInput";
			this.NameInput.Size = new System.Drawing.Size(100, 20);
			this.NameInput.TabIndex = 3;
			// 
			// SurnameInput
			// 
			this.SurnameInput.Location = new System.Drawing.Point(123, 180);
			this.SurnameInput.Name = "SurnameInput";
			this.SurnameInput.Size = new System.Drawing.Size(100, 20);
			this.SurnameInput.TabIndex = 4;
			// 
			// EmailInput
			// 
			this.EmailInput.Location = new System.Drawing.Point(123, 254);
			this.EmailInput.Name = "EmailInput";
			this.EmailInput.Size = new System.Drawing.Size(100, 20);
			this.EmailInput.TabIndex = 5;
			// 
			// PersonInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 558);
			this.Controls.Add(this.EmailInput);
			this.Controls.Add(this.SurnameInput);
			this.Controls.Add(this.NameInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Name);
			this.Name = "PersonInfo";
			this.Text = "PersonInfo";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label Name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NameInput;
		private System.Windows.Forms.TextBox SurnameInput;
		private System.Windows.Forms.TextBox EmailInput;
	}
}