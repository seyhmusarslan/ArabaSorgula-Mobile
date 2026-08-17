/* [grial-metadata] id: Grial#SmartHomeSchedulePopupViewModel.cs version: 2.0.4 */
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
	public class SmartHomeSchedulePopupViewModel : ObservableObject
	{
        private string _when;
        private TimeSpan _from;
        private TimeSpan _to;
        private ObservableCollection<string> _days;

        public SmartHomeSchedulePopupViewModel(Schedule item)
        {
            FrequencyMulti = new List<string>()
            {
                "Daily", "Workdays", "Weekends"
            };

            FrequencySingle = new List<string>()
            {
                "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su"
            };

            if (item == null)
            {
                From = TimeSpan.FromHours(DateTime.Now.Hour);
                To = TimeSpan.FromHours(DateTime.Now.AddHours(4).Hour);
                Days = new ObservableCollection<string>();
            }
            else
            {
                TimeSpan.TryParse(item.From, out TimeSpan From);
                TimeSpan.TryParse(item.To, out TimeSpan To);
                When = item.When;
                Days = item.Days == null ? new ObservableCollection<string>() : new ObservableCollection<string>(item.Days);
            }

            Days.CollectionChanged += OnDaysCollectionChanged;
        }

        public ICommand SaveCommand { get; protected set; }

        public List<string> FrequencyMulti { get; } 

        public List<string> FrequencySingle { get; }

        public string When
        {
            get => _when;
            set
            {
                if (value != null && Days != null && Days.Count > 0)
                {
                    Days.Clear();
                }

                if (SetProperty(ref _when, value))
                {
                    if (SaveCommand is Command cmd)
                    {
                        cmd?.ChangeCanExecute();
                    }
                }
            }
        }

        public TimeSpan From
        {
            get => _from;
            set => SetProperty(ref _from, value);
        }

        public TimeSpan To
        {
            get => _to;
            set => SetProperty(ref _to, value);
        }

        public ObservableCollection<string> Days
        {
            get => _days;
            set => SetProperty(ref _days, value);
        }

        private void OnDaysCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (Days != null && Days.Count > 0)
            {
                When = null;
            }

            if (SaveCommand is Command cmd)
            {
                cmd?.ChangeCanExecute();
            }
        }
    }
}

