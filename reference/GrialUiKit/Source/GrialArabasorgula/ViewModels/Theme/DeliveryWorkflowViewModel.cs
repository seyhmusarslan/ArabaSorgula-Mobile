/* [grial-metadata] id: Grial#DeliveryWorkflowViewModel.cs version: 1.1.6 */
using System.Collections.ObjectModel;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DeliveryWorkflowViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        private string _user, _userImage, _orderID;
        private ShippingAppData _currentStep;

        public DeliveryWorkflowViewModel(INavigation navigation)
         : base(listenCultureChanges: true)
        {
            _navigation = navigation;

            LoadData();

            NextCommand = new Command(OnNext);
            CloseCommand = new Command(OnClose);
            OrderDetailCommand = new Command(OnOrderDetail);
        }

        public ObservableCollection<ShippingAppData> ShippingData { get; } = [];

        public ICommand NextCommand { get; }

        public ICommand CloseCommand { get; }

        public ICommand OrderDetailCommand { get; }

        public ICommand MoveNextStepCommand { get; set; }

        public string User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public string UserImage
        {
            get => _userImage;
            set => SetProperty(ref _userImage, value);
        }

        public string OrderID
        {
            get => _orderID;
            set => SetProperty(ref _orderID, value);
        }

        public ShippingAppData CurrentStep
        {
            get => _currentStep;
            set => SetProperty(ref _currentStep, value);
        }

        private void LoadData()
        {
            ShippingData.Clear();

            JsonHelper.Instance.LoadViewModel(this, source: "Theme.json");

            CurrentStep = ShippingData.FirstOrDefault();
        }

        private async void OnNext(object obj)
        {
            var index = ShippingData.IndexOf(CurrentStep) + 1;
            if (index >= ShippingData.Count)
            {
                await _navigation.PopModalAsync();
                return;
            }

            MoveNextStepCommand.Execute(null);
        }

        private void OnClose()
        {
            _navigation.PopModalAsync();
        }

        private async void OnOrderDetail()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            await Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Alert", "Order detail tapped", "Ok");
        }
    }
}
