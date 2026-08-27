namespace TestApp;

using TflDrawing;

public class Program
{
    public static void Main(string[] args)
    {
       Shape shape = new Line();
       shape.Draw();

         IPrintable printer=(IPrintable)shape;

            printer.Print();
            printer.Draw(); // This will cause a compile-time error because IPrintable does not have a Draw method

    }

}