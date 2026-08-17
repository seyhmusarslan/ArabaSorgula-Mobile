/* [grial-metadata] id: Grial#SettingsMenuViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SettingsMenuViewModel : ObservableObject
    {
        private SettingsMenuPromoData _promoData;

        public SettingsMenuViewModel()
          : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<SettingsCategoryData> Settings { get; } = new ObservableCollection<SettingsCategoryData>();

        public ICommand CloseCommand { get; } = new Command(OnClose);

        public SettingsMenuPromoData PromoData
        {
            get { return _promoData; }
            set { SetProperty(ref _promoData, value); }
        }

        private static void OnClose(object obj)
        {
            if (IPopupService.Current.NavigationStack.Count == 0)
            {
                return;
            }

            IPopupService.Current.PopAsync();
        }
        
        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            PromoData = null;
            Settings.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Settings.json");
        }
    }
}

