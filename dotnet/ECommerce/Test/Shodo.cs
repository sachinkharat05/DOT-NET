// base class che data member hide karne

//Shadowing (Method Hiding) means a child class hides a member (method, property, or field)
//  of the parent class by using the new keyword.
class Employee
{
  public virtual double CalculateSalary ()
     {return basic_sal;}
  }
}

class SalesEmployee:Employee
{ 
  double sales, comm;
  public new double CalculateSalary ()
  {
    return basic_sal+ (sales * comm);
  }
}

static void Main ()
{ 
  SalesEmployee sper= new SalesEmployee ();
  Double salary= sper.CalculateSalary ();
  Console.WriteLine (salary);
}