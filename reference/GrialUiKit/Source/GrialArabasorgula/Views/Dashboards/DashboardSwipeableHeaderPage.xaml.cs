/* [grial-metadata] id: Grial#DashboardSwipeableHeaderPage.xaml version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class DashboardSwipeableHeaderPage : ContentPage
{
	public DashboardSwipeableHeaderPage()
	{
		InitializeComponent();

		BindingContext = new DashboardCarouselViewModel();
	}
}
