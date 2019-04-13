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
    public partial class ViewInvestments : Form 
    {
        public List<Stock> viewCart = new List<Stock>(); 
        
        public Customer pickedCust = new Customer();

        
        public ViewInvestments()
        {
            InitializeComponent();
        }


        private void ViewInvestments_Load(object sender, EventArgs e)
        {
            refreshlist();
            TotalAccountLabel.Text = pickedCust.Account.Account_Balance.ToString();
            TotalCartBalLabel.Text = "0";


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
           // if (listView1.SelectedIndices.Count!=0) {
                //int index = listView1.SelectedIndices[0];   
            //}

            if (dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                viewCart.RemoveAt(index);
            }

            refreshlist();
        }

        private void refreshlist()
        {
            listView1.Items.Clear();
            
            foreach (Stock ye in viewCart)
            {
                ListViewItem currStock = new ListViewItem(ye.Name);
  
                currStock.SubItems.Add(ye.Symbol);
                currStock.SubItems.Add(ye.ChangePercent.ToString());
                listView1.Items.Add(currStock);
            }

            dataGridView1.Rows.Clear();

            foreach (Stock ye in viewCart)
            {
                dataGridView1.Rows.Add("0",ye.Name,ye.Symbol,ye.LastPrice);
            }



           // dataGridView1.DataSource= testlist;


        }

       
        private void Purchase_button_Click(object sender, EventArgs e)
        {
            double totalFinalPrice = 0, totalStockPrice;
            int i = 0;
            foreach(Stock st in viewCart)
            {

                st.Qty = dataGridView1[0, i].Value.ToString();
                totalStockPrice = Double.Parse(st.Qty) * st.LastPrice;

                totalFinalPrice = totalFinalPrice + totalStockPrice;
                i++;
            }

            if (totalFinalPrice > pickedCust.Account.Account_Balance)
            {

                MessageBox.Show("Exceeded Funds");

            }
            else {

                Finalizepurchase fin = new Finalizepurchase();

                fin.finstocklist = viewCart;

                fin.finCust = pickedCust;

                this.Hide();
                fin.ShowDialog();
                refreshlist();

                //this.Show();  

                pickedCust = fin.finCust;
                viewCart.Clear();

                viewCart.Clear();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            double totalFinalPrice = 0, totalStockPrice;
            int i = 0;
            foreach (Stock st in viewCart)
            {

                st.Qty = dataGridView1[0, i].Value.ToString();
                totalStockPrice = Double.Parse(st.Qty) * st.LastPrice;

                totalFinalPrice = totalFinalPrice + totalStockPrice;
                i++;
            }


            TotalAccountLabel.Text = pickedCust.Account.Account_Balance.ToString();
            TotalCartBalLabel.Text = totalFinalPrice.ToString();
        }

        private void TotalAccountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
