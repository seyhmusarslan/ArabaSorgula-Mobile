/* [grial-metadata] id: Grial#ContactPreviewPopup.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Maui.Controls;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ContactPreviewPopup : PopupPage
    {
        private readonly INavigation _navigation;

        public ContactPreviewPopup(INavigation navigation)
        {
            _navigation = navigation;

            InitializeComponent();
        }

        private async void OnMessageIconTapped(object sender, EventArgs e)
        {
            await IPopupService.Current.PopAsync();

            var last = _navigation.NavigationStack.Count - 1;
            if (last < 0 || !(_navigation.NavigationStack[last] is ChatMessagesPage))
            {
                var page = new ChatMessagesPage(BindingContext as FlowContactData);
                await _navigation.PushAsync(page);
            }
        }

        private async void OnPhoneIconTapped(object sender, EventArgs e)
        {
            var popup = new SimpleActionPopup()
            {
                Title = "Phone tapped", 
                Text = "Nothing to see here, try chat or info :)",
                ActionButtonText = Resx.AppResources.StringOK,
                ShowSecondaryActionButton = false,
            };

            await IPopupService.Current.PushAsync(popup);
        }

        private async void OnVideoIconTapped(object sender, EventArgs e)
        {
            var popup = new SimpleActionPopup()
            {
                Title = "Video tapped", 
                Text = "Nothing to see here, try chat or info :)",
                ActionButtonText = Resx.AppResources.StringOK,
                ShowSecondaryActionButton = false,
            };

            await IPopupService.Current.PushAsync(popup);
        }

        private async void OnInfoIconTapped(object sender, EventArgs e)
        {
            await IPopupService.Current.PopAsync();

            var page = new ContactDetailPage(BindingContext as FlowContactData);
            await _navigation.PushAsync(page);
        }
    }
}
