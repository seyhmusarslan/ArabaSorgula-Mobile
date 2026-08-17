/* [grial-metadata] id: Grial#DashboardMultipleTilesPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class DashboardMultipleTilesPage : ContentPage
    {
        public DashboardMultipleTilesPage()
        {
            InitializeComponent();

            BindingContext = new DashboardMultipleTilesViewModel();
        }
    }
}