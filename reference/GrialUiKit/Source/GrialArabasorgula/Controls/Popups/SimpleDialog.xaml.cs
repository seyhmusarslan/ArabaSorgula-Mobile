/* [grial-metadata] id: Grial#SimpleDialog.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class SimpleDialog : PopupPage
{
    public SimpleDialog()
    {
        InitializeComponent();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await IPopupService.Current.PopAsync();
    }
}
