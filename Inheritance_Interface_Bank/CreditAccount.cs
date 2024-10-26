namespace Inheritance_Interface_Bank;

public class CreditAccount : IBank, ICreditAccount
{
    public CreditAccount(float balance)
    {
        Balance = balance;
    }

    private float Balance { get; set; }
    public float GetAmount()
    {
        return Balance;
    }

    public void CreditAmount(float amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Not enough balance");
        }
    }
}