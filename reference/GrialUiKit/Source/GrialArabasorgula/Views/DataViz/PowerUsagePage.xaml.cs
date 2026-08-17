/* [grial-metadata] id: Grial#PowerUsagePage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class PowerUsagePage : ContentPage
{
	public PowerUsagePage()
	{
		InitializeComponent();

        BindingContext = new PowerUsageViewModel();
    }
}
