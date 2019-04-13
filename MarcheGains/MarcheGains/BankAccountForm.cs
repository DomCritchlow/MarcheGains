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
    public partial class BankAccountForm : Form
    {
        public Customer bankcust = new Customer();
        public BankAccountForm()
        {
            InitializeComponent();
        }

        private void BankAccountForm_Load(object sender, EventArgs e)
        {

            header_box.Text = bankcust.Name + "'s Bank Account Information";

            this.reload();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            AccountRegistration regAcc = new AccountRegistration();
            regAcc.Owner = this;

            regAcc.regCust = bankcust;
            regAcc.ShowDialog();
            

            bankcust = regAcc.regCust;
            this.reload();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reload(){
            Balance_Box.Text = bankcust.Account.Account_Balance.ToString();

            if (bankcust.Account.ActiveAccount)
            {
                Nobank_label.Hide();
                RegisterButton.Hide();
                balance_label.Show();
                Balance_Box.Show();
            }
            else {
                Nobank_label.Show();
                balance_label.Hide();
                Balance_Box.Hide();
            }


        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Deposit_WithdrawForm form = new Deposit_WithdrawForm();
            form.Owner = this;

            form.transcation = "Deposit";

            form.ShowDialog();
            double amount = form.amount;
            
            bankcust.Account.deposit(amount);
            this.reload();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            Deposit_WithdrawForm form = new Deposit_WithdrawForm();
            form.Owner = this;

            form.transcation = "Withdraw";

            form.ShowDialog();
            double amount = form.amount;
            if (bankcust.Account.Account_Balance - amount < 0)
            {
                MessageBox.Show("Exceeded Funds.");
            }
            else {
                bankcust.Account.withdrawal(amount);
                this.reload();
            }

        }

        private void Nobank_label_Click(object sender, EventArgs e)
        {

        }
    }
}
