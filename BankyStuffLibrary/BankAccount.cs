using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankyStuffLibrary
{
	public class BankAccount
	{
		public string Number { get; }
		public string Owner { get; set; }
		public decimal Balance {
			get {
				decimal balance = 0;
				foreach (var transaction in allTransactions)
				{
					balance += transaction.Amount;
				}
				return balance;
			}

		}

		private static int accountNumberSeed = 1234567890;

		private List<Transaction> allTransactions = new List<Transaction>();
		public BankAccount(string name, decimal initialBalance)
		{
			this.Owner = name;
			//this.Balance = initialBalance;
			MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

			this.Number = accountNumberSeed.ToString();
			accountNumberSeed++;
		}

		public void MakeDeposit(decimal amount, DateTime date, string note)
		{
			if (amount < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
			}
			var deposite = new Transaction(amount, date, note);
			allTransactions.Add(deposite);
		}

		public void MakeWithdrawal(decimal amount, DateTime date, string note)
		{
			if (amount < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
			}
			if (Balance - amount < 0)
			{
				throw new InvalidOperationException("Not sufficient founds for this withdrawal");
			}
			var withdrawal = new Transaction(-amount, date, note);
			allTransactions.Add(withdrawal);
		}

		public string GetAccountHistory()
		{
			var report = new StringBuilder();
			report.AppendLine("Date\t\tAmmont\tNote");
			foreach (var item in allTransactions) 
			{
				report.AppendLine($"{item.Date.ToShortDateString()}\t{item.AmountForHumans}\t{item.Notes}");
			}
			return report.ToString();
		}
	}
}
