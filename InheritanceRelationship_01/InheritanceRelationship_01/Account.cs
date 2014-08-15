using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship_01
{
    public class Account
    {
        public Account(string accountNo, string customerName) : this()
        {
            AccountNumber = accountNo;
            CustomerName = customerName;
        }

        public Account()
        {
            Balance = 0;
        }

        public string AccountNumber { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }


        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "withdrawn";
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
