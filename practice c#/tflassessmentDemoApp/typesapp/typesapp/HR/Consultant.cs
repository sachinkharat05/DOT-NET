namespace com.Transflower.Types.HR
{
   public class Consultant : Person, IWorker, IPresenter
    {
        public int ExperienceYears { get; set; }
        public Consultant(string n, int a, int exp) : base(n, a)
        {
            ExperienceYears = exp;
        }

        public void Work()
        {
            System.Console.WriteLine($"{Name} is working as a consultant.");
        }

        public void Present()
        {
            System.Console.WriteLine($"{Name} is presenting a report.");
        }
    }
}