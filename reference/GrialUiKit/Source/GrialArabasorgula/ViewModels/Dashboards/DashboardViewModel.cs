/* [grial-metadata] id: Grial#DashboardViewModel.cs version: 1.1.6 */
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DashboardViewModel : ObservableObject
    {
        private readonly string _variantPageName;
        private DashboardCategoryData _category;
        private DashboardItemData _selectedItem;

        public DashboardViewModel(string variantPageName = null)
            : base(listenCultureChanges: true)
        {
            _variantPageName = variantPageName;

            TapCommand = new Command(OnItemTap);

            LoadData();
        }

        public ICommand TapCommand { get; }

        public ObservableCollection<DashboardItemData> Items { get; } = new ObservableCollection<DashboardItemData>();

        public DashboardCategoryData Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        public DashboardItemData SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (SetProperty(ref _selectedItem, value) && value != null)
                {
                    if (Application.Current != null && Application.Current.Windows.Count > 0)
                    {
                        Application.Current.Windows[0].Page.DisplayAlertAsync("Item Selected!", $"You have selected: {value.Name}", "OK");
                    }
                    
                    SetProperty(ref _selectedItem, null);
                }
            }
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void OnItemTap(object param)
        {
            var item = (DashboardItemData)param;

            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Item Tapped!", $"You have tapped: {item.Name}", "OK");
        }

        private void LoadData()
        {
            Category = null;
            Items.Clear();

            JsonHelper.Instance.LoadViewModel(this, pageName: _variantPageName, source: "Dashboards.json");
        }
    }
}