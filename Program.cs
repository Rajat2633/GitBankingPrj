using System;

namespace GitBankingPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Git Banking....");
            Console.WriteLine("Create Bank Account....");
            BankAccount sbs = new BankAccount();
           
            Console.WriteLine(sbs.AccountNumber);

        }
    }
}
