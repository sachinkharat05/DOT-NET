namespace TflDrawing;


//Multiple interface inheritance

public class Line: Shape,IPrintable,IScannable
{
    
    public  void Draw()
    {
        Console.WriteLine("Drawing line");

    }
    public void Display()
    {
         Console.WriteLine("Displaying line");
        
    }

      public void Print()
    {
         Console.WriteLine("Printing line");
        
    }

    public void Scan()
    {
         Console.WriteLine("Scanning line");
    }
}