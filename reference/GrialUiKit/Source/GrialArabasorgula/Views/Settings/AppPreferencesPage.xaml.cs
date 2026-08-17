/* [grial-metadata] id: Grial#AppPreferencesPage.xaml version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class AppPreferencesPage : ContentPage
{
	public AppPreferencesPage()
	{
		InitializeComponent();

        BindingContext = new AppPreferencesViewModel();
    }
}
