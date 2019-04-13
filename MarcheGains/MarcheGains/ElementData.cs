using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
    public class ElementData
    {

       public string Currency
        {
            get;
            set;
        }

        public Object TimeStamp
        {
            get;
            set;
        }

        public string Symbol
        {
            get;
            set;
        }

        public string Type 
        {
            get;
            set;
        }


        public DataSeries DataSeries
        {
            get;
            set;
        }

        public DataSeries DataSeries1
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
