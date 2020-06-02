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
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(129, 111);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(38, 13);
			this.name.TabIndex = 0;
			this.name.Text = "Name:";
			// 
			// surname
			// 
			this.surname.AutoSize = true;
			this.surname.Location = new System.Drawing.Point(129, 185);
			this.surname.Name = "surname";
			this.surname.Size = new System.Drawing.Size(52, 13);
			this.surname.TabIndex = 1;
			this.surname.Text = "Surname:";
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(129, 258);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(75, 13);
			this.email.TabIndex = 2;
			this.email.Text = "Email address:";
			// 
			// NameInput
			// 
			this.NameInput.Location = new System.Drawing.Point(132, 128);
			this.NameInput.Name = "NameInput";
			this.NameInput.Size = new System.Drawing.Size(100, 20);
			this.NameInput.TabIndex = 3;
			this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
			// 
			// SurnameInput
			// 
			this.SurnameInput.Location = new System.Drawing.Point(132, 201);
			this.SurnameInput.Name = "SurnameInput";
			this.SurnameInput.Size = new System.Drawing.Size(100, 20);
			this.SurnameInput.TabIndex = 4;
			this.SurnameInput.TextChanged += new System.EventHandler(this.SurnameInput_TextChanged);
			// 
			// EmailInput
			// 
			this.EmailInput.Location = new System.Drawing.Point(132, 274);
			this.EmailInput.Name = "EmailInput";
			this.EmailInput.Size = new System.Drawing.Size(100, 20);
			this.EmailInput.TabIndex = 5;
			this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
			// 
			// PersonInfoNext
			// 
			this.PersonInfoNext.Enabled = false;
			this.PersonInfoNext.Location = new System.Drawing.Point(537, 199);
			this.PersonInfoNext.Name = "PersonInfoNext";
			this.PersonInfoNext.Size = new System.Drawing.Size(75, 23);
			this.PersonInfoNext.TabIndex = 6;
			this.PersonInfoNext.Text = "Next";
			this.PersonInfoNext.UseVisualStyleBackColor = true;
			this.PersonInfoNext.Click += new System.EventHandler(this.PersonInfoNext_Click);
			// 
			// PersonInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 558);
			this.Controls.Add(this.PersonInfoNext);
			this.Controls.Add(this.EmailInput);
			this.Controls.Add(this.SurnameInput);
			this.Controls.Add(this.NameInput);
			this.Controls.Add(this.email);
			this.Controls.Add(this.surname);
			this.Controls.Add(this.name);
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
	}
}