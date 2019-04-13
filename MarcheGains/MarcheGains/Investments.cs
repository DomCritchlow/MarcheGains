using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace MarcheGains
{
    class Investments
    {


        const string emailusername = "marchegains";
        const string emailprovider = "@gmail.com";

        private List<Stock> Stocks_Owned
        {
            get;
            set;
        }

        private object MutualFunds_Owned
        {
            get;
            set;
        }

        public bool sendEmail(string toaddress, System.Text.StringBuilder message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(emailusername+emailprovider);
            mail.To.Add(toaddress);
            mail.Subject = "Finalized Investment Report";
            mail.Body = message + "\n\n MarcheGains Inc.\nTravis Hodge Co-Founder\nDominic Critchlow Co-Founder";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(emailusername, emailpass);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            MessageBox.Show("mail Sent");
            return true;
        }


        public virtual Stock getStock()
        {
            throw new System.NotImplementedException();
        }

        public virtual List<Stock> getMutualFund()
        {
            throw new System.NotImplementedException();
        }


        const string emailpass = "BigDick100";
    }
}
