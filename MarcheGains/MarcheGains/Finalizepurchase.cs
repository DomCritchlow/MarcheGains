using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace MarcheGains
{
    public partial class Finalizepurchase : Form
    {

        public List<Stock> finstocklist = new List<Stock>();

      

        public Customer finCust = new Customer();
        public Finalizepurchase()
        {
            InitializeComponent();
        }


        private void populateText()
        {
            double testVar, testVar2, testVar3;
            listView1.Items.Clear();

            foreach (Stock ye in finstocklist)
            {
                testVar = Double.Parse(ye.Qty);
                testVar2 = ye.LastPrice;
                testVar3 = testVar * testVar2;
                ListViewItem currStock = new ListViewItem(ye.Qty);
                currStock.SubItems.Add(ye.Name);
                currStock.SubItems.Add(ye.Symbol);
                currStock.SubItems.Add(testVar3.ToString());

                listView1.Items.Add(currStock);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double testVar, testVar2, testVar3, totalFinalPrice = 0;
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("Account Information for " + finCust.Name + ".");
            sb.AppendLine("Account Name : " + finCust.Name + "\n"+ 
                "Account Number : " + finCust.Account.Account_Number + "\n " + "Routing Number : " + finCust.Account.Routing_Number + "\n");
            sb.AppendLine("Stocks that you have invested in:\n");



            foreach(Stock ye in finstocklist)
            {
                testVar = Double.Parse(ye.Qty);
                testVar2 = ye.LastPrice;
                testVar3 = testVar * testVar2;
                sb.AppendLine(ye.Qty + " " + ye.Name + " " + ye.Symbol + " " + testVar3);

                totalFinalPrice = totalFinalPrice + testVar3;
            }

            sb.AppendLine("\nYour Stock brocker will send you a receipt of the purchase once it has been officially finalized.\n\n");

            string testEmail = finCust.EmailAddress;
                //string toaddress = "dcritchlow@my.apsu.edu";
            string toaddress = "dcritchlow@my.apsu.edu," + testEmail;
            Investments inv = new Investments();
                inv.sendEmail(toaddress,sb);

            finCust.Account.Account_Balance = finCust.Account.Account_Balance - totalFinalPrice;

                this.Close();
        }

        private void Finalizepurchase_Load(object sender, EventArgs e)
        {
            populateText();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
