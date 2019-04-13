using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
    public class Stockhist
    {
        
        public Object Labels
        {
            get;
            set;
        } 

        public double[] Positions
        {
            get;
            set;
        }

        public DateTime[] Dates
        {
            get;
            set;
        }

        public ElementData[] Elements{
            get;
            set;
        }

        public ElementData ElementData
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Positions Positions1
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
