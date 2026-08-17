/* [grial-metadata] id: Grial#MessagesData.cs version: 1.1.5 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class ChatMessageData
    {
        public ChatUserData From { get; set; }
        public string Body { get; set; }
        public string When { get; set; }
        public bool IsRead { get; set; }
        public bool IsInbound { get; set; }
    }

    public class ChatUserData
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
    }

    public class MessageData
    {
        public ChatUserData From { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool HasAttachment { get; set; }
        public int ThreadCount { get; set; }
        public string When { get; set; }
        public bool IsStared { get; set; }
        public bool IsRead { get; set; }
    }

    public class NotificationData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public NotificationType Type { get; set; }
    }

    public class DailyEventData : ObservableObject
    {
        private string _date;

        public string Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public string Time { get; set; }
        public string Activity { get; set; }
        public string Icon { get; set; }
        public string BackgroundColor { get; set; }
    }
}
