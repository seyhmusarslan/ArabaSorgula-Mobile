/* [grial-metadata] id: Grial#FlatDashboardPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class FlatDashboardPage : ContentPage
    {
        public FlatDashboardPage()
        {
            InitializeComponent();

            BindingContext = new DashboardViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}