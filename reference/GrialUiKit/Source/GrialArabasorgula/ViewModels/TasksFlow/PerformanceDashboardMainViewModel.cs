/* [grial-metadata] id: Grial#PerformanceDashboardMainViewModel.cs version: 1.0.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PerformanceDashboardMainViewModel : ObservableObject
    {
        private string _selectedPeriod;
        private FlowSeriesData _selectedPeriodData;
        private FlowChartData _chartData;
        private readonly INavigation _navigation;

        public PerformanceDashboardMainViewModel(INavigation navigation)
        {
            _navigation = navigation;
            ShowDetailCommand = new Command<FlowEmployeeData>(OnShowDetail);

            LoadData();
        }

        public ObservableCollection<FlowEmployeeData> TeamMembers { get; } = new ObservableCollection<FlowEmployeeData>();

        public ObservableCollection<FlowMetricData> Metrics { get; } = new ObservableCollection<FlowMetricData>();

        public ObservableCollection<string> Periods { get; } = new ObservableCollection<string>();

        public ICommand ShowDetailCommand { get; }

        public FlowChartData ChartData
        {
            get { return _chartData; }
            set { SetProperty(ref _chartData, value); }
        }

        public FlowSeriesData SelectedPeriodData
        {
            get { return _selectedPeriodData; }
            set { SetProperty(ref _selectedPeriodData, value); }
        }

        public string SelectedPeriod
        {
            get { return _selectedPeriod; }
            set
            {
                if (SetProperty(ref _selectedPeriod, value))
                {
                    if (value == Resx.AppResources.StringLastMonth)
                    {
                        SelectedPeriodData = ChartData.LastMonth;
                    }
                    else if (value == Resx.AppResources.StringLastYear)
                    {
                        SelectedPeriodData = ChartData.LastYear;
                    }
                    else
                    {
                        SelectedPeriodData = ChartData.LastWeek;
                    }
                }
            }
        }
        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }
        private void LoadData()
        {
            TeamMembers.Clear();
            Metrics.Clear();
            Periods.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "TasksFlow.json");

            SelectedPeriod = Periods.FirstOrDefault();
        }

        private async void OnShowDetail(FlowEmployeeData data)
        {
            await _navigation.PushAsync(new EmployeePerformanceDashboardPage(data));
        }
    }
}
