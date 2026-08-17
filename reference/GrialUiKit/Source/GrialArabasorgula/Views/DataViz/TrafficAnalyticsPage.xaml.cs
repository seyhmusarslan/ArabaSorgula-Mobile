/* [grial-metadata] id: Grial#TrafficAnalyticsPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class TrafficAnalyticsPage : ContentPage
{
	public TrafficAnalyticsPage()
	{
		InitializeComponent();

        BindingContext = new TrafficAnalyticsViewModel();
    }
}
