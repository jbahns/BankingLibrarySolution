using System;
using BankingLibrary;

namespace TestBankingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine(account.Balance);
            account.CalculateInterest(12);
            Console.WriteLine(account.Balance);
        }
    }
}
