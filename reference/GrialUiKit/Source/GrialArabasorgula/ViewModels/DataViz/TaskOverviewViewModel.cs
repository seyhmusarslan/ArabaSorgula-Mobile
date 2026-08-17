/* [grial-metadata] id: Grial#TaskOverviewViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class TaskOverviewViewModel : ObservableObject
    {
        private BrowserTaskOverviewData _urgent, _maintenance, _closed;
        private string _period;

        public TaskOverviewViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<BrowserPeopleTaskOverviewData> People { get; } = new ObservableCollection<BrowserPeopleTaskOverviewData>();

        public ObservableCollection<BrowserTaskOverviewData> Data { get; } = new ObservableCollection<BrowserTaskOverviewData>();

        public string Period
        {
            get { return _period; }
            set { SetProperty(ref _period, value); }
        }

        public BrowserTaskOverviewData Urgent
        {
            get { return _urgent; }
            set { SetProperty(ref _urgent, value); }
        }

        public BrowserTaskOverviewData Maintenance
        {
            get { return _maintenance; }
            set { SetProperty(ref _maintenance, value); }
        }

        public BrowserTaskOverviewData Closed
        {
            get { return _closed; }
            set { SetProperty(ref _closed, value); }
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            People.Clear();
            Data.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");

            Data.Add(Urgent);
            Data.Add(Maintenance);
            Data.Add(Closed);
        }
    }
}
