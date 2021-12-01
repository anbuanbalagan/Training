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

		public void withdrawFunds(double withdrawamount)
		{
			double withdraw = withdrawamount;

			if(withdraw > balance)
			{			
				Console.WriteLine("Insufficient Fund");			
			}
			else
			{
				balance = balance - withdraw;
				while(balance <= 10000)
				{
					Console.WriteLine("Minimum Balance should be in your account. Try Again...");
					Environment.Exit(0);
				}
				Console.WriteLine("Balance Amount in your Account is: $" + balance);
			}			
		}

		public static void Main()
		{
			Account acc = new Account(10000);

			Console.WriteLine("Balance in Your Account : $ " +acc.getBalance());
			Console.WriteLine("Enter the deposit amount");
			double depositAmount = Convert.ToDouble(Console.ReadLine());
			acc.depositFunds(depositAmount);

			Console.WriteLine("Balance Amount is : $" + acc.getBalance());

			Console.WriteLine("Enter the Withdraw amount");
			double withdrawAmount = Convert.ToDouble(Console.ReadLine());
			acc.withdrawFunds(withdrawAmount);
			Console.WriteLine("\n");			
		}
	}
}



