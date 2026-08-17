/* [grial-metadata] id: Grial#PreferencesOnboardingViewModel.cs version: 1.0.5 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class PreferencesOnboardingViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        private PermissionsAppData _currentPermission;

        public PreferencesOnboardingViewModel(INavigation navigation)
            : base(listenCultureChanges: true)
        {
            _navigation = navigation;

            LoadData();

            NextCommand = new Command(OnNext);
            CloseCommand = new Command(OnClose);
        }

        public ObservableCollection<PermissionsAppData> PermissionsData { get; } = [];

        public ICommand NextCommand { get; }

        public ICommand CloseCommand { get; }

        public PermissionsAppData CurrentPermission
        {
            get => _currentPermission;
            set => SetProperty(ref _currentPermission, value);
        }

        private void LoadData()
        {
            PermissionsData.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Onboardings.json");

            CurrentPermission = PermissionsData.FirstOrDefault();
        }

        private async void OnNext(object obj)
        {
            var index = PermissionsData.IndexOf(CurrentPermission) + 1;
            if (index >= PermissionsData.Count)
            {
                await _navigation.PopModalAsync();
                return;
            }

            CurrentPermission = PermissionsData.ElementAtOrDefault(index);
        }

        private void OnClose()
        {
            _navigation.PopModalAsync();
        }
    }
}

