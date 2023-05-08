using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Virtual__Overriding__and_New
{
    internal class RetriementAccount : SavingsAccount
    {
        public RetriementAccount(string name, double balance, double interest) : base(name, balance, interest)
        {
        }

        public override bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
        }
    }
}
