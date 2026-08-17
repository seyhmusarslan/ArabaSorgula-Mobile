/* [grial-metadata] id: Grial#ImagesDashboardPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ImagesDashboardPage : ContentPage
    {
        public ImagesDashboardPage()
        {
            InitializeComponent();

            BindingContext = new DashboardViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}