/* [grial-metadata] id: Grial#ContactDetailPage.xaml version: 1.0.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage()
            : this(null)
        {
        }

        public ContactDetailPage(FlowContactData contact = null)
        {
            InitializeComponent();

            BindingContext = new ContactDetailViewModel(contact?.Id);
        }

        private async void OnEdit(object sender, EventArgs e)
        {
            var page = new AddContactPage(((BindableObject)sender).BindingContext as FlowContactData);
            await Navigation.PushAsync(page);
        }

        private async void OnMessage(object sender, EventArgs e)
        {
            var prev = Navigation.NavigationStack.Count - 2;
            if (prev < 0 || !(Navigation.NavigationStack[prev] is ChatMessagesPage))
            {
                var page = new ChatMessagesPage(((BindableObject)sender).BindingContext as FlowContactData);
                await Navigation.PushAsync(page);
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

        private async void OnEmail(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Email tapped", "Nothing to see here, try messages :)", Resx.AppResources.StringOK);
        }

        private async void OnHome(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Home tapped", "Nothing to see here, try messages :)", Resx.AppResources.StringOK);
        }

        private async void OnMobile(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Mobile tapped", "Nothing to see here, try messages :)", Resx.AppResources.StringOK);
        }
    }
}
