using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcheGains
{
    public partial class UserRegistration : Form
    {

        public string mname;
        public string mpassword1;
        public string mpassword2;
        public string musername;
        public string maccountNum;
        public string mroutNum;
        public string mEmailAddress;

        


        public UserRegistration()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            mname = NameBox.Text;
            mpassword1 = PasswordBox.Text;
            mpassword2 = Password2Box.Text;
            musername = UsernameBox.Text;
            mEmailAddress = EmailTextBox.Text;

            //maccountNum = AccNumberBox.Text;
            //mroutNum = RoutNumberBox.Text;

            if( mpassword1 == mpassword2)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match!");
            }


        }

        private void registertest_Click(object sender, EventArgs e)
        {
            NameBox.Text = "John Litman";
            PasswordBox.Text = "BigJohn";
            Password2Box.Text = "BigJohn";
            UsernameBox.Text = "JLitman";
            
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
