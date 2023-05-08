using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Virtual__Overriding__and_New
{
    internal class SavingsAccount : BankAccount
    {
        double _interest;

        public SavingsAccount(string name, double balance, double interest)
            : base(name, balance)
        {
            _interest = interest;
        }

        public double Interest
        {
            get { return _interest; }
            set { _interest = value; }
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += _balance * _interest;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" - {_interest:P}";
        }
    }
}
