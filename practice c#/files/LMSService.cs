using LMSApp.Interfaces;
using LMSApp.Models;
using LMSApp.Notifications;

namespace LMSApp.Services;

/// <summary>
/// Central service layer — keeps all business logic out of Program.cs.
/// </summary>
public class LMSService
{
    private readonly List<Student>    _students    = new();
    private readonly List<Instructor> _instructors = new();
    private readonly List<Course>     _courses     = new();
    private readonly List<Person>     _persons     = new();   // runtime polymorphism

    private int _studentIdCounter    = 1;
    private int _instructorIdCounter = 1;
    private int _courseIdCounter     = 1;

    // ── 1. Add Student ───────────────────────────────────────
    public void AddStudent()
    {
        Console.Write("\n  Enter Student Name: ");
        string name = Console.ReadLine()?.Trim() ?? "";
        if (string.IsNullOrEmpty(name)) { Console.WriteLine("  [!] Name cannot be empty."); return; }

        var s = new Student(_studentIdCounter++, name);
        _students.Add(s);
        _persons.Add(s);
        Console.WriteLine($"  [+] Student '{name}' added with ID {s.Id}.");
    }

    // ── 2. Add Instructor ────────────────────────────────────
    public void AddInstructor()
    {
        Console.Write("\n  Enter Instructor Name: ");
        string name = Console.ReadLine()?.Trim() ?? "";
        if (string.IsNullOrEmpty(name)) { Console.WriteLine("  [!] Name cannot be empty."); return; }

        var inst = new Instructor(_instructorIdCounter++, name);
        _instructors.Add(inst);
        _persons.Add(inst);
        Console.WriteLine($"  [+] Instructor '{name}' added with ID {inst.Id}.");
    }

    // ── 3. Add Course (overloaded constructors = compile-time poly) ──
    public void AddCourse()
    {
        Console.Write("\n  Enter Course Name: ");
        string name = Console.ReadLine()?.Trim() ?? "";
        if (string.IsNullOrEmpty(name)) { Console.WriteLine("  [!] Name cannot be empty."); return; }

        Console.Write("  Enter Duration in hours (0 to skip): ");
        if (!int.TryParse(Console.ReadLine(), out int dur) || dur < 0) dur = 0;

        Course course = dur > 0
            ? new Course(_courseIdCounter++, name, dur)
            : new Course(_courseIdCounter++, name);

        _courses.Add(course);
        Console.WriteLine($"  [+] Course '{name}' added with ID {course.CourseId}.");
    }

    // ── 4. Enroll Student in Course ──────────────────────────
    public void EnrollStudentInCourse()
    {
        if (!EnsureExists(_students, "students") || !EnsureExists(_courses, "courses")) return;

        var student = PickFromList(_students, "Select Student", s => $"[{s.Id}] {s.Name}");
        if (student == null) return;

        var course = PickFromList(_courses, "Select Course", c => $"[{c.CourseId}] {c.CourseName}");
        if (course == null) return;

        student.EnrollCourse(course);
    }

    // ── 5. Assign Instructor to Course ───────────────────────
    public void AssignInstructorToCourse()
    {
        if (!EnsureExists(_instructors, "instructors") || !EnsureExists(_courses, "courses")) return;

        var inst = PickFromList(_instructors, "Select Instructor", i => $"[{i.Id}] {i.Name}");
        if (inst == null) return;

        var course = PickFromList(_courses, "Select Course", c => $"[{c.CourseId}] {c.CourseName}");
        if (course == null) return;

        inst.AssignCourse(course);
    }

    // ── 6. View All Students (runtime polymorphism) ──────────
    public void ViewAllStudents()
    {
        Console.WriteLine("\n====== All Students ======");
        if (_students.Count == 0) { Console.WriteLine("  No students found."); return; }
        foreach (Person p in _persons)
            if (p is Student) p.DisplayInfo();   // runtime dispatch
    }

    // ── 7. View All Instructors (runtime polymorphism) ───────
    public void ViewAllInstructors()
    {
        Console.WriteLine("\n====== All Instructors ======");
        if (_instructors.Count == 0) { Console.WriteLine("  No instructors found."); return; }
        foreach (Person p in _persons)
            if (p is Instructor) p.DisplayInfo(); // runtime dispatch
    }

    // ── 8. View All Courses ──────────────────────────────────
    public void ViewAllCourses()
    {
        Console.WriteLine("\n====== All Courses ======");
        if (_courses.Count == 0) { Console.WriteLine("  No courses found."); return; }
        foreach (var c in _courses) c.DisplayInfo();
    }

    // ── 9. Send Notification (interface / loose coupling) ────
    public void SendNotification()
    {
        Console.WriteLine("\n  Select Notification Type:");
        Console.WriteLine("    1. Email");
        Console.WriteLine("    2. SMS");
        Console.Write("  Choice: ");

        INotificationService service;   // interface reference
        switch (Console.ReadLine()?.Trim())
        {
            case "1": service = new EmailNotificationService(); break;
            case "2": service = new SmsNotificationService();   break;
            default:  Console.WriteLine("  [!] Invalid choice."); return;
        }

        Console.Write("  Enter Message: ");
        string msg = Console.ReadLine()?.Trim() ?? "";
        if (string.IsNullOrEmpty(msg)) { Console.WriteLine("  [!] Message cannot be empty."); return; }

        service.SendNotification(msg);
    }

    // ── Bonus: Delete Student ────────────────────────────────
    public void DeleteStudent()
    {
        if (!EnsureExists(_students, "students")) return;
        var s = PickFromList(_students, "Select Student to Delete", st => $"[{st.Id}] {st.Name}");
        if (s == null) return;
        _students.Remove(s);
        _persons.Remove(s);
        Console.WriteLine($"  [-] Student '{s.Name}' removed.");
    }

    // ── Bonus: Search Student by ID ──────────────────────────
    public void SearchStudentById()
    {
        Console.Write("\n  Enter Student ID to search: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("  [!] Invalid ID."); return; }
        var found = _students.Find(s => s.Id == id);
        if (found == null) Console.WriteLine("  [!] Student not found.");
        else { Console.WriteLine("\n  Found:"); found.DisplayInfo(); }
    }

    // ── Private Helpers ──────────────────────────────────────
    private static bool EnsureExists<T>(List<T> list, string label)
    {
        if (list.Count == 0)
        {
            Console.WriteLine($"  [!] No {label} available. Please add some first.");
            return false;
        }
        return true;
    }

    private static T? PickFromList<T>(List<T> list, string title, Func<T, string> display)
    {
        Console.WriteLine($"\n  {title}:");
        for (int i = 0; i < list.Count; i++)
            Console.WriteLine($"    {i + 1}. {display(list[i])}");
        Console.Write("  Enter number: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > list.Count)
        {
            Console.WriteLine("  [!] Invalid selection.");
            return default;
        }
        return list[choice - 1];
    }
}
