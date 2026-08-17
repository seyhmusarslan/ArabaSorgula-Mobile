/* [grial-metadata] id: Grial#NotificationsViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NotificationsViewModel : ObservableObject
    {
        public NotificationsViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<NotificationData> Notifications { get; } = new ObservableCollection<NotificationData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Notifications.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Messages.json");
        }
    }
}