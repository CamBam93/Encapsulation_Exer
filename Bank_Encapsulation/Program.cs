using System;

namespace Bank_Encapsulation
{
    class Program
    {
        //In the main method of your application, create a new instance of the BankAccount class.
        //Allow the user of the application to Deposit money and retrieve their balance through the console.
        static void Main(string[] args)
        {
            var newAcc = new BankAccount();
            Console.WriteLine("How many Credits would you like to deposit?" );
            newAcc.Deposit(double.Parse(Console.ReadLine()));
            double userBal = newAcc.GetBalance();
            Console.WriteLine($"Your total Credits are {userBal}");
        }
    }
}
