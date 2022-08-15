namespace DesignPattern.Models
{
    public class NotificationInputModel
    {
        public string Destination { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
    }
}
