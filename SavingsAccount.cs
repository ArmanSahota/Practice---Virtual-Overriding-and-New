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
            if (base.Deposit(amount))
            {
                _balance += _balance * _interest;
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
