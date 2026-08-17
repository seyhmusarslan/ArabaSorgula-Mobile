/* [grial-metadata] id: Grial#MySettingsPage.xaml version: 1.0.6 */

using UXDivers.Grial;
namespace arabasorgula;

public partial class MySettingsPage : ContentPage
{
	public MySettingsPage()
	{
		InitializeComponent();

        BindingContext = new MySettingsViewModel();
    }

    private async void OnItemTapped(object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new ProfileSettingsPage());
    }
}
