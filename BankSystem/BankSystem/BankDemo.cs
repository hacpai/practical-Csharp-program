using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class BankDemo
    {
        public static void Main ( string [] args )
        {
            Bank bank = new Bank();
            bank.OpenAccount ( "666", "888", 20 );
            bank.OpenAccount ( "000", "000", 60 );
            ATM atm = new ATM ( bank );

            for ( int i = 0; i < 5; i++ )
            {
                atm.Transaction ();
            }
        }
    }
}
    
