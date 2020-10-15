using BankyStuffLibrary;
using System;
using Xunit;

namespace BankingTests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Assert.True(true);
		}

		[Fact]
		public void Test2()
		{
			var account = new BankAccount("Kendra", 10000);

			// Test that the initial balances must be positive.
			Assert.Throws<InvalidOperationException>(
				() => account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw")
			);
		}

		[Fact]
		public void Test3()
		{
			// Test that the initial balances must be positive.
			Assert.Throws<ArgumentOutOfRangeException>(
					() => new BankAccount("invalid", -55)
				);
			
		}
	}
}
