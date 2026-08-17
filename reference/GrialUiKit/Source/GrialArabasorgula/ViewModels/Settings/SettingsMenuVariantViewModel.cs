/* [grial-metadata] id: Grial#SettingsMenuVariantViewModel.cs version: 1.0.4 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SettingsMenuVariantViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        private SettingsUserData _userData;

        public SettingsMenuVariantViewModel(INavigation navigation) : base(listenCultureChanges: true)
        {
            _navigation = navigation;

            LoadData();

            CloseCommand = new Command(OnClose);
        }

        public ObservableCollection<SettingsCategoryData> Settings { get; } = new ObservableCollection<SettingsCategoryData>();

        public ICommand CloseCommand { get; }

        public SettingsUserData UserData
        {
            get { return _userData; }
            set { SetProperty(ref _userData, value); }
        }

        private async void OnClose()
        {
            await _navigation.PopModalAsync();
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            UserData = null;
            Settings.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Settings.json");
        }
    }
}

