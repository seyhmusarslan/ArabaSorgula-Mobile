/* [grial-metadata] id: Grial#WalkthroughViewModel.cs version: 1.0.1 */
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class WalkthroughViewModel : ObservableObject
    {
        private readonly INavigation _navigation;

        private string _pageName;
        private int _position;

        public WalkthroughViewModel(string pageName, INavigation navigation)
            : base(listenCultureChanges: true)
        {
            _pageName = pageName;
            _navigation = navigation;
            LoadData();
        }

        public ObservableCollection<WalkthroughBaseItemData> Items { get; } = new ObservableCollection<WalkthroughBaseItemData>();

        public ICommand ActionButtonCommand => new Command(OnActionButtonCommand);
        public ICommand CloseCommand => new Command(OnCloseCommand);
        public ICommand MoveNextCommand { get; set; }

        public int Position
        {
            get => _position;
            set
            {
                if (SetProperty(ref _position, value))
                {
                    NotifyPropertyChanged(nameof(IsLastPosition));
                }
            }
        }

        public bool IsLastPosition => Position == Items.Count - 1;

        protected override void OnCultureChanged(CultureInfo culture)
        {
            LoadData();
        }

        private void LoadData()
        {
            Items.Clear();

            JsonHelper.Instance.LoadViewModel(this, "Onboardings.json", _pageName);
        }

        private void OnActionButtonCommand()
        {
            if (IsLastPosition)
            {
                OnCloseCommand();
                return;
            }

            MoveNextCommand?.Execute(null);
        }

        private void OnCloseCommand()
        {
            if (_navigation.ModalStack.Count > 0)
            {
                _navigation.PopModalAsync();
            }
        }
    }
}