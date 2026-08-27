namespace LMSApp.Core;

public static class MenuHelper
{
    public static void PrintMenu()
    {
        Console.WriteLine("========= LMS MAIN MENU =========");
        Console.WriteLine("  1.  Add Student");
        Console.WriteLine("  2.  Add Instructor");
        Console.WriteLine("  3.  Add Course");
        Console.WriteLine("  4.  Enroll Student in Course");
        Console.WriteLine("  5.  Assign Instructor to Course");
        Console.WriteLine("  6.  View All Students");
        Console.WriteLine("  7.  View All Instructors");
        Console.WriteLine("  8.  View All Courses");
        Console.WriteLine("  9.  Send Notification");
        Console.WriteLine("  10. Show System Configuration (Singleton)");
        Console.WriteLine("  11. Exit");
        Console.WriteLine("  --- Bonus ---");
        Console.WriteLine("  12. Delete Student");
        Console.WriteLine("  13. Search Student by ID");
        Console.WriteLine("=================================");
    }
}
