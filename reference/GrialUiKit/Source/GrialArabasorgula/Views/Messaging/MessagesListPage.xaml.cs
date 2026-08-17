/* [grial-metadata] id: Grial#MessagesListPage.xaml version: 1.0.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class MessagesListPage : ContentPage
    {
        public MessagesListPage()
        {
            InitializeComponent();

            BindingContext = new MessagesListViewModel();
        }

        private async void OnMore(object sender, EventArgs e)
        {
            var mi = (SwipeItem)sender;
            await DisplayAlertAsync("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            var mi = (SwipeItem)sender;
            await DisplayAlertAsync("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }

        private async void OnItemTapped(object sender, EventArgs e)
        {
            var tappedItem = ((View)sender).BindingContext;
            var userName = ((MessageData)tappedItem).From.Name;

            await DisplayAlertAsync("Message Tapped", "You tapped on " + userName + "'s message.", "OK");
        }

        private void OnRefreshing(object sender, EventArgs e)
        {
            var refreshView = sender as RefreshView;
            //refreshView.EndRefresh();
        }
    }
}
