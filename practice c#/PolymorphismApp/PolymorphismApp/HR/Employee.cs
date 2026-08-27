

namespace HR;
public class Employee
{
      //Class Members-------------static varialbles, shared 
     //Data Members --------------nonstatic variables, instance 
      internal double basic_sal;
      internal double hra;
      internal  double da;

        //Method overloading (function overloading) (static polymorphism)
        public Employee(){
          this.basic_sal=5000;
          this.hra=1200;
          this.da=700;
        } 
        public Employee(double bsal, double hra, double da){
            this.basic_sal=bsal;
            this.hra=hra;
            this.da=da;
        }

 
        //Method overriding (function overriding) (runtime polymorphism)
        public virtual double CalculateSalary()  //virutal function
        {
            return basic_sal + hra+ da *20;
        }
}