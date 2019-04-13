using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MarcheGains
{
    public partial class LookUp_Stock : Form
    {

        public List<Stock> stocklist = new List<Stock>();
        public Customer pickedCustomer = new Customer();
        int cartCount = 0;
        Stock currentStock = new Stock();



        public LookUp_Stock()
        {
            InitializeComponent();
        }

        private void LookupButton_Click(object sender, EventArgs e)
        {
            string ticker = tickerBox.Text.ToUpper();

            API_CALL call = new API_CALL();

            currentStock = call.getspecificStock(ticker);

         
            StockInfoBox.Text = "Name: " + currentStock.Name 
                + "\r\nTicker: " + currentStock.Symbol 
                + "\r\nCurrent Price: "  + currentStock.LastPrice.ToString() + " USD"
                + "\r\nRecord High : "+ currentStock.High.ToString() + " USD"
                + "\r\nRecord Low : " + currentStock.Low.ToString() + " USD"
                + "\r\nTime Stamp : " + currentStock.TimeStamp;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //Thread.Sleep(5000);
            Stockhist currentStockhist = new Stockhist();
            currentStockhist = call.getstockhist(ticker, 365, "Day", "price");
            if (currentStockhist.Dates != null)
            {
                for (int i = 0; i < currentStockhist.Positions.Length; i++)
                {
                    chart1.Series["Close Price"].Points.AddXY(currentStockhist.Dates[i], currentStockhist.Elements[0].DataSeries.close.values[i]);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StockInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChooseStock_Click(object sender, EventArgs e)
        {
            stocklist.Add(currentStock);
            StockAddedLabel.Text = currentStock.Name + " has been added to your cart!";
            ItemsInCartLabel.Text = stocklist.Count.ToString() + " Items currently in cart.";




        }

        

        private void LookUp_Stock_Load(object sender, EventArgs e)
        {
            ItemsInCartLabel.Text = stocklist.Count.ToString() + " Items currently in cart.";

            qty_box.Text = "0";


          


        }

        private void StockAddedLabel_Click(object sender, EventArgs e)
        {

        }

        private void purchase_button_Click(object sender, EventArgs e)
        {
            Finalizepurchase purchase = new Finalizepurchase();
            double d,tryHard;
            if (!Double.TryParse(qty_box.Text, out d))
                Console.WriteLine("Wrong input");
            else {
                if (Double.Parse(qty_box.Text) > 0 && currentStock.Name != null)
                {

                    currentStock.Qty = qty_box.Text;

                    purchase.finstocklist.Add(currentStock);
                    purchase.finCust = pickedCustomer;
                    tryHard = Double.Parse(currentStock.Qty) * currentStock.LastPrice;
                    if (pickedCustomer.Account.Account_Balance - tryHard < 0)
                    {
                        MessageBox.Show("Exceeded Funds");
                    }
                    else {
                        purchase.ShowDialog();

                        pickedCustomer = purchase.finCust;

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Entries!");
                }
            }
        }
    }
}
