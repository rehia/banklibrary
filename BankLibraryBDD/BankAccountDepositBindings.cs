using BankLibrary;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLibraryBDD
{
    [Binding]
    public class BankAccountDepositBindings
    {
        private string _accountNumber;
        private BankAccount _bankAccount;

        [Given(@"J'ai un compte de numéro (.*)")]
        public void GivenJAiUnCompteDeNumero012345(string accountNumber)
        {
            _accountNumber = accountNumber;
        }

        [Given(@"Le solde de mon compte est de (.*) dollars?")]
        [Given(@"J'ai un solde de (.*) dollars")]
        public void GivenLeSoldeDeMonCompteEstDe5Dollars(float initialBalance)
        {
            _bankAccount = new BankAccount(_accountNumber, initialBalance);
        }

        [When(@"Je dépose (.*) dollars?")]
        [When(@"Je veux déposer (.*) dollars? sur le compte")]
        [When(@"Je dépos (.*) dollar")]
        public void WhenJeDeposDollar(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        public void WhenJeDepose1Dollar(float amount)
        {
            _bankAccount.Deposit(amount);
        }

        [Then(@"Le solde de mon compte est de (.*) dollars?")]
        public void ThenLeSoldeDeMonCompteEstDe6Dollars(float expectedAmount)
        {
            Assert.AreEqual(expectedAmount, _bankAccount.Balance);
        }
    }
}
