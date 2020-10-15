using System;

namespace MySuperBank
{
	class Program
	{
		static void Main(string[] args)
		{
			var account = new BankAccount("Kendra", 10000);
			Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

			account.MakeWithdrawal(120, DateTime.Now, "Hammock");
			account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
			account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
			account.MakeDeposit(50, DateTime.Now, "Xbox Game");
			account.MakeDeposit(250, DateTime.Now, "Hard Disk");


			//// Test that the initial balances must be positive.
			//try
			//{
			//	var invalidAccount = new BankAccount("invalid", -55);
			//}
			//catch (ArgumentOutOfRangeException e)
			//{
			//	Console.WriteLine("Exception caught creating account with negative balance");
			//	Console.WriteLine(e.ToString());
			//}


			Console.WriteLine(account.GetAccountHistory());

		}
	}
}
