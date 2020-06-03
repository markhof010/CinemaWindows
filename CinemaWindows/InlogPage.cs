using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CinemaWindows
{
	public partial class InlogPage : Form
	{
        public static string sha256_hash(string valueToEncrypt)
        {
            StringBuilder stringbuilder = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(valueToEncrypt));

                foreach (byte b in result)
                {
                    stringbuilder.Append(b.ToString());
                }
            }
            return stringbuilder.ToString();
        }

        public InlogPage()
		{
			InitializeComponent();
		}

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool checkLogin = true;
            SHA256 encrypter = SHA256.Create();
            ChangeData logincheck = new ChangeData();
            string encryptedusername = sha256_hash(UsernameTextBox.Text);
            string encryptedpassword = sha256_hash(PasswordTextBox.Text);

            string checkeddata = logincheck.checkLoginAndFunction(encryptedusername, encryptedpassword);

            switch (checkeddata)
            {
                case "admin":
                    //send to admin page
                    this.Close();
                    break;

                case "retailer":
                    //send to retailer page
                    this.Close();
                    break;

                case "ticketsalesman":
                    //send to ticketsaleman page
                    this.Close();
                    break;

                default:
                    infoLabel.Text = "These are the wrong cridentials";
                    break;
            }
        }
    }
}
