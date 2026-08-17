/* [grial-metadata] id: Grial#CalendarShowcasePage.xaml version: 1.0.5 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class CalendarShowcasePage : ContentPage
{
	public CalendarShowcasePage()
	{
		InitializeComponent();

        BindingContext = new CalendarShowcaseViewModel();
    }
}
