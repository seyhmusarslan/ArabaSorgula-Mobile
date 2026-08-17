/* [grial-metadata] id: Grial#UsersAnalyticsPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class UsersAnalyticsPage : ContentPage
{
	public UsersAnalyticsPage()
	{
		InitializeComponent();

		BindingContext = new UsersAnalyticsViewModel();
	}
}