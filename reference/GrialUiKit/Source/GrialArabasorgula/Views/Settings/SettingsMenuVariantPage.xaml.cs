/* [grial-metadata] id: Grial#SettingsMenuVariantPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class SettingsMenuVariantPage : ContentPage
{
	public SettingsMenuVariantPage()
	{
		InitializeComponent();
        BindingContext = new SettingsMenuVariantViewModel(Navigation);
    }
}
