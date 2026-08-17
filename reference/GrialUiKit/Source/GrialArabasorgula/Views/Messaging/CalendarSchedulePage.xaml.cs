/* [grial-metadata] id: Grial#CalendarSchedulePage.xaml version: 1.0.5 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class CalendarSchedulePage : ContentPage
{
	public CalendarSchedulePage()
	{
        InitializeComponent();

        BindingContext = new CalendarScheduleViewModel();
    }
}