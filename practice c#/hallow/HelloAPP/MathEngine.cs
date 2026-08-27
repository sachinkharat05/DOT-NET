namespace Maths;
public class MathEngine
{

    public static int count;

    public MathEngine()
    {
        count++;
    }
    //NonStatic functions
    public double Add(double a, double b)
    {
        return a + b;
    }
    
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        
        return a / b;
    }


    ~MathEngine()
    {
        if (count > 0)
        count--;
    }

    //constructor: a special method that is called when an object is created. 
                    // It is used to initialize the object.
    //destructor: a special method that is called when an object is destroyed. 
                    //It is used to clean up any resources that the object is using.
}