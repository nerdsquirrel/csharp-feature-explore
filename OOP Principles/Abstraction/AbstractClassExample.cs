namespace CSharpFeatureExplore.OOP_Principles.Abstraction
{
    public abstract class NotificationService
    {
        public required string SenderName { get; set; }

        public void Notify(string recipient, string message)
        {
            var formatted = FormatMessage(message);
            Send(recipient, formatted);
        }

        protected abstract void Send(string recipient, string message);
        protected virtual string FormatMessage(string message) => $"[INFO]: {message}";
    }

    public class EmailNotificationService : NotificationService
    {
        protected override void Send(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }
    }

}
