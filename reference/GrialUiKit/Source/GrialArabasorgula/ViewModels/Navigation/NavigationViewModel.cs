/* [grial-metadata] id: Grial#NavigationViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NavigationViewModel : ObservableObject
    {
        private readonly string _variantPageName;
        private NavigationCategoryData _category;
        private NavigationItemData _selectedItem;

        public NavigationViewModel(string variantPageName = null)
            : base(listenCultureChanges: true)
        {
            _variantPageName = variantPageName;

            TapCommand = new Command(OnItemTap);

            LoadData();
        }

        public ICommand TapCommand { get; }

        public ObservableCollection<NavigationItemData> Items { get; } = new ObservableCollection<NavigationItemData>();

        public NavigationCategoryData Category
        {
            get { return _category; }
            set { SetProperty(ref _category, value); }
        }

        public NavigationItemData SelectedItem
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
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            var item = (NavigationItemData)param;
            Application.Current.Windows[0].Page.DisplayAlertAsync("Item Tapped!", $"You have tapped: {item.Name}", "OK");
        }

        private void LoadData()
        {
            Category = null;
            Items.Clear();

            JsonHelper.Instance.LoadViewModel(this, pageName: _variantPageName, source: "Navigation.json");
        }
    }
}