namespace Inheritance_Interface_Bank;

public class SavingAccount : IBank, ISavingAccount
{
    public SavingAccount(float balance)
    {
        Balance = balance;
    }

    private float Balance { get; set; }
    public float GetAmount()
    {
        return Balance;
    }

    public void SetSavingAccount(float amount)
    {
        Balance += amount;
    }
}