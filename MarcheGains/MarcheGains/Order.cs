using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
    class Order
    {

        public virtual Investments Investments
        {
            get;
            set;
        }

        internal Investments Investments1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public virtual Investments getInvesment()
        {
            throw new System.NotImplementedException();
        }

        public virtual Customer getBankInfo()
        {
            throw new System.NotImplementedException();
        }

        public virtual void showOrderPreview()
        {
            throw new System.NotImplementedException();
        }

        public virtual void sendOrder()
        {
            throw new System.NotImplementedException();
        }


    }
}
