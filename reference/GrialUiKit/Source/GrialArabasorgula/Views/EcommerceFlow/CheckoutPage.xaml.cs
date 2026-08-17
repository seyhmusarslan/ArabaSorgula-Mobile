/* [grial-metadata] id: Grial#CheckoutPage.xaml version: 1.1.6 */

using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class CheckoutPage : ContentPage
    {
        public CheckoutPage()
        {
            InitializeComponent();

            BindingContext = new OrderConfirmationViewModel(null);
        }

        public CheckoutPage(OrderConfirmationViewModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Triggers.Clear();
        }

        private async void OnConfirm(object sender, System.EventArgs e)
        {
            var dialog = new NotificationPopup { Message = Resx.AppResources.OrderPlacedNotification };

            await IPopupService.Current.PushAsync(dialog);

            await Navigation.PopToRootAsync();
        }
    }
}
