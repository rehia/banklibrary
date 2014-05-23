using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankLibrary;

//using BankLibrary;

namespace BankLibraryFit
{
    public class BankAccountFixture : fit.ColumnFixture
    {
        private BankAccount _account;

        public BankAccountFixture()
            : base()
        {
            _account = new BankAccount("87585", 0.0f);
        }

        public float Balance
        {
            get { return _account.Balance; }
            set { _account.Balance = value; }
        }

        public void Deposit(float amount)
        {
            _account.Deposit(amount);
        }
    }
}
