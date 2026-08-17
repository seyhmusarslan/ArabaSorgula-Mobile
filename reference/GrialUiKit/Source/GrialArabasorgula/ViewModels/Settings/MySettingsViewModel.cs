/* [grial-metadata] id: Grial#MySettingsViewModel.cs version: 1.0.4 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class MySettingsViewModel : ObservableObject
    {
        private SettingsUserData _userData;

        public MySettingsViewModel()
          : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<SettingsCategoryData> Categories { get; } = new ObservableCollection<SettingsCategoryData>();
        public ObservableCollection<SettingsMainCategoryData> MainCategories { get; } = new ObservableCollection<SettingsMainCategoryData>();

        public SettingsUserData UserData
        {
            get { return _userData; }
            set { SetProperty(ref _userData, value); }
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            UserData = null;
            Categories.Clear();
            MainCategories.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Settings.json");
        }
    }
}

