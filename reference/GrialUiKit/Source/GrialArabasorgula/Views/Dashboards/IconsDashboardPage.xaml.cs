/* [grial-metadata] id: Grial#IconsDashboardPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class IconsDashboardPage : ContentPage
    {
        public IconsDashboardPage()
        {
            InitializeComponent();

            BindingContext = new DashboardViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}