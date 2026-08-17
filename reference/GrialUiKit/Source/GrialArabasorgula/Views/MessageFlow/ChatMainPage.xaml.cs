/* [grial-metadata] id: Grial#ChatMainPage.xaml version: 2.0.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ChatMainPage : ContentPage
    {
        public ChatMainPage()
        {
            InitializeComponent();

            BindingContext = new ChatMainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            contacts.SelectedItem = null;
            conversations.SelectedItem = null;
        }

        private async void OnMessageTapped(object sender, EventArgs e)
        {
            var item = ((View)sender).BindingContext as FlowConversationData;

            var page = new ChatMessagesPage(item?.From);

            await Navigation.PushAsync(page);
        }

        private async void OnContactTapped(object sender, EventArgs e)
        {
            var contact = ((View)sender).BindingContext as FlowContactData;
            await Navigation.PushAsync(new ContactDetailPage(contact));
        }

        private async void OnAddContactClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddContactPage());
        }
    }
}
