/* [grial-metadata] id: Grial#SocialPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class SocialPage : ContentPage
    {
        public SocialPage()
        {
            InitializeComponent();

            BindingContext = new SocialViewModel();
        }

        private async void OnAvatarTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}