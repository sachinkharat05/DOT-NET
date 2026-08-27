using LMSApp.Interfaces;

namespace LMSApp.Notifications;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("\n  [EMAIL] Notification sent via Email:");
        Console.WriteLine($"  > {message}");
    }
}
