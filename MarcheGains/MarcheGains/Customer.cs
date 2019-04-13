using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcheGains
{
    [Serializable]
    public class Customer
    {
       

       
        public Customer()
        {
            Virtual_Banking Account = new Virtual_Banking();
           


        }

    public Customer(string name = null, string password = null, string username = null)
        {
            Name = name;
            Password = password;
            Username = username;

            Virtual_Banking Account = new Virtual_Banking();

        }
        
        public string Name
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        public string EmailAddress {
            get;
            set;
        }

        public Virtual_Banking Virtual_Banking
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Stock Stock
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Virtual_Banking Account = new Virtual_Banking();
        
        //public Virtual_Banking Account
        // {
        //     get;
        //     set;
        //}


        public virtual void makeOrder()
        {
            throw new System.NotImplementedException();
        }

        public virtual int getAccount()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getName()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getPassword()
        {
            throw new System.NotImplementedException();
        }

        public virtual string getUsername()
        {
            throw new System.NotImplementedException();
        }

        public bool credentialscorret(string usernameEnter, string passwordEnter)
        {
            if(usernameEnter == Username && passwordEnter == Password)
            {
                return true;
            }
            return false;
        }

    }
}
