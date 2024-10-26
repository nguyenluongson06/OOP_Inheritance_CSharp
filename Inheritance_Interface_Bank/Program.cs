namespace Inheritance_Interface_Bank;

class Program
{
    static void Main(string[] args)
    {
        var saving = new SavingAccount(10000);
        var credit = new CreditAccount(20000);
        Console.WriteLine($"Saving account balance: {saving.GetAmount()}; Credit account balance: {credit.GetAmount()}");
        Console.WriteLine("Adding 8000 to saving account");
        saving.SetSavingAccount(8000);
        Console.WriteLine($"Current saving account balance: {saving.GetAmount()}");
        Console.WriteLine("Deducting 5000 from credit account");
        credit.CreditAmount(5000);
        Console.WriteLine($"Current credit account balance: {credit.GetAmount()}");
        Console.WriteLine("Deducting 30000 from credit account");
        credit.CreditAmount(30000);
        Console.WriteLine($"Current credit account balance: {credit.GetAmount()}");
    }
}