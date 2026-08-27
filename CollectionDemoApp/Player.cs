namespace WorldCup;

public class Players
{
    

       public Players(int playerId,string name,int jerseyNumber,string position,int age,string nationality,decimal salary)
   { 

        PlayerId = playerId;
        Name = name;
        JerseyNumber = jerseyNumber;
        Position = position;
        Age = age;
        Nationality = nationality;
        Salary = salary;
   }
    public int PlayerId {get;set;}
    public string Name {get;set;}
    public int JerseyNumber {get;set;}
    public string Position {get;set;}
    public int Age {get;set;}
    public string Nationality {get;set;}
    public decimal Salary {get;set;}
}
   
        

   