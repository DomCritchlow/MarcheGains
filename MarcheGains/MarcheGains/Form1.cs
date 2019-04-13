using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MarcheGains
{
    
    public partial class Form1 : Form
    {

        string filename = "Customers.dat";
        List<Customer> custList = new List<Customer>();
        Customer currentcust = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void newUser_Click_1(object sender, EventArgs e)
        {
            UserRegistration register = new UserRegistration();
            register.Owner = this;
            register.ShowDialog();
            custList.Add(new Customer { Name = register.mname, Password = register.mpassword1, Username = register.musername, EmailAddress = register.mEmailAddress });
          
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            bool accountfound = false;
            MainMenu menu = new MainMenu();
            menu.Owner = this;

            foreach (Customer cus in custList)
            {
                if(cus.credentialscorret(Username_Textbox.Text, Password_TextBox.Text))
                {
                    accountfound = true;
                    this.Hide();
                    menu.cust = cus;
                    menu.ShowDialog();
                }
            }
            if (!accountfound)
            {
                MessageBox.Show("Wrong Credenitials");
            }

            currentcust = menu.cust;

            if (accountfound)
            {
                closeProg();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filename)) {
                using (Stream stream = File.Open(filename, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    custList = (List<Customer>)bin.Deserialize(stream);
                }
            }
        }

        private void testlogin_Click(object sender, EventArgs e)
        {
            Username_Textbox.Text = "JLitman";
            Password_TextBox.Text = "BigJohn";
        }

        private void closeProg()
        {
                //Serialize Data
                using (Stream stream = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, custList);
                }

                this.Close();
        }
    }
}
