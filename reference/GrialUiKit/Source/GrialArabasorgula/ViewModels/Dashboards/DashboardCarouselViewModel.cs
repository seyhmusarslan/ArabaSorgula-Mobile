/* [grial-metadata] id: Grial#DashboardCarouselViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DashboardCarouselViewModel : ObservableObject
    {
        public DashboardCarouselViewModel()
            : base(listenCultureChanges: true)
        {
            LoadData();
        }

        public ObservableCollection<DashboardItemDataWithCommand> Items { get; } = new ObservableCollection<DashboardItemDataWithCommand>();
        public ObservableCollection<DashboardItemDataWithCommand> Headers { get; } = new ObservableCollection<DashboardItemDataWithCommand>();

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Items.Clear();
            Headers.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Dashboards.json");
        }

        public class DashboardItemDataWithCommand : DashboardItemData
        {
            public DashboardItemDataWithCommand()
            {
                TapCommand = new Command(() => 
                {
                    if (Application.Current == null || Application.Current.Windows.Count == 0)
                    {
                        return;
                    }

                    Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Item Tapped!", $"You have selected: {Name}", "OK");
                });
            }

            public ICommand TapCommand { get; }
        }
    }
}
