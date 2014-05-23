using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLibrary;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankLibraryTests
{
	[TestFixture]
	public class BankAccountBehaviour
	{
	    private BankAccount _account;

        [SetUp]
        public void SetUp()
        {
            _account = new BankAccount("65377", 0.0f);
            
        }

	    [Test]
	    public void ShouldBalanceBe1DollarWhenDeposit1Dollar()
	    {

	        _account.Deposit(1.0f);

            Assert.That(_account.Balance, Is.EqualTo(1.0f));
	    }

        [Test]
        public void ShouldBalanceBe9DollarWhenDeposit3DollarAnd6Dollar()
        {
            _account.Deposit(3.0f);
            _account.Deposit(6.0f);

            Assert.That(_account.Balance, Is.EqualTo(9.0f));
        }
    }
}

