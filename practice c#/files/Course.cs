namespace LMSApp.Models;

/// <summary>
/// Represents a course in the LMS.
/// Demonstrates compile-time polymorphism via constructor overloading.
/// </summary>
public class Course
{
    public int         CourseId           { get; set; }
    public string      CourseName         { get; set; }
    public int         Duration           { get; set; }   // hours
    public Instructor? AssignedInstructor { get; set; }

    // Compile-time polymorphism — overloaded constructors
    public Course(int id, string name)
    {
        CourseId   = id;
        CourseName = name;
        Duration   = 100;
    }

    public Course(int id, string name, int duration)
    {
        CourseId   = id;
        CourseName = name;
        Duration   = duration;
    }

    public void DisplayInfo()
    {
        string instructor = AssignedInstructor?.Name ?? "Not Assigned";
        Console.WriteLine($"  [Course] ID: {CourseId} | Name: {CourseName} | Duration: {Duration}h | Instructor: {instructor}");
    }
}
