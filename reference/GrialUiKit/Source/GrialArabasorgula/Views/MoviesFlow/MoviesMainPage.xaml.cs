/* [grial-metadata] id: Grial#MoviesMainPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class MoviesMainPage : ContentPage
    {
        public MoviesMainPage()
        {
            InitializeComponent();

            BindingContext = new MoviesMainViewModel();
        }

        private async void OnFeatured(object sender, EventArgs e)
        {
            var page = new MoviesNavigationPage(
                new FeaturedMoviesPage(((MoviesMainViewModel)BindingContext).Featured));

            await Navigation.PushModalAsync(page);
        }
    }
}
