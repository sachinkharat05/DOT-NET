//Console.WriteLine("Hello, World!");



//exe console applicaiton for testing purpose
//dotnet new console -o HelloApp
public class Program
{
 
    public static  void  Display()
    {
        Console.WriteLine("Hello, World!");
    }

    public static void Main(string[] args)
    {
        Display();
        Console.ReadKey();
    }
}

//Dotnet CLI commands

//dotnet new console -o HelloApp
//dotnet new classlib -o HelloLib
//dotnet build
//dotnet run
//dotnet restore
//dotnet add package mysql.data
//dotnet publish -c Release -r win-x64 --self-contained true



//Windowds executable file: .exe
//Reusable modules on windows platform: .dll

//DLL: Dynamic Link Library

//static  and non-static methods
    //static methods are shared

    //inbuilt types

    //int, bool, double, char, decimal
    //enum
    
    //User defined types
    //class, interface, struct, record,
    //event, delegate