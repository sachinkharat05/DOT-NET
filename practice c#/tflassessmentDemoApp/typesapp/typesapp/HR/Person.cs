namespace com.Transflower.Types.HR
{
    public class Person
    {
        //Auto ropetry
       
       public string Name { get; set; }
       public int Age { get; set; }

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        ~Person()
        {
            System.Console.WriteLine($"Person {Name} is being destroyed.");
        }
    }
}