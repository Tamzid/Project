namespace InheritanceRelationship_01
{
    public class SavingsAccount : Account
    {
        public double InterestAmount { get; set; }
        public SavingsAccount(string accountNo, string customerName, double  interestAmount) : base(accountNo, customerName)
        {
            this.InterestAmount = interestAmount;
        }

        public override string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                   return base.Withdraw(amount);
            }
            else
            {
                return "Insuffieient balance";
            }
        }
    }
}