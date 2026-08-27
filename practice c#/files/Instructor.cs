namespace LMSApp.Models;

/// <summary>
/// Derived from Person. Manages assigned courses.
/// </summary>
public class Instructor : Person
{
    public List<Course> AssignedCourses { get; } = new();

    public Instructor(int id, string name) : base(id, name) { }

    public void AssignCourse(Course course)
    {
        if (AssignedCourses.Contains(course))
        {
            Console.WriteLine($"  [!] '{Name}' is already assigned to '{course.CourseName}'.");
            return;
        }
        AssignedCourses.Add(course);
        course.AssignedInstructor = this;
        Console.WriteLine($"  [+] '{Name}' assigned to '{course.CourseName}' successfully.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"  [Instructor] ID: {Id} | Name: {Name}");
        string courses = AssignedCourses.Count > 0
            ? string.Join(", ", AssignedCourses.ConvertAll(c => c.CourseName))
            : "None";
        Console.WriteLine($"               Assigned Courses: {courses}");
    }
}
