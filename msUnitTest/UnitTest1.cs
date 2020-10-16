using BankyStuffLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace msUnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestOverdraw()
		{
			var account = new BankAccount("Kendra", 10000);

			// Test that the initial balances must be positive.
			Assert.ThrowsException<InvalidOperationException>(
				() => account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw")
			);
		}
	}
}
