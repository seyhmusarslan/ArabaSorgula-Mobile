/* [grial-metadata] id: Grial#DashboardCardsPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class DashboardCardsPage : ContentPage
    {
        public DashboardCardsPage()
        {
            InitializeComponent();

            BindingContext = new DashboardCardsViewModel();
        }
    }
}