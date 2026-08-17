/* [grial-metadata] id: Grial#ExplorerItemActionsPopupTemplate.xaml version: 1.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class ExplorerItemsActionsPopupTemplate : PopupPage
{
    public ExplorerItemsActionsPopupTemplate(ExplorerItemsActionsPopupViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }

    private async void OnTapped(System.Object sender, System.EventArgs e)
    {
        await IPopupService.Current.PopAsync();
    }
}
