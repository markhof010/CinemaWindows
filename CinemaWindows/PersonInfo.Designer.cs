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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PersonInfoNext = new System.Windows.Forms.Button();
            this.movielbl = new System.Windows.Forms.Label();
            this.titellbl = new System.Windows.Forms.Label();
            this.seatlbl = new System.Windows.Forms.Label();
            this.seatslbl = new System.Windows.Forms.Label();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.timechosenlbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(258, 213);
            this.name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(258, 356);
            this.surname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(104, 25);
            this.surname.TabIndex = 1;
            this.surname.Text = "Surname:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(258, 496);
            this.email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(154, 25);
            this.email.TabIndex = 2;
            this.email.Text = "Email address:";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(264, 246);
            this.NameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(196, 31);
            this.NameInput.TabIndex = 3;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(264, 387);
            this.SurnameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(196, 31);
            this.SurnameInput.TabIndex = 4;
            this.SurnameInput.TextChanged += new System.EventHandler(this.SurnameInput_TextChanged);
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(264, 527);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(196, 31);
            this.EmailInput.TabIndex = 5;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // PersonInfoNext
            // 
            this.PersonInfoNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonInfoNext.Enabled = false;
            this.PersonInfoNext.Location = new System.Drawing.Point(878, 798);
            this.PersonInfoNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PersonInfoNext.Name = "PersonInfoNext";
            this.PersonInfoNext.Size = new System.Drawing.Size(150, 44);
            this.PersonInfoNext.TabIndex = 6;
            this.PersonInfoNext.Text = "Next";
            this.PersonInfoNext.UseVisualStyleBackColor = true;
            this.PersonInfoNext.Click += new System.EventHandler(this.PersonInfoNext_Click);
            // 
            // movielbl
            // 
            this.movielbl.AutoSize = true;
            this.movielbl.Location = new System.Drawing.Point(1080, 213);
            this.movielbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.movielbl.Name = "movielbl";
            this.movielbl.Size = new System.Drawing.Size(76, 25);
            this.movielbl.TabIndex = 7;
            this.movielbl.Text = "Movie:";
            // 
            // titellbl
            // 
            this.titellbl.AutoSize = true;
            this.titellbl.Location = new System.Drawing.Point(1086, 246);
            this.titellbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titellbl.Name = "titellbl";
            this.titellbl.Size = new System.Drawing.Size(253, 25);
            this.titellbl.TabIndex = 8;
            this.titellbl.Text = "hier moet een titel komen";
            // 
            // seatlbl
            // 
            this.seatlbl.AutoSize = true;
            this.seatlbl.Location = new System.Drawing.Point(1086, 321);
            this.seatlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.seatlbl.Name = "seatlbl";
            this.seatlbl.Size = new System.Drawing.Size(73, 25);
            this.seatlbl.TabIndex = 9;
            this.seatlbl.Text = "Seats:";
            // 
            // seatslbl
            // 
            this.seatslbl.AutoSize = true;
            this.seatslbl.Location = new System.Drawing.Point(1086, 346);
            this.seatslbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.seatslbl.Name = "seatslbl";
            this.seatslbl.Size = new System.Drawing.Size(259, 25);
            this.seatslbl.TabIndex = 10;
            this.seatslbl.Text = "hier moet de seats komen";
            // 
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.Location = new System.Drawing.Point(1086, 442);
            this.totalpricelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(254, 25);
            this.totalpricelbl.TabIndex = 12;
            this.totalpricelbl.Text = "hier moet de price komen";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(1086, 417);
            this.pricelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(119, 25);
            this.pricelbl.TabIndex = 11;
            this.pricelbl.Text = "Totel price:";
            // 
            // timechosenlbl
            // 
            this.timechosenlbl.AutoSize = true;
            this.timechosenlbl.Location = new System.Drawing.Point(1086, 533);
            this.timechosenlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timechosenlbl.Name = "timechosenlbl";
            this.timechosenlbl.Size = new System.Drawing.Size(235, 25);
            this.timechosenlbl.TabIndex = 14;
            this.timechosenlbl.Text = "hier moet de tijd komen";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(1086, 508);
            this.timelbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(65, 25);
            this.timelbl.TabIndex = 13;
            this.timelbl.Text = "Time:";
            // 
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1986, 1073);
            this.Controls.Add(this.timechosenlbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.totalpricelbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.seatslbl);
            this.Controls.Add(this.seatlbl);
            this.Controls.Add(this.titellbl);
            this.Controls.Add(this.movielbl);
            this.Controls.Add(this.PersonInfoNext);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.SurnameInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.email);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PersonInfo";
            this.Text = "PersonInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label surname;
		private System.Windows.Forms.Label email;
		private System.Windows.Forms.TextBox NameInput;
		private System.Windows.Forms.TextBox SurnameInput;
		private System.Windows.Forms.TextBox EmailInput;
		private System.Windows.Forms.Button PersonInfoNext;
		private System.Windows.Forms.Label movielbl;
		private System.Windows.Forms.Label titellbl;
		private System.Windows.Forms.Label seatlbl;
		private System.Windows.Forms.Label seatslbl;
		private System.Windows.Forms.Label totalpricelbl;
		private System.Windows.Forms.Label pricelbl;
		private System.Windows.Forms.Label timechosenlbl;
		private System.Windows.Forms.Label timelbl;
	}
}