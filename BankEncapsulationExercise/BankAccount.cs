using System;
namespace BankEncapsulationExercise
{
	public class BankAccount
	{
		public BankAccount()
		{
		}

		private double balance = 0;


		// <------- Class Methods ------->

		public double Deposit(int depositAmount)
        {
			return balance += depositAmount;
        }


		public double GetBalance()
        {
			return balance; 
        }
    }
}

