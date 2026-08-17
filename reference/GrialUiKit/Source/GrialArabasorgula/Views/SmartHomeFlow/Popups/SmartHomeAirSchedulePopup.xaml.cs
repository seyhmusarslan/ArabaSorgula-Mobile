/* [grial-metadata] id: Grial#SmartHomeAirSchedulePopup.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class SmartHomeAirSchedulePopup : PopupPage
{
    public SmartHomeAirSchedulePopup(SmartHomeAirSchedulePopupViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }

    private void OnClose(object sender, EventArgs e)
    {
        IPopupService.Current.PopAsync();
    }
}
