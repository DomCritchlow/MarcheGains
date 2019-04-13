using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
    [Serializable]
    public class Virtual_Banking
    {

        public Virtual_Banking(){
            ActiveAccount = false;
        }



        public bool ActiveAccount
        {
            get;
            set;
        }
        public virtual string Account_Number
        {
            get;
            set;
        }

        public virtual string Account_Name
        {
            get;
            set;
        }

        public virtual string Routing_Number
        {
            get;
            set;
        }

        public virtual double Account_Balance
        {
            get;
            set;
        }

        public virtual double getBalance()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getName() 
	{
		throw new System.NotImplementedException();
	}

    public virtual double getAccNum()
    {
        throw new System.NotImplementedException();
    }

    public virtual double getRoutNum()
    {
        throw new System.NotImplementedException();
    }

    public virtual void deposit(double amount)
    {
            Account_Balance = Account_Balance + amount;
    }

    public virtual void withdrawal(double amount)
    {
            Account_Balance = Account_Balance - amount;
    }



}
}
