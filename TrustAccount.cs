using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    class TrustAccount : SavingAccount
    {
        public TrustAccount(string name = "Unnamed Account", double balance = 0.00, double interstRate = 0.00):base(name, balance,interstRate)
        {

        }
       

        public override bool Deposit(double amount)
        {
            if (amount>0||amount>=5000)
            {
                return base.Deposit(amount + 50);
            }

            return base.Deposit(amount);
            
        }

        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance * .2)  
            {
                return base.Withdraw(amount);
            }

            return false;
        }
    }
}
