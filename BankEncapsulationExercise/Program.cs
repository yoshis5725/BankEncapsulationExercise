using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating new bank account
            var newAccount = new BankAccount();

            newAccount.Deposit(500);
            Console.Write($"Account Balance - ${newAccount.GetBalance()}");
        }
    }
}

