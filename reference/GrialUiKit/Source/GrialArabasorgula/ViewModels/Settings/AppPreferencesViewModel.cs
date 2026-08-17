/* [grial-metadata] id: Grial#AppPreferencesViewModel.cs version: 1.0.4 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class AppPreferencesViewModel : ObservableObject
    {
        private double _volume;

        public AppPreferencesViewModel()
          : base(listenCultureChanges: true)
        {
            LoadData();
            Volume = 50;
        }

        public ObservableCollection<SettingsCategoryData> General { get; } = new ObservableCollection<SettingsCategoryData>();
        public ObservableCollection<SettingsCategoryData> Alerts { get; } = new ObservableCollection<SettingsCategoryData>();

        public double Volume
        {
            get => _volume;
            set => SetProperty(ref _volume, value);
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            General.Clear();
            Alerts.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Settings.json");
        }
    }
}
