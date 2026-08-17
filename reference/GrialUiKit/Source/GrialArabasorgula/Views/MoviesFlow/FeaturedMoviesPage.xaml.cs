/* [grial-metadata] id: Grial#FeaturedMoviesPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class FeaturedMoviesPage : ContentPage
    {
        public FeaturedMoviesPage()
            : this(null)
        {
        }

        public FeaturedMoviesPage(FeaturedMoviesViewModel context)
        {
            InitializeComponent();

            BindingContext = context ?? new FeaturedMoviesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (DeviceInfo.Current.Platform == DevicePlatform.iOS)
            {
                carousel.IsScrollAnimated = true;
            }
        }
        private void OnTapped(object sender, TappedEventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
