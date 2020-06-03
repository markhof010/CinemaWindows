namespace CinemaWindows
{
    partial class ChooseSeats
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
            this.HallPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HallPictureBox
            // 
            this.HallPictureBox.Location = new System.Drawing.Point(10, 10);
            this.HallPictureBox.Name = "HallPictureBox";
            this.HallPictureBox.Size = new System.Drawing.Size(1240, 650);
            this.HallPictureBox.TabIndex = 0;
            this.HallPictureBox.TabStop = false;
            // 
            // ChooseSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.HallPictureBox);
            this.Name = "ChooseSeats";
            this.Text = "ChooseSeats";
            ((System.ComponentModel.ISupportInitialize)(this.HallPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HallPictureBox;
    }
}