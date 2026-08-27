
namespace HR;
public  class Manager : Employee
{
    private double incentive;

    public Manager()
    {
        this.incentive=0;
    }
     public Manager(double sal, double hra, double da, double incentive):base(sal,hra,da)
    {
        this.incentive=incentive;
    }

    public override   double CalculateSalary()
    {    
        return  base.CalculateSalary() + incentive;
    }
}