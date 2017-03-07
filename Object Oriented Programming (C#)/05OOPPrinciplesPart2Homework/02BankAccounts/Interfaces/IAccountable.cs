namespace _02BankAccounts
{
    public interface IAccountable
    {
        CustomerType CustomerType { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }
    }
}
