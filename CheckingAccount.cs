using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class CheckingAccount : Account
    {
       public CheckingAccount(string name = "Unnamed Account", double balance = 0.00 ):base(name,balance)
        {

        }
        public CheckingAccount(string name) : base(name)
        {

        }

        public CheckingAccount()
        {

        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + 1.50);
        }
    }
}
