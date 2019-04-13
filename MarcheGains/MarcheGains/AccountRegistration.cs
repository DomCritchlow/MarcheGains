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
    public partial class AccountRegistration : Form
    {

        public Customer regCust = new Customer();
        public AccountRegistration()
        {
            InitializeComponent();
        }

        private void AccountRegistration_Load(object sender, EventArgs e)
        {
            AccName_Box.Text = regCust.Name;

        }

        private void Account_Reg_Click(object sender, EventArgs e)
        {

            regCust.Name = AccName_Box.Text;
            regCust.Account.Account_Number = AccNum_Box.Text;
            regCust.Account.Routing_Number = AccRouting_Box.Text;
           // regCust.EmailAddress = EmailTextBox.Text;
            regCust.Account.Account_Balance = Convert.ToDouble(Invest_Balance.Text);
            regCust.Account.ActiveAccount = true;
            this.Close();

        }
    }

    public partial class CopyOfAccountRegistration : Form
    {

        public Customer regCust = new Customer();
        public CopyOfAccountRegistration()
        {
            InitializeComponent();
        }

        private void AccountRegistration_Load(object sender, EventArgs e)
        {
            AccName_Box.Text = regCust.Name;

        }

        private void Account_Reg_Click(object sender, EventArgs e)
        {

            regCust.Name = AccName_Box.Text;
            regCust.Account.Account_Number = AccNum_Box.Text;
            regCust.Account.Routing_Number = AccRouting_Box.Text;
            
            regCust.Account.Account_Balance = Convert.ToDouble(Invest_Balance.Text);
            regCust.Account.ActiveAccount = true;
            this.Close();

        }
    }
}
