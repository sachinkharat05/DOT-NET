

public abstract class Employee
 {  
    public virtual double CalculateSalary();
     {
       return basic +hra + da ;
      }
    
    public abstract double CalculateBonus();
  }


 public  class Manager: Employee
 {   
    public override double CalculateSalary();
    {
      return basic + hra + da + allowances;
    }

    public override double CalaculateBonus ()
    {
       return basic_sal * 0.20;
    }
  }

  static void Main ()
  { 	

    Employee emp=new Manager ();
    double bonus=emp.CalaculateBonus ();
    double Salary=emp.CalculateSalary ();
  }