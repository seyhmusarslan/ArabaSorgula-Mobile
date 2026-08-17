/* [grial-metadata] id: Grial#TaskBrowserViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class TaskBrowserViewModel : ObservableObject
    {
        private string _date;

        public TaskBrowserViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<TaskOverviewGroupData> Workspaces { get; } = new ObservableCollection<TaskOverviewGroupData>();
        public ObservableCollection<TaskOverviewGroupData> Projects { get; } = new ObservableCollection<TaskOverviewGroupData>();

        public string Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Workspaces.Clear();
            Projects.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "DataViz.json");
        }
    }
}
