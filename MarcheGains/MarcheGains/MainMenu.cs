using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using DotNet.Highcharts;
using DotNet.Highcharts.Options;
using DotNet.Highcharts.Helpers;
using System.Threading;

namespace MarcheGains
{
    public partial class MainMenu : Form
    {
        public Customer cust = new Customer();

        public List<string> tickerlist = new List<string>();

        public List<Stock> Cart = new List<Stock>();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CustomerInfobox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ViewStocksButton_Click(object sender, EventArgs e)
        {
            LookUp_Stock lookUpStock = new LookUp_Stock();
            lookUpStock.stocklist = Cart;
            this.Hide();
            lookUpStock.pickedCustomer = cust;

            lookUpStock.ShowDialog();
            Cart = lookUpStock.stocklist;

            this.Show();
            cust = lookUpStock.pickedCustomer;
        }

        private void PurchaseStockButton_Click(object sender, EventArgs e)
        {
           

        }

        private void ViewAccountButton_Click(object sender, EventArgs e)
        {

            BankAccountForm bank = new BankAccountForm();
            bank.Owner = this;

            bank.bankcust = cust;
            this.Hide();
            bank.ShowDialog();
            this.Show();

            cust = bank.bankcust;
        }

        private void ViewInvestmentsButton_Click(object sender, EventArgs e)
        {
            ViewInvestments viewInvest = new ViewInvestments();
            this.Hide();
            foreach(Stock s in Cart)
            {
                Console.WriteLine(s.Name);
            }

            viewInvest.pickedCust = cust;
            viewInvest.viewCart = Cart;
            viewInvest.ShowDialog();
            Cart = viewInvest.viewCart;
            this.Show();
            cust = viewInvest.pickedCust;
        }

        public void chartest(string ticker)
        {
            //VolumeChart
            API_CALL call = new API_CALL();
            Stockhist currentStock = new Stockhist();
            currentStock = call.getstockhist(ticker,365,"Day","price");
            if (currentStock.Dates!= null) {
                for (int i = 0; i < currentStock.Positions.Length; i++)
                {
                    VolumeChart.Series["Close Price"].Points.AddXY(currentStock.Dates[i], currentStock.Elements[0].DataSeries.close.values[i]);
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            RefreshLoad();
        }

        private void RefreshLoad() {
            foreach (var series in VolumeChart.Series)
            {
                series.Points.Clear();
            }

            CustomerInfobox.Text = "Welcome " + cust.Name + " to MarchGains, Happy Investing";

            Stock currentStock = new Stock();
            API_CALL call = new API_CALL();

            currentStock = call.stocklist(tickerlist);
            Thread.Sleep(1000);
            chartest(currentStock.Symbol);

            if (currentStock.Name==null)
            {
                StockofDay_Box.Text = "\n\n***API is busy try refreshing in a second***";

            }
            else {
                StockofDay_Box.Text =
                      "Name: " + currentStock.Name
                    + "\r\nTicker: " + currentStock.Symbol
                    + "\r\nCurrent Price: " + currentStock.LastPrice.ToString() + " USD"
                    + "\r\nRecord High : " + currentStock.High.ToString() + " USD"
                    + "\r\nRecord Low : " + currentStock.Low.ToString() + " USD"
                    + "\r\nTime Stamp : " + currentStock.TimeStamp;
            }
        }

        private void VolumeChart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
