using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        double money;
        string id;
        string pwd;

        public Account ( String id, string pwd, double money )
        {
            this.id = id;
            this.pwd = pwd;
            this.money = money;
        }

        public double getMoney()
        {
            return money;
        }

        public void setMoney ( double val )
        {
            this.money = val;
        }

        public string getId()
        {
            return id;
        }

        public void setId ( string id )
        {
            this.id = id;
        }

        public bool SaveMoney ( double money )
        {
            if ( money < 0 ) return false;

            this.money += money;
            return true;
        }

        public bool WithdrawMoney ( double money )
        {
            if ( this.money >= money )
            {
                this.money -= money;
                return true;
            }
            return false;
        }

        public bool IsMatch ( string id, string pwd )
        {
            return (id == this.id) && (pwd == this.pwd);
        }

    }
}
