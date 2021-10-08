using System;
using System.IO;


/*
 *  Checking whether an input – such as an ATM card (a debit/credit card number) – is recorded correctly
    Verifying the user by asking for a PIN
    In case of negative verification, logging out the user
    In case of positive verification, showing multiple options, including cash availability, the previous five transactions, and cash withdrawal
    Giving the user the ability to withdraw up to $1,000 worth of cash in one transaction, with total transactions limited to ten per day.

For a more complicated program, include the ability to register a new PIN and mobile number,
a detailed bank statement, and a “fast” cash withdrawal system for quickly withdrawing $20, $50, or $100.
 * 
 * 
 */
namespace ATMConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");

                BankAccount Account1 = new BankAccount();
                try
                {
                    Account1.PIN = "2245";
                }
                catch (Exception e)
                {
                    // Something unexpected went wrong.
                    Console.WriteLine(e);
                    // Maybe it is also necessary to terminate / restart the application.
                }


                Console.WriteLine(Account1.PIN);
                Account1.ChangePIN();
                Console.WriteLine("test");
                Console.WriteLine(Account1.PIN);

                break;

                /*
                if (Account1.CheckPIN() == true)
                { 
                    
                }
                */
                /*
                if (CheckPIN() == true)
                {
                    BankingMenu();
                }*/

            }
        }      
    }

    public class InvalidPINException : Exception
    {
        public InvalidPINException()
        { 
        }

        public InvalidPINException(string message)
            :base(message)
        {
        }

        public InvalidPINException(string message, Exception inner)
            :base(message, inner)
        {
        }
    }
}
