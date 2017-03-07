using System;


namespace _02BankAccounts
{
    class StartMeFromHere
    {
        static void Main()
        {

            var accounts = Bank.GetAccountData();
            Console.WriteLine("Calculating interest amount of bank accounts! \n" + new string('-', 60));
            foreach (var account in accounts)
            {
                account.CalculateInterest(13);
            }
            Console.WriteLine("\nBank account actions(deposit/withdraw money)! \n" + new string('-', 60));
            Bank.DepositAccountActions();
            Bank.LoanAccountActions();
            Bank.MortgageAccountActions();
        }
    }
}
