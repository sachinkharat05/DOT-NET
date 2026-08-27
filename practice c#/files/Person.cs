namespace LMSApp.Models;

/// <summary>
/// Abstract base class for all persons in the LMS.
/// Demonstrates Abstraction + Inheritance.
/// </summary>
public abstract class Person
{
    public int    Id   { get; set; }
    public string Name { get; set; }

    protected Person(int id, string name)
    {
        Id   = id;
        Name = name;
    }

    /// <summary>Runtime polymorphism — overridden by each subclass.</summary>
    public abstract void DisplayInfo();
}
