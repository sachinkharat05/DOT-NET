namespace TFLCollections;
using WorldCup;

public class Program
{

    public static void Main(string[] args)

    {

        int[] goals = new int[] { 4, 6, 8, 1, 3, 0 };
        int curreentMatchGoals = goals[2];
        //Team Argentina = new Team();
        Team Mexico = new Team();

        string playerName = Mexico[1].Name;
        Mexico[1].Name = "Julian Alvarez";
        playerName = Mexico[1].Name;




        Console.WriteLine( "Player ="+ playerName);



        }

    }
