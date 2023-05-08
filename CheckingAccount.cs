using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Virtual__Overriding__and_New
{
    internal class CheckingAccount : BankAccount
    {
         double _overdraftFee;

        public CheckingAccount(string name, double balance, double overdraftFee)
            : base(name, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public double OverdraftFee
        {
            get { return _overdraftFee; }
            set { _overdraftFee = value; }
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
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
            else if (amount < 0)
            {
                return false;
            }
            else
            {
                _balance -= _overdraftFee;
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" - {_overdraftFee:C}";
        }
    }
}


