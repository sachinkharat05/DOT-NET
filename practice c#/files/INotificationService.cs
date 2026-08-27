namespace LMSApp.Interfaces;

/// <summary>
/// Loose coupling contract for all notification services.
/// </summary>
public interface INotificationService
{
    void SendNotification(string message);
}
