using com.Transflower.Types;
using com.Transflower.Types.HR;
namespace TypesDemoApp{
    public class Program{
        public static void Main(string[] args){
            Point p = new Point(10, 20);
            Location l = new Location(77.5937, 12.9716);

            Person person = new Person("John Doe", 30);


            System.Console.WriteLine($"Point: ({p.x}, {p.y})");
            System.Console.WriteLine($"Location: (Longitude: {l.longitude}, Latitude: {l.latitude})");
            System.Console.WriteLine($"Person: {person.Name}, Age: {person.Age}");
       
            Employee emp = new Employee("Bhau kadam", 39, "Software Engineer");   
    

            IWorker worker = emp; // Polymorphism
            worker.Work();
            IPresenter presenter=emp; // Polymorphism
            presenter.Present();


            Consultant consultant = new Consultant("Ravi Tambade", 51, 25);
            worker = consultant; // Polymorphism
            worker.Work();
            presenter = consultant; // Polymorphism
            presenter.Present();
        }
    }
}