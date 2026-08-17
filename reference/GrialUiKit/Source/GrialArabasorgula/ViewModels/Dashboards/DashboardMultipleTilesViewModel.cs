/* [grial-metadata] id: Grial#DashboardMultipleTilesViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DashboardMultipleTilesViewModel : ObservableObject
    {
        public DashboardMultipleTilesViewModel()
            : base(listenCultureChanges: true)
        {
            TapCommand = new Command(OnItemTap);

            LoadData();
        }

        public ICommand TapCommand { get; }

        public ObservableCollection<DashboardMultipleTileItemData> Items { get; } = new ObservableCollection<DashboardMultipleTileItemData>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void OnItemTap(object param)
        {
            if (Application.Current?.Windows.Count > 0 == false)
            {
                return;
            }

            var item = (DashboardMultipleTileItemData)param;
            Application.Current?.Windows[0].Page.DisplayAlertAsync("Item Tapped!", $"You have tapped: {item.Title}", "OK");
        }

        private void LoadData()
        {
            Items.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Dashboards.json");
        }
    }
}