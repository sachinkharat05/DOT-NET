namespace Banking;
// Parent class
class Account
{
    public static  int count;

    private decimal balance;   //encapsulation
    public decimal Balance {  //expose using public property

        get
        {
            return this.balance;    
        }
        set
        {
            if(value <=5000)
            {
                this.balance=value;
            }
            else
            {
                throw new ArgumentException("Balance should be greater than 5000");
            }
        }
    }

    public Account()
    {
        this.balance=0;
        count++;
    }
    public Account(decimal amount)
    {
        this.balance=amount;
        count++;
    }
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}

// Child class
class SavingAccount : Account
{
    public static  new  int  count; //shadowing  variable
    public decimal InterestRate { get; set; } = 0.05m;
    public SavingAccount()
    {
        count++;
    }
    public SavingAccount(decimal amount, decimal intRate)
    {
        this.Balance=amount;
        this.InterestRate=intRate;
        count++;
    }
    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
        Console.WriteLine($"Interest applied. New Balance: {Balance}");
    }
}