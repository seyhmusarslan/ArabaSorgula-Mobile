/* [grial-metadata] id: Grial#WelcomePage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
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