using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
    public class DataSeries
    {

        public ohlc open
        {
            get;
            set;
        }

        public ohlc high
        {
            get;
            set;
        }
        public ohlc low
        {
            get;
            set;
        }
        public ohlc close
        {
            get;
            set;
        }

        public ohlc volume
        {
            get;
            set;
        }

        public ohlc ohlc
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
