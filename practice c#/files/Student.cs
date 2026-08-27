namespace LMSApp.Models;

/// <summary>
/// Derived from Person. Manages enrolled courses.
/// </summary>
public class Student : Person
{
    public List<Course> EnrolledCourses { get; } = new();

    public Student(int id, string name) : base(id, name) { }

    public void EnrollCourse(Course course)
    {
        if (EnrolledCourses.Contains(course))
        {
            Console.WriteLine($"  [!] '{Name}' is already enrolled in '{course.CourseName}'.");
            return;
        }
        EnrolledCourses.Add(course);
        Console.WriteLine($"  [+] '{Name}' enrolled in '{course.CourseName}' successfully.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"  [Student] ID: {Id} | Name: {Name}");
        string courses = EnrolledCourses.Count > 0
            ? string.Join(", ", EnrolledCourses.ConvertAll(c => c.CourseName))
            : "None";
        Console.WriteLine($"            Enrolled Courses: {courses}");
    }
}
