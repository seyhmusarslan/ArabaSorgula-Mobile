/* [grial-metadata] id: Grial#SocialGalleryImagePreviewPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class SocialGalleryImagePreviewPage : ContentPage
    {
        public SocialGalleryImagePreviewPage(ImageSource source)
        {
            InitializeComponent();
            img.Source = source;
        }

        private async void OnImagePreviewDoubleTapped(object sender, EventArgs args)
        {
            const uint AnimationDuration = 100;

            if ((int)img.Scale == 1)
            {
                await img.ScaleToAsync(2, AnimationDuration, Easing.SinInOut);
            }
            else
            {
                await img.ScaleToAsync(1, AnimationDuration, Easing.SinInOut);
            }
        }

        private async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
