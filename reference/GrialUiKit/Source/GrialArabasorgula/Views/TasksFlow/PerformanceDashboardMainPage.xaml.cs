/* [grial-metadata] id: Grial#PerformanceDashboardMainPage.xaml version: 1.0.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class PerformanceDashboardMainPage : ContentPage
    {
        public PerformanceDashboardMainPage()
        {
            InitializeComponent();

            BindingContext = new PerformanceDashboardMainViewModel(Navigation);
        }
    }
}
