/* [grial-metadata] id: Grial#EmployeeProfileDashboardViewModel.cs version: 1.0.6 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class EmployeeProfileDashboardViewModel : ObservableObject
    {
        private FlowEmployeeData _employee;
        private string _notes;
        private readonly INavigation _navigation;

        public EmployeeProfileDashboardViewModel(FlowEmployeeData employee, INavigation navigation)
        {
            _navigation = navigation;
            OpenPerformanceCommand = new Command<FlowEmployeeData>(OnOpenPerformance);

            LoadData();

            if (employee != null)
            {
                Employee = employee;
            }

            Remove(Employee);
        }

        public ObservableCollection<FlowEmployeeData> TeamMembers { get; } = new ObservableCollection<FlowEmployeeData>();

        public ICommand OpenPerformanceCommand { get; }

        public FlowEmployeeData Employee
        {
            get { return _employee; }
            set { SetProperty(ref _employee, value); }
        }

        public string Notes
        {
            get { return _notes; }
            set { SetProperty(ref _notes, value); }
        }

        private void Remove(FlowEmployeeData employee)
        {
            for (var i = 0; i < TeamMembers.Count; i++)
            {
                if (TeamMembers[i].Name == employee.Name)
                {
                    TeamMembers.RemoveAt(i);
                    break;
                }
            }
        }

        private void LoadData()
        {
            TeamMembers.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "TasksFlow.json");
        }

        private async void OnOpenPerformance(FlowEmployeeData data)
        {
            await _navigation.PushAsync(new EmployeePerformanceDashboardPage(data));
        }
    }
}