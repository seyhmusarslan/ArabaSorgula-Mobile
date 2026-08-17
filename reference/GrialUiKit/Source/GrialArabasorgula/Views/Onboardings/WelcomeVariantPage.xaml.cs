/* [grial-metadata] id: Grial#WelcomeVariantPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WelcomeVariantPage : ContentPage
    {
        public WelcomeVariantPage()
        {
            InitializeComponent();
        }

        public async void OnWhatsNew(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WalkthroughImagePage());
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
