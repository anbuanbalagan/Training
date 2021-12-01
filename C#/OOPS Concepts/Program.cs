using System;

namespace OOPS_Concepts
{
	public class Account
	{
		private double balance;

		public Account()
		{
		}

		public Account(double initial_deposit)
		{
			balance = initial_deposit;
		}

		public void depositFunds(double amount)
		{
			balance = balance + amount;
		}

		public double getBalance()
		{
			return balance;
		}

		public double withdrawFunds(double amount)
		{
			if(amount > balance)
			{
				//amount = balance;
				Console.WriteLine("Insufficient Fund");			
			}
			balance = balance - amount;
			return amount;
		}
		public static void Main()
		{
			Account acc = new Account(10000);
			Console.WriteLine("Enter the deposit amount");
			double damt = Convert.ToDouble(Console.ReadLine());
			acc.depositFunds(damt);
			Console.WriteLine("Balance Amount is : $" + acc.getBalance());

			Console.WriteLine("Enter the Withdraw amount");
			double wamt = Convert.ToDouble(Console.ReadLine());
			acc.withdrawFunds(wamt);
			Console.WriteLine("Balance Amount is : $" + acc.getBalance());
		}
	}
}



