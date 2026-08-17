/* [grial-metadata] id: Grial#SmartHomeAirSettingsPage.xaml version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class SmartHomeAirSettingsPage : ContentPage
{
	public SmartHomeAirSettingsPage(RoomDeviceItemData device)
	{
		InitializeComponent();

        BindingContext = new SmartHomeAirSettingsViewModel(device);
    }

    public SmartHomeAirSettingsPage()
    {
        InitializeComponent();

        BindingContext = new SmartHomeAirSettingsViewModel();
    }
}
