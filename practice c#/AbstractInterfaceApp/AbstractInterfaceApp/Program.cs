

namespace TestApp;

using TflDrawing;
public class Program
{
    public static void Main(string [] args)
    {
        Shape theShape= new Line();         // Shape = Reference Variable तयार होतो.     //Heap Memory मध्ये Object तयार होतो.
        theShape.Draw();

        IPrintable printer=(IPrintable)theShape;           //Reference Type Interface आहे.  Compiler फक्त Interface Members पाहतो.

        printer.Print();         // कारण Interface मध्ये Print() आहे.
        printer.Draw();


    }
}