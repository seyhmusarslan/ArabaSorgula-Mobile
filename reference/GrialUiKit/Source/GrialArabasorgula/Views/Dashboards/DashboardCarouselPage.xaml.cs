/* [grial-metadata] id: Grial#DashboardCarouselPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class DashboardCarouselPage : ContentPage
    {
        public DashboardCarouselPage()
        {
            InitializeComponent();

            BindingContext = new DashboardCarouselViewModel();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Triggers.Clear();
        }
    }
}