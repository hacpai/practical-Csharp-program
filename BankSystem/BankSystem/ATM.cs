using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class ATM
    {
        Bank bank;

        public ATM ( Bank bank )
        {
            this.bank = bank;
        }

        public void Transaction ()
        {
            Show( "Please insert your card" );
            string id = GetInput();

            Show( "Please enter your password" );
            string pwd = GetInput();

            Account account = bank.FindAccount( id, pwd );

            if ( account == null )
            {
                Show( "Card invalid or password not corrent" );
                return;
            }

            Show ( "1: display; 2: save; 3: withdraw" );
            string op = GetInput();
            if ( op == "1" )
            {
                Show( "Balance: " + account.getMoney() );
            }
            else if ( op == "2" )
            {
                Show( "Save money" );
                string smoney = GetInput();
                double money = double.Parse( smoney );

                bool ok = account.SaveMoney( money );
                if ( ok ) Show( "OK" );
                else Show ( "error" );

                Show( "Balance: " + account.getMoney() );
            }
            else if ( op == "3" )
            {
                Show ( "Withdraw money" );
                string smoney = GetInput();
                double money = double.Parse( smoney );

                bool ok = account.WithdrawMoney ( money );
                if (ok ) Show( "OK" );
                else Show ( "error" );

                Show( "Balance: " + account.getMoney() );
            }
        }

        public void Show ( string msg )
        {
            Console.WriteLine( msg );
        }

        public string GetInput ()
        {
            return Console.ReadLine();
        }
    }
}
