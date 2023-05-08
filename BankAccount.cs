using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Virtual__Overriding__and_New
{
    internal abstract class BankAccount
    {
        
        string _name;
        int _accountNumber;
        protected double _balance;
        static Random _accountNumberGenerator = new Random();
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        
         public BankAccount(string name, double balance) 
        {
            _name = name;
            _balance = balance;
            _accountNumber = _accountNumberGenerator.Next(100000, 999999);
        }

        public abstract bool Deposit(double amount);

        public abstract bool Withdraw(double amount);

        public override string ToString()
        {
            return $"{this.GetType().Name} - {_name} - {_accountNumber} - {_balance:C}";
        }
    }
}

 





    
