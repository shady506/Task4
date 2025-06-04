using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class SavingAccount : Account
    {
        public SavingAccount(string name = "Unnamed Account", double balance =0.00 ,double interstRate = 0.00):base(name,balance)
        {
            InterstRate = interstRate;
        }
       
       

        public double InterstRate { get; set; }



    }
}
