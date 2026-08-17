/* [grial-metadata] id: Grial#IrregularDialog.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class IrregularDialog : PopupPage
{
    public IrregularDialog()
    {
        InitializeComponent();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await IPopupService.Current.PopAsync();
    }
}
