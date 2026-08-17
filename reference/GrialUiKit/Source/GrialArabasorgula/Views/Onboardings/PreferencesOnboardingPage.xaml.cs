/* [grial-metadata] id: Grial#PreferencesOnboardingPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class PreferencesOnboardingPage : ContentPage
{
	public PreferencesOnboardingPage()
	{
		InitializeComponent();

        BindingContext = new PreferencesOnboardingViewModel(Navigation);
    }
}
 