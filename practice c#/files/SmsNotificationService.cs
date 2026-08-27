using LMSApp.Interfaces;

namespace LMSApp.Notifications;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("\n  [SMS] Notification sent via SMS:");
        Console.WriteLine($"  > {message}");
    }
}
