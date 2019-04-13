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
    public partial class Deposit_WithdrawForm : Form
    {

        public double amount = 0;
        public string transcation;
        public Deposit_WithdrawForm()
        {
            InitializeComponent();
            amount_box.Text = "0";
            this.Text = transcation;
        }

        private void Deposit_WithdrawForm_Load(object sender, EventArgs e)
        {
            transaction_button.Text = transcation;
            amount_box.Text = "0";
            this.Text = transcation;
        }

        private void transaction_button_Click(object sender, EventArgs e)
        {
            double d;
            if (!Double.TryParse(amount_box.Text, out d))
                Console.WriteLine("Wrong input");
            else {
                amount = Convert.ToDouble(amount_box.Text);
                this.Close();
            }
        }
    }
}
