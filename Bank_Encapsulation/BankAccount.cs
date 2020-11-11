using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Encapsulation
{
    class BankAccount
    {
        private double Balance;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount} to your account");
            Balance = amount;

        }

        public double GetBalance()
        {
            return Balance;
        }

    }
}
