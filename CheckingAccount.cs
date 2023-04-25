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

        public override bool Withdraw(double amount)
        {
            if (base.Withdraw(amount))
            {
                return true;
            }
            else
            {
                if (_balance < 0)
                {
                    _balance -= _overdraftFee;
                }
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" - {_overdraftFee:C}";
        }
    }
}

