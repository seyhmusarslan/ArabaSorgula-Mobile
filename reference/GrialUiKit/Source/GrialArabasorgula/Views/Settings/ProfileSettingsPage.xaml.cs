/* [grial-metadata] id: Grial#ProfileSettingsPage.xaml version: 1.1.6 */

using UXDivers.Grial;
namespace arabasorgula;

public partial class ProfileSettingsPage : ContentPage
{
    public ProfileSettingsPage()
    {
        InitializeComponent();
        BindingContext = new ProfileSettingsViewModel(Navigation);
    }
}
