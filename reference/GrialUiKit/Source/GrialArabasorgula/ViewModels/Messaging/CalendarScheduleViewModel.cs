/* [grial-metadata] id: Grial#CalendarScheduleViewModel.cs version: 1.0.5 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class CalendarScheduleViewModel : ObservableObject
    {
        private DateTime _selectedDate;

        public CalendarScheduleViewModel()
            : base(listenCultureChanges: true)
        {
            SelectedDate = DateTime.Now.Date;

            LoadData();
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                if (SetProperty(ref _selectedDate, value))
                {
                    UpdateEventsDate();
                };
            }
        }

        public ObservableCollection<DailyEventData> EventList { get; } = new ObservableCollection<DailyEventData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            EventList.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Messages.json");

            UpdateEventsDate();
        }

        private void UpdateEventsDate()
        {
            var date = SelectedDate.ToString("dddd d");
            foreach (var item in EventList)
            {
                item.Date = date;
            }
        }
    }
}