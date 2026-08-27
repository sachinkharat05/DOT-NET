namespace WorldCup;

 public class Team
 {

private Players[] players = new Players[11];

public Team()
{

    players [0] = new Players(1, "Lionel Messi",33,  "Forward", 38, "Argentina", 5000000);
    players [1] = new Players(2, "Julian Alvarez", 9, "Forward", 26, "Mexico", 3000000);
    players [2] = new Players(3, "Lautaro Martinez", 22, "Striker", 28, "Argentina", 4000000);
    players [3] = new Players(4, "Enzo Fernandez", 24, "Midfielder", 24, "Argentina", 3500000);
    players [4] = new Players(5, "Rodrigo De Paul", 7, "Midfielder", 31, "Argentina", 4500000);
    players [5] = new Players(6, "Cristian Romero", 13, "Defender", 28, "Argentina", 4000000);
    players [6] = new Players(7, "Nicolas Otamendi", 19, "Defender", 38, "Argentina", 4000000);
    players [7] = new Players(8, "Nahuel Molina", 16, "Right Back", 28, "Argentina", 3500000);
    players [8] = new Players(9, "Alexis Mac Allister", 20, "Midfielder", 27, "Argentina", 3500000);
    players [9] = new Players(10, "Angel Di Maria", 11, "Winger", 38, "Argentina", 4500000);
    players [10] = new Players(11, "Emiliano Martinez", 23, "Goalkeeper", 33, "Argentina", 5000000);

}
  public Players this[int index]
    {
        get
        {
            return players[index];
        }
        set
        {
            players[index] = value;
        }
    }
    public void DisplayPlayers()
    {
        foreach (Players theplayer in players)
        {
            Console.WriteLine(theplayer.Name);
        }
        
    }

        
}



