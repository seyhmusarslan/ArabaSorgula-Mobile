/* [grial-metadata] id: Grial#ChatMessagesPage.xaml version: 2.0.6 */

using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ChatMessagesPage : ContentPage
    {
        public ChatMessagesPage()
            : this(null)
        {
        }

        public ChatMessagesPage(FlowContactData contact)
        {
            InitializeComponent();

            BindingContext = new ChatMessagesViewModel(contact?.Id);
        }

        private async void OnAvatarTapped(object sender, EventArgs args)
        {
            var popup = new ContactPreviewPopup(Navigation)
            {
                BindingContext = ((BindableObject)sender).BindingContext
            };

            await IPopupService.Current.PushAsync(popup);
        }

        private async void OnLabelTapped(object sender, EventArgs args)
        {
            var contact = ((VisualElement)sender).BindingContext as FlowContactData;
            await Navigation.PushAsync(new ContactDetailPage(contact));
        }
    }
}
