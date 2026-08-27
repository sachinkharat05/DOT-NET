// Inheritance allows one class to acquire the properties and methods of another class.
class Account
{
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");

    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {Balance}");

        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}

// Child Class
class SavingsAccount : Account
{
    public decimal InterestRate { get; set; } = 0.05m; // 5% interest rate

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;

        Console.WriteLine($"Interest applied. New Balance: {Balance}");
    }
}


