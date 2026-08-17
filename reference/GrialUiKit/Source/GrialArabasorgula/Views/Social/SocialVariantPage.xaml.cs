/* [grial-metadata] id: Grial#SocialVariantPage.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class SocialVariantPage : ContentPage
    {
        public SocialVariantPage()
        {
            InitializeComponent();

            BindingContext = new SocialViewModel(variantPageName: $"{GetType().Name}.xaml");
        }

        private async void OnAvatarTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
    }
}