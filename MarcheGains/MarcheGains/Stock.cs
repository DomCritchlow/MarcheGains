using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
   public class Stock
    {

        public string Name
        {
            get;
            set;
        }

        public double minDeposit
        {
            get;
            set;
        }
       
        public double currInvestPrice
        {
            get;
            set;
        }

        public string Symbol
        {
            get;
            set;
        }

        public double Change
        {
            get;
            set;
        }

        public double ChangePercent
        {
            get;
            set;
        }

        public string TimeStamp
        {
            get;
            set;
        }

        public double LastPrice
        {
            get;
            set;
        }

        public string MSDate
        {
            get;
            set;
        }

        public double MarketCap
        {
            get;
            set;
        }

        public int Volume
        {
            get;
            set;
        }

        public double ChangeYTD
        {
            get;
            set;
        }

        public double High
        {
            get;
            set;
        }

        public double Low
        {
            get;
            set;
        }

        public double Open
        {
            get;
            set;
        }

        public virtual MutualFund Mutual_Fund
        {
            get;
            set;
        }

        public string Qty
        {
            get;
            set;
        }

        public Stock()
        {
        }

        


    }
}
