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
        int CuurentYear = 0 ;
        int NumberOfWithDraws = 0;
        public TrustAccount(string name = "Unnamed Account", double balance = 0.00, double interstRate = 0.00):base(name, balance,interstRate)
        {
            CuurentYear = DateTime.Now.Year;
        }

       
       


        public override bool Deposit(double amount)
        {
            if (amount>0&&amount>=5000)
            {
                return base.Deposit(amount + 50);
            }

            return base.Deposit(amount);
            
        }

        public override bool Withdraw(double amount)
        {


            if (DateTime.Now.Year > CuurentYear)
            {
                NumberOfWithDraws = 0;
                CuurentYear = DateTime.Now.Year;
            }
            if ( NumberOfWithDraws >= 3)
            {
                return false;
            }
            if (amount > 0 && amount <= Balance * .2 && Balance >= amount) 
            {
                NumberOfWithDraws++;
                return base.Withdraw(amount);
            }


            return false;
        }
    }
}
