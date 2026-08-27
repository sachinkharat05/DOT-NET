// Base class
class Account
{
    public decimal Balance { get; set; }

    // Virtual method can be overridden
    public virtual void ProcessTransaction(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Generic account: Deposited {amount}. Balance: {Balance}");
    }
}

// Derived class 1
class SavingAccount : Account
{
    public decimal InterestRate { get; set; } = 0.05m;

    public override void ProcessTransaction(decimal amount)
    {
        Balance += amount;
        Balance += Balance * InterestRate; // Apply interest
        Console.WriteLine($"Saving Account: Deposited {amount} + interest. Balance: {Balance}");
    }
}

// Derived class 2
class CurrentAccount : Account
{
    public override void ProcessTransaction(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Current Account: Deposited {amount}. Balance: {Balance}");
    }
}