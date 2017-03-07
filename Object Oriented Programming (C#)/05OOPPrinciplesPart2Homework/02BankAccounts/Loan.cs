using System;


namespace _02BankAccounts
{
    public class Loan : Account, IDepositable
    {
        public Loan(CustomerType customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {

        }

        public override void CalculateInterest(int numOfMonths)
        {
            decimal interestAmmount = 0.00M;

            if (this.CustomerType == CustomerType.individual && numOfMonths > 3) //Number of months should be greater than 3
            {
                interestAmmount = (numOfMonths - 3) * (this.InterestRate / 100);
            }
            else if (this.CustomerType == CustomerType.company && numOfMonths > 2) //Number of months should be greater than 2
            {
                interestAmmount = (numOfMonths - 2) * (this.InterestRate / 100);
            }

            Console.WriteLine("Interest amount: {0} - For period of: {1} months - Initial balance: {2} ", interestAmmount, numOfMonths, this.Balance);
        }

        //When depositing money to a Loan account the deposited money are withdrawn from the loan you have to pay off :)

        public void DepositMoney(decimal moneyToDeposit)
        {
            this.Balance -= moneyToDeposit;
            Console.WriteLine("${0} paid off to your loan account! - Remaining to pay off: {1}", moneyToDeposit, this.Balance);
        }
    }
}
