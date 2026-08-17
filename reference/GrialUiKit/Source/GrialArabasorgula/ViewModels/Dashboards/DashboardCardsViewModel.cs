/* [grial-metadata] id: Grial#DashboardCardsViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DashboardCardsViewModel : ObservableObject
    {
        public DashboardCardsViewModel()
            : base(listenCultureChanges: true)
        {
            TapCommand = new Command(OnItemTap);

            LoadData();
        }

        public ICommand TapCommand { get; }

        public ObservableCollection<DashboardCardItemData> Items { get; } = new ObservableCollection<DashboardCardItemData>();

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

            var item = (DashboardCardItemData)param;
            Application.Current?.Windows[0].Page.DisplayAlertAsync("Item Tapped!", $"You have tapped: {item.Title}", "OK");
        }

        private void LoadData()
        {
            Items.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Dashboards.json");
        }
    }
}