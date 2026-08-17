/* [grial-metadata] id: Grial#TimelineViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class TimelineViewModel : ObservableObject
    {
        public TimelineViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<TimelineEventData> TimelineList { get; } = new ObservableCollection<TimelineEventData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            TimelineList.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Social.json");
        }
    }
}
