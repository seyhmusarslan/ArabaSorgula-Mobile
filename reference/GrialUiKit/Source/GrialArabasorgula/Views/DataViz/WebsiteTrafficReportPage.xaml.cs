/* [grial-metadata] id: Grial#WebsiteTrafficReportPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class WebsiteTrafficReportPage : ContentPage
{
	public WebsiteTrafficReportPage()
	{
		InitializeComponent();

        BindingContext = new WebsiteTrafficReportViewModel();
    }
}

