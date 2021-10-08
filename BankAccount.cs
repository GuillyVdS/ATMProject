using System;
using System.Collections.Generic;
using System.Text;

namespace ATMConsole
{
    public class BankAccount
    {

        private int Account_NR;
        private string First_Name;
        private string Last_Name;
        private int Sort_Code;
        private string PIN_Number;
        private double Balance;


        //constructor with test data
        public BankAccount()
        {
            Account_NR = 1234567890;
            First_Name = "Mark";
            Last_Name = "Markson";
            Sort_Code = 556688;
            PIN_Number = PIN;
        }

        public string PIN
        {
            get { return PIN_Number; }
            set
            {
                if (value.Length == 4 && int.TryParse(value, out _) == true)
                {
                    PIN_Number = value;
                }
                else
                {
                    Console.WriteLine("invalid nr");
                    throw new InvalidPINException(" Number is invalid.");
                }
            }
        }



        public bool CheckPIN()
        {
            bool statusCheck = false;
            Console.WriteLine("Please enter PIN number");
            try
            {
                int INPUT_To_Check = Convert.ToInt32(Console.ReadLine());

                if (INPUT_To_Check == Convert.ToInt32(PIN_Number))
                {
                    Console.WriteLine("Correct PIN: ");
                    statusCheck = true;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN: ");
                }
            }
            catch
            {
                Console.WriteLine("Not a PIN number");
            }
            return statusCheck;
        }

        public void ChangePIN()
        {
            //verifies PIN before changing PIN value
            Console.WriteLine("Changing PIN\n");
            if (this.CheckPIN() == true)
            {
                //checks input for new PIN twice to ensure accuracy
                while (true)
                {
                    Console.WriteLine("Please enter a new PIN");
                    string newPIN = Console.ReadLine();
                    Console.WriteLine("Confirm PIN");
                    if (newPIN == Console.ReadLine())
                    {
                        this.PIN = newPIN;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("PIN does not match");
                    }
                }
            }        
        }

        public void Withdraw()
        { }

        public void Deposit()
        { }

    }
}
