namespace com.Transflower.Types.HR
{
     
     public class Employee : Person, IWorker, IPresenter
    {
        public string Position { get; set; }

        public Employee(string n, int a, string p) : base(n, a)
        {
            Position = p;
        }

        public void Work()
        {
            System.Console.WriteLine($"{Name} is working as a {Position}.");
        }

        public void Present()
        {
            System.Console.WriteLine($"Hello, I am {Name}, a {Position}.");
        }
    }
}