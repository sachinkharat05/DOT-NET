using LMSApp.Core;
using LMSApp.Services;

namespace LMSApp;

class Program
{
    static void Main(string[] args)
    {
        var lms = new LMSService();

        Console.WriteLine("\n  Welcome to the LMS Console Application");
        Console.WriteLine($"  Powered by {LMSConfigurationManager.Instance.InstituteName}\n");

        while (true)
        {
            MenuHelper.PrintMenu();
            Console.Write("  Your choice: ");
            string input = Console.ReadLine()?.Trim() ?? "";

            Console.WriteLine();
            try
            {
                switch (input)
                {
                    case "1":  lms.AddStudent();               break;
                    case "2":  lms.AddInstructor();            break;
                    case "3":  lms.AddCourse();                break;
                    case "4":  lms.EnrollStudentInCourse();    break;
                    case "5":  lms.AssignInstructorToCourse(); break;
                    case "6":  lms.ViewAllStudents();          break;
                    case "7":  lms.ViewAllInstructors();       break;
                    case "8":  lms.ViewAllCourses();           break;
                    case "9":  lms.SendNotification();         break;
                    case "10": LMSConfigurationManager.Instance.DisplayConfig(); break;
                    case "11":
                        Console.WriteLine("  Goodbye! Exiting LMS...");
                        return;
                    case "12": lms.DeleteStudent();            break;
                    case "13": lms.SearchStudentById();        break;
                    default:
                        Console.WriteLine("  [!] Invalid option. Please choose between 1–13.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  [ERROR] {ex.Message}");
            }

            Console.WriteLine();
        }
    }
}
