using BankyStuffLibrary;
using System;
using Humanizer;

namespace MySuperBank
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("car".Pluralize());
			Console.WriteLine("paint".Pluralize());
			Console.WriteLine("flashlight".Pluralize());
			Console.WriteLine("fish".Pluralize());
			Console.WriteLine("man".Pluralize());
			Console.WriteLine("3215".Pluralize());
			Console.WriteLine(200061.ToWords());


			var account = new BankAccount("Kendra", 10000);
			Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

			account.MakeWithdrawal(120, DateTime.Now, "Hammock");
			account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
			account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
			account.MakeDeposit(50, DateTime.Now, "Xbox Game");
			account.MakeDeposit(250, DateTime.Now, "Hard Disk");
			account.MakeWithdrawal(456, DateTime.Now, "SSDd");
			account.MakeWithdrawal(123, DateTime.Now, "Power");



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
