/* [grial-metadata] id: Grial#ContactSimpleDetailPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ContactSimpleDetailPage : ContentPage
    {
        public ContactSimpleDetailPage()
        {
            InitializeComponent();

            BindingContext = new ContactSimpleDetailViewModel();
        }

        private async void OnEdit(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Edit tapped", "Navigate to the edit contact page.", Resx.AppResources.StringOK);
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}