using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class MainMenuViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        private readonly Action<Page> _openPageAsRoot;
        private List<MenuEntry> _mainMenuEntries;
        private MenuEntry _selectedMainMenuEntry;

        public MainMenuViewModel(INavigation navigation, Action<Page> openPageAsRoot)
            : base(listenCultureChanges: true)
        {
            _navigation = navigation;
            _openPageAsRoot = openPageAsRoot;

            LoadData();

            var firstEntry = _mainMenuEntries[0];
            if (firstEntry.IsModal)
            {
                openPageAsRoot(new NavigationPage(new WelcomeKickoffPage()));
            }
            else
            {
                MainMenuSelectedItem = firstEntry;
            }
        }

        public List<MenuEntry> MainMenuEntries
        {
            get { return _mainMenuEntries; }
            set { SetProperty(ref _mainMenuEntries, value); }
        }

        public MenuEntry MainMenuSelectedItem
        {
            get { return _selectedMainMenuEntry; }
            set 
            { 
                if (SetProperty(ref _selectedMainMenuEntry, value) && value != null)
                {
                    Page page;

                    if (value.PageType != null)
                    {
                        page = CreatePage(value.PageType);
                    }
                    else
                    {
                        page = value.CreatePage();
                    }

                    NavigationPage navigationPage;

                    if (value.NavigationPageType == null)
                    {
                        navigationPage = new NavigationPage(page);
                    }
                    else
                    {
                        navigationPage = (NavigationPage)Activator.CreateInstance(value.NavigationPageType, page);
                    }

                    if (_selectedMainMenuEntry.IsModal)
                    {

                        _navigation.PushModalAsync(navigationPage);
                    }
                    else
                    {
                        _openPageAsRoot(navigationPage);
                    }

                    _selectedMainMenuEntry = null;
                    NotifyPropertyChanged(nameof(MainMenuSelectedItem));
                }
            }
        }

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            var entries = new List<MenuEntry>();

            foreach (var cat in SamplesCatalog.SamplesCategoryList)
            {
                entries.Add(new MenuEntry
                {
                    Name = cat.Name,
                    Icon = cat.Icon,
                    CreatePage = () => new SamplesListPage(cat.Id)
                });
            }

            MainMenuEntries = entries;
        }

        private Page CreatePage(Type pageType)
        {
            return Activator.CreateInstance(pageType) as Page;
        }

        public class MenuEntry
        {
            public string Name { get; set; }
            public string Icon { get; set; }
            public bool UseTransparentNavBar { get; set; }
            public Type PageType { get; set; }
            public Func<Page> CreatePage { get; set; }
            public Type NavigationPageType { get; set; }
            public bool IsModal { get; set; }
        }
    }
}