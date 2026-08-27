namespace HR;

public class SalesManager : Manager
{
    private double target;
    private double bonus;

    public SalesManager()
    {
        this.target=0;
        this.bonus=0;
    }

    public SalesManager(double bsal,double hra, double da, double incentive, double target, double bonus):base(bsal,hra,da,incentive)
    {
        this.target=target;
        this.bonus=bonus;
    }

    public override double CalculateSalary()
    {
       double  salary=base.CalculateSalary();
       if(this.target > 900000)
        {
            salary=salary+bonus;
        }
        return salary;
    }
}