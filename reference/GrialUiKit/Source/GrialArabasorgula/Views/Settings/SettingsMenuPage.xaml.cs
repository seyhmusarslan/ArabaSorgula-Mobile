/* [grial-metadata] id: Grial#SettingsMenuPage.xaml version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class SettingsMenuPage : ContentPage
{
	public SettingsMenuPage()
	{
		InitializeComponent();

        BindingContext = new SettingsMenuViewModel();
    }
}
