using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount1 = new SavingsAccount("sv-001", "Sami", 4500);
            CheckingAccount checkingAccount1 = new CheckingAccount("chk-001", "Rana", 6500);

            savingsAccount1.Deposit(2000);
            savingsAccount1.Withdraw(1500);

            savingsAccount1.Withdraw(1500);

            Console.WriteLine(savingsAccount1.Balance);

            checkingAccount1.Deposit(3000);
            checkingAccount1.Withdraw(1000);
            checkingAccount1.Withdraw(4000);

            int no = checkingAccount1.NoOfTransactions;

            Console.WriteLine(checkingAccount1.Balance);

            Console.ReadKey();
        
        }
    }
}
