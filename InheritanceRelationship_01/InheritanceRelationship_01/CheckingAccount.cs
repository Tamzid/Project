using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship_01
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string accountNo, string customerName, double serviceCharge): base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public double ServiceCharge { set; get; }
        public int NoOfTransactions { private set; get; }
    }
}
